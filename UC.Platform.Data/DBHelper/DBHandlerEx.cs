using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Threading;
using UC.Platform.Data.Utils;

namespace UC.Platform.Data.DBHelper
{
    public sealed class DBHandlerEx
    {
        private static IDatabaseProviderFactory _factory;

        private static readonly Type _dataSetType = typeof (DataSet);
        private static readonly Type _dataTableType = typeof (DataTable);

        private static readonly Hashtable _dataSetTypeTable = new Hashtable();

        private static readonly LocalDataStoreSlot _exceptionSlot = Thread.GetNamedDataSlot("PlatformDBHandlerException");

        private readonly Hashtable _procParaeters = new Hashtable();
        //private DbDataAdapter _adapter;
        //private DbCommand _command;
        private readonly DbConnection _connection;
        private DbTransaction _transaction;
        private bool _transactionOpenConnection;

        private DBHandlerEx()
        {
            _connection = _factory.CreateConnection();
        }



        public DbConnection Connection
        {
            get { return _connection; }
        }

        public ConnectionState ConnectonState
        {
            get { return _connection.State; }
        }

        public bool IsConnectionOpened
        {
            get { return (_connection.State == ConnectionState.Open); }
        }

        public IsolationLevel IsolationLevel
        {
            get { return _transaction.IsolationLevel; }
        }

        public DbTransaction Transaction
        {
            get { return _transaction; }
        }

        public bool BeginTransaction()
        {
            return BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public bool BeginTransaction(IsolationLevel level)
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                    _transactionOpenConnection = true;
                }
                else
                {
                    _transactionOpenConnection = false;
                }
                _transaction = _connection.BeginTransaction(level);
                return true;
            }
            catch (Exception exception)
            {
                _transaction = null;
                if (_transactionOpenConnection)
                {
                    _connection.Close();
                }
                _transactionOpenConnection = false;
                handleException(exception, level.ToString());
                return false;
            }
        }

        public static void CleanException()
        {
            Thread.SetData(_exceptionSlot, null);
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public DbParameter CreateParameter()
        {
            return _factory.CreateParameter();
        }

        public DbParameter CreateParameter(string name)
        {
            DbParameter parameter = _factory.CreateParameter();
            parameter.ParameterName = name;
            return parameter;
        }

        public DbParameter CreateParameter(string name, object value)
        {
            DbParameter parameter = _factory.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value ?? DBNull.Value;
            return parameter;
        }

        public bool EndTransaction(bool commit)
        {
            if (_transaction == null)
            {
                return false;
            }
            try
            {
                if (commit)
                {
                    _transaction.Commit();
                }
                else
                {
                    _transaction.Rollback();
                }
                return true;
            }
            catch (Exception exception)
            {
                handleException(exception, commit ? "Commit" : "Rollback");
                return false;
            }
            finally
            {
                _transaction = null;
                if (_transactionOpenConnection)
                {
                    _connection.Close();
                }
                _transactionOpenConnection = false;
            }
        }

        public int ExecuteNonQuery(string strSql)
        {
            return ExecuteNonQuery(_transaction, strSql);
        }

        public int ExecuteNonQuery(string strSql, DbParameter[] parameters)
        {
            return ExecuteNonQuery(_transaction, strSql, parameters);
        }

        public int ExecuteNonQuery(DbTransaction transaction, string strSql)
        {
            return ExecuteNonQuery(transaction, strSql, null);
            //int num2;
            //bool flag = false;
            //DateTime now = DateTime.Now;
            //DbCommand command = this.GetCommand(transaction);
            //try
            //{
            //    if (command.Connection.State != ConnectionState.Open)
            //    {
            //        command.Connection.Open();
            //        flag = true;
            //    }
            //    command.CommandType = CommandType.Text;
            //    command.Parameters.Clear();
            //    strSql = GetReplaceSql(strSql);
            //    command.CommandText = strSql;
            //    int result = command.ExecuteNonQuery();
            //    if (PlatformConfig.DBHandlerWriteLog)
            //    {
            //        DBHandlerLogSink.WriteExecuteNonQueryLog(strSql, result, (TimeSpan)(DateTime.Now - now));
            //    }
            //    num2 = result;
            //}
            //catch (Exception exception)
            //{
            //    if (PlatformConfig.DBHandlerWriteLog)
            //    {
            //        DBHandlerLogSink.WriteExecuteNonQueryExceptionLog(strSql, exception, (TimeSpan)(DateTime.Now - now));
            //    }
            //    this.HandleException(exception, strSql);
            //    num2 = -1;
            //}
            //finally
            //{
            //    if (flag)
            //    {
            //        command.Connection.Close();
            //    }
            //    command.Transaction = null;
            //}
            //return num2;
        }

        public int ExecuteNonQuery(DbTransaction transaction, string strSql, DbParameter[] parameters)
        {
            int num2;
            bool flag = false;
            DbCommand command = getCommand();
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    flag = true;
                }
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();

                //王伟2007-12-05注
                //strSql = GetReplaceSql(strSql);
                command.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (DbParameter parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                int result = command.ExecuteNonQuery();

                num2 = result;
            }
            catch (Exception exception)
            {
                handleException(exception, strSql);
                num2 = -1;
            }
            finally
            {
                if (flag)
                {
                    command.Connection.Close();
                }
                command.Transaction = null;
            }
            return num2;
        }


        public static int ExecuteNonQueryOnce(string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.ExecuteNonQuery(strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int ExecuteNonQueryOnce(string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.ExecuteNonQuery(strSql, parameters);
            buffer.FreeBuffer();
            return num;
        }

        public static int[] ExecuteNonQueryOnce(string[] strSql)
        {
            int[] numArray2;
            DBHandlerEx buffer = GetBuffer();
            try
            {
                if (!buffer.BeginTransaction())
                {
                    return null;
                }
                var numArray = new int[strSql.Length];
                for (int i = 0; i < strSql.Length; i++)
                {
                    numArray[i] = buffer.ExecuteNonQuery(strSql[i]);
                    if (numArray[i] < 0)
                    {
                        buffer.EndTransaction(false);
                        return null;
                    }
                }
                buffer.EndTransaction(true);
                numArray2 = numArray;
            }
            finally
            {
                buffer.FreeBuffer();
            }
            return numArray2;
        }

        public static int ExecuteNonQueryOnce(DbTransaction transaction, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.ExecuteNonQuery(transaction, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int ExecuteNonQueryOnce(DbTransaction transaction, string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.ExecuteNonQuery(transaction, strSql, parameters);
            buffer.FreeBuffer();
            return num;
        }

        public static int[] ExecuteNonQueryOnce(DbTransaction transaction, string[] strSql)
        {
            int[] numArray2;
            DBHandlerEx buffer = GetBuffer();
            try
            {
                var numArray = new int[strSql.Length];
                for (int i = 0; i < strSql.Length; i++)
                {
                    numArray[i] = buffer.ExecuteNonQuery(transaction, strSql[i]);
                    if (numArray[i] < 0)
                    {
                        return null;
                    }
                }
                numArray2 = numArray;
            }
            finally
            {
                buffer.FreeBuffer();
            }
            return numArray2;
        }

        public object ExecuteProc(string procName)
        {
            return ExecuteProc(_transaction, procName, null, null, null);
        }

        public object ExecuteProc(DbTransaction transaction, string procName)
        {
            return ExecuteProc(transaction, procName, null, null, null);
        }

        public object ExecuteProc(string procName, DbParameter[] parameters)
        {
            return ExecuteProc(_transaction, procName, parameters, null);
        }

        public object ExecuteProc(string procName, string[] outParameters)
        {
            return ExecuteProc(_transaction, procName, null, null, outParameters);
        }

        public object ExecuteProc(DbTransaction transaction, string procName, string[] outParameters)
        {
            return ExecuteProc(transaction, procName, null, null, outParameters);
        }

        public object ExecuteProc(string procName, DbParameter[] parameters, string[] outParameters)
        {
            return ExecuteProc(_transaction, procName, parameters, outParameters);
        }

        public object ExecuteProc(string procName, string[] parametersName, object[] parameters)
        {
            return ExecuteProc(_transaction, procName, parametersName, parameters, null);
        }

        public object ExecuteProc(DbTransaction transaction, string procName, DbParameter[] parameters,
            string[] outParameters)
        {
            object obj3;
            bool flag = false;
            DbCommand command = getCommand();
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    flag = true;
                }
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                if (parameters != null)
                {
                    foreach (DbParameter parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.CommandText = procName;
                int num = command.ExecuteNonQuery();
                object result = command.Parameters.Contains("ReturnValue")
                    ? command.Parameters["ReturnValue"].Value
                    : num;
                if ((outParameters != null) && (outParameters.Length > 0))
                {
                    var objArray = new object[outParameters.Length + 1];
                    objArray[0] = result;
                    for (int i = 0; i < outParameters.Length; i++)
                    {
                        if ((outParameters[i] != null) && (outParameters[i] != ""))
                        {
                            DbParameter parameter2 = command.Parameters[outParameters[i]];
                            if (parameter2 != null)
                            {
                                objArray[i + 1] = parameter2.Value;
                            }
                        }
                    }
                    result = objArray;
                }
                obj3 = result;
            }
            catch (Exception exception)
            {
                handleException(exception, procName);
                obj3 = null;
            }
            finally
            {
                if (flag)
                {
                    command.Connection.Close();
                }
                command.Transaction = null;
            }
            return obj3;
        }

        public object ExecuteProc(string procName, string[] parametersName, object[] parameters, string[] outParameters)
        {
            return ExecuteProc(_transaction, procName, parametersName, parameters, outParameters);
        }

        public object ExecuteProc(DbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, string[] outParameters)
        {
            object obj3;
            if ((parametersName != null) && (parametersName.Length > 0))
            {
                if (parameters == null)
                {
                    return null;
                }
                if (parameters.Length != parametersName.Length)
                {
                    return null;
                }
            }
            bool flag = false;
            DbCommand cmd = getCommand();
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                    flag = true;
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procName;
                cmd.Parameters.Clear();
                if (!DBBuilder.DeriveParameters(_factory, cmd))
                {
                    return null;
                }
                if ((parametersName != null) && (parametersName.Length > 0))
                {
                    for (int i = 0; i < parametersName.Length; i++)
                    {
                        DbParameter parameter = cmd.Parameters[parametersName[i]];
                        if (parameter != null)
                        {
                            if ((parameters[i] == null) || ((parameters[i] as string) == ""))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            else
                            {
                                parameter.Value = parameters[i];
                            }
                        }
                    }
                }
                int num2 = cmd.ExecuteNonQuery();
                object result = cmd.Parameters.Contains("ReturnValue")
                    ? cmd.Parameters["ReturnValue"].Value
                    : num2;

                if ((outParameters != null) && (outParameters.Length > 0))
                {
                    var objArray = new object[outParameters.Length + 1];
                    objArray[0] = result;
                    for (int j = 0; j < outParameters.Length; j++)
                    {
                        if ((outParameters[j] != null) && (outParameters[j] != ""))
                        {
                            DbParameter parameter2 = cmd.Parameters[outParameters[j]];
                            if (parameter2 != null)
                            {
                                objArray[j + 1] = (parameter2.Value == DBNull.Value) ? null : parameter2.Value;
                            }
                        }
                    }
                    result = objArray;
                }
                obj3 = result;
            }
            catch (Exception exception)
            {
                handleException(exception, procName);
                obj3 = null;
            }
            finally
            {
                if (flag)
                {
                    cmd.Connection.Close();
                }
                cmd.Transaction = null;
            }
            return obj3;
        }

        public static object ExecuteProcOnce(string procName)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(procName);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(procName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(procName, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }


        public static object ExecuteProcOnce(string procName, DbParameter[] parameters, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(procName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }


        public static object ExecuteProcOnce(DbTransaction transaction, string procName, DbParameter[] parameters,
            string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName, string[] parametersName,
            object[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }


        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters,
            string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }


        public static object ExecuteProcOnce(DbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }


        public IDataReader ExecuteReader(string strSql)
        {
            return ExecuteReader(strSql, CommandBehavior.Default);
        }

        public IDataReader ExecuteReader(string strSql, CommandBehavior behavior)
        {
            IDataReader reader2;
            bool flag = false;
            DbCommand command = getCommand();
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    flag = true;
                }
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                //strSql = GetReplaceSql(strSql);
                command.CommandText = strSql;
                IDataReader reader = command.ExecuteReader(behavior);

                reader2 = reader;
            }
            catch (Exception exception)
            {
                handleException(exception, strSql);
                reader2 = null;
            }
            finally
            {
                if (flag)
                {
                    command.Connection.Close();
                }
                command.Transaction = null;
            }
            return reader2;
        }

        public object ExecuteScalar(string strSql)
        {
            return ExecuteScalar(_transaction, strSql);
        }

        public object ExecuteScalar(string strSql, DbParameter[] parameters)
        {
            return ExecuteScalar(_transaction, strSql, parameters);
        }

        public object ExecuteScalar(DbTransaction transaction, string strSql)
        {
            return ExecuteScalar(transaction, strSql, null);
        }

        public object ExecuteScalar(DbTransaction transaction, string strSql, DbParameter[] parameters)
        {
            object obj3;
            bool flag = false;
            DbCommand command = getCommand();
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                    flag = true;
                }
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                //strSql = GetReplaceSql(strSql);
                command.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (DbParameter parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }

                object result = command.ExecuteScalar();

                obj3 = result;
            }
            catch (Exception exception)
            {
                handleException(exception, strSql);
                obj3 = null;
            }
            finally
            {
                if (flag)
                {
                    command.Connection.Close();
                }
                command.Transaction = null;
            }
            return obj3;
        }

        public static object ExecuteScalarOnce(string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteScalar(strSql);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteScalarOnce(string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteScalar(strSql, parameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteScalarOnce(DbTransaction transaction, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteScalar(transaction, strSql);
            buffer.FreeBuffer();
            return obj2;
        }


        public DataSet Fill(string strSql)
        {
            var dataSet = new DataSet();
            if (Fill(dataSet, strSql) < 0)
            {
                return null;
            }
            return dataSet;
        }

        public int Fill(DataSet dataSet, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(dataSet, strSql);
            }
            return Fill(dataSet.Tables[0], strSql);
        }

        public int Fill(DataSet dataSet, string strSql, DbParameter[] parameters)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(dataSet, strSql, parameters);
            }
            return Fill(dataSet.Tables[0], strSql, parameters);
        }

        public int Fill(DataTable dataTable, string strSql)
        {
            return Fill(_transaction, dataTable, strSql);
        }

        public int Fill(DataTable dataTable, string strSql, DbParameter[] parameters)
        {
            return Fill(_transaction, dataTable, strSql, parameters);
        }

        public DataSet Fill(DbTransaction transaction, string strSql)
        {
            var dataSet = new DataSet();
            if (Fill(transaction, dataSet, strSql) < 0)
            {
                return null;
            }
            return dataSet;
        }

        public DataSet Fill(string strSql, string tableName)
        {
            DataTable table;
            DataSet dataSetByName = DataSetUtility.GetDataSetByName(tableName);
            if (dataSetByName != null)
            {
                table = dataSetByName.Tables[tableName];
            }
            else
            {
                dataSetByName = new DataSet();
                table = dataSetByName.Tables.Add(tableName);
            }
            if (Fill(table, strSql) < 0)
            {
                return null;
            }
            return dataSetByName;
        }

        public int Fill(DataSet dataSet, int tableIndex, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(dataSet, strSql);
            }
            return Fill(dataSet.Tables[tableIndex], strSql);
        }

        public int Fill(DataSet dataSet, string tableName, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(dataSet, tableName, strSql);
            }
            DataTable dataTable = dataSet.Tables[tableName] ?? dataSet.Tables.Add(tableName);
            return Fill(dataTable, strSql);
        }

        public int Fill(DbTransaction transaction, DataSet dataSet, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataSet, strSql);
            }
            return Fill(transaction, dataSet.Tables[0], strSql);
        }

        public int Fill(DbTransaction transaction, DataTable dataTable, string strSql)
        {
            if (dataTable.DataSet != null && dataTable.DataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataTable, strSql);
            }
            return Fill(transaction, dataTable, strSql, null);
        }

        public int Fill(DbTransaction transaction, DataTable dataTable, string strSql, DbParameter[] parameters)
        {
            int num2;
            if (dataTable == null)
            {
                return -1;
            }
            if ((dataTable.DataSet == null) || (dataTable.DataSet.GetType() == _dataSetType))
            {
                return FillNoName(transaction, dataTable, strSql);
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, dataTable.TableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                //strSql = GetReplaceSql(strSql);
                dataAdapter.SelectCommand.Parameters.Clear();
                dataAdapter.SelectCommand.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        dataAdapter.SelectCommand.Parameters.Add(parameter);
                    }
                }
                var result = dataAdapter.Fill(dataTable);
                num2 = result;
            }
            catch (Exception exception)
            {
                dataTable.Clear();

                handleException(exception, strSql);
                num2 = -1;
            }
            finally
            {
                freeAdapter(dataAdapter);
            }
            return num2;
        }

        public DataSet Fill(DbTransaction transaction, string strSql, string tableName)
        {
            DataTable table;
            DataSet dataSetByName = DataSetUtility.GetDataSetByName(tableName);
            if (dataSetByName != null)
            {
                table = dataSetByName.Tables[tableName];
            }
            else
            {
                dataSetByName = new DataSet();
                table = dataSetByName.Tables.Add(tableName);
            }
            if (Fill(transaction, table, strSql) < 0)
            {
                return null;
            }
            return dataSetByName;
        }

        public DataSet Fill(string strSql, string tableName, string strNamespace)
        {
            DataTable table;
            DataSet dataSetByName = DataSetUtility.GetDataSetByName(strNamespace, tableName);
            if (dataSetByName != null)
            {
                table = dataSetByName.Tables[tableName];
            }
            else
            {
                dataSetByName = new DataSet();
                table = dataSetByName.Tables.Add(tableName);
            }
            if (Fill(table, strSql) < 0)
            {
                return null;
            }
            return dataSetByName;
        }

        public int Fill(DbTransaction transaction, DataSet dataSet, int tableIndex, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataSet, strSql);
            }
            return Fill(transaction, dataSet.Tables[tableIndex], strSql);
        }

        public int Fill(DbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataSet, tableName, strSql);
            }
            DataTable dataTable = dataSet.Tables[tableName] ?? dataSet.Tables.Add(tableName);
            return Fill(transaction, dataTable, strSql);
        }

        public DataSet Fill(DbTransaction transaction, string strSql, string tableName, string strNamespace)
        {
            DataTable table;
            DataSet dataSetByName = DataSetUtility.GetDataSetByName(strNamespace, tableName);
            if (dataSetByName != null)
            {
                table = dataSetByName.Tables[tableName];
            }
            else
            {
                dataSetByName = new DataSet();
                table = dataSetByName.Tables.Add(tableName);
            }
            if (Fill(transaction, table, strSql) < 0)
            {
                return null;
            }
            return dataSetByName;
        }

        public bool FillDataSetSchema(DataSet ds, string[] tableNames)
        {
            try
            {
                foreach (string text in tableNames)
                {
                    DbDataAdapter dataAdapter = GetDataAdapter(text);
                    try
                    {
                        if (dataAdapter == null)
                        {
                            return false;
                        }
                        DataTable[] tableArray = dataAdapter.FillSchema(ds, SchemaType.Source);
                        if ((tableArray == null) || (tableArray.Length < 1))
                        {
                            return false;
                        }
                        tableArray[0].TableName = text;
                    }
                    finally
                    {
                        freeAdapter(dataAdapter);
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                handleException(exception);
                return false;
            }
        }

        public static bool FillDataSetSchemaOnce(DataSet ds, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            bool flag = buffer.FillDataSetSchema(ds, new[] {tableName});
            buffer.FreeBuffer();
            return flag;
        }

        public static bool FillDataSetSchemaOnce(DataSet ds, string[] tableNames)
        {
            DBHandlerEx buffer = GetBuffer();
            bool flag = buffer.FillDataSetSchema(ds, tableNames);
            buffer.FreeBuffer();
            return flag;
        }

        public int FillNoName(DataSet dataSet, string strSql)
        {
            return FillNoName(_transaction, dataSet, null, strSql);
        }

        public int FillNoName(DataSet dataSet, string strSql, DbParameter[] parameters)
        {
            return FillNoName(_transaction, dataSet, strSql, parameters);
        }

        public int FillNoName(DataTable dataTable, string strSql)
        {
            return FillNoName(_transaction, dataTable, strSql);
        }

        public int FillNoName(DataTable dataTable, string strSql, DbParameter[] parameters)
        {
            return FillNoName(_transaction, dataTable, strSql, parameters);
        }

        public int FillNoName(DataSet dataSet, string tableName, string strSql)
        {
            return FillNoName(_transaction, dataSet, tableName, strSql);
        }

        public int FillNoName(DbTransaction transaction, DataSet dataSet, string strSql)
        {
            return FillNoName(transaction, dataSet, strSql, new DbParameter[] {});
        }

        public int FillNoName(DbTransaction transaction, DataSet dataSet, string strSql, DbParameter[] parameters)
        {
            int num2;

            if (dataSet == null)
            {
                return -1;
            }
            DbDataAdapter adapter = null;
            try
            {
                 adapter= _factory.CreateDataAdapter();
                adapter.SelectCommand.Connection = _factory.CreateConnection();
                installAdapter(transaction, adapter);
                //strSql = GetReplaceSql(strSql);
                adapter.SelectCommand.Parameters.Clear();
                adapter.SelectCommand.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (DbParameter parameter in parameters)
                    {
                        adapter.SelectCommand.Parameters.Add(parameter);
                    }
                }
                int result = adapter.Fill(dataSet);
                num2 = result;
            }
            catch (Exception exception)
            {
                dataSet.Clear();
                handleException(exception, strSql);
                num2 = -1;
            }
            finally
            {
                freeAdapter(adapter);
            }
            return num2;
        }


        public int FillNoName(DbTransaction transaction, DataTable dataTable, string strSql,
            DbParameter[] parameters)
        {
            int num2;
            if (dataTable == null)
            {
                return -1;
            }
            DbDataAdapter adapter=null;
            try
            {
                 adapter= GetDataAdapter(transaction, dataTable.TableName);
                installAdapter(transaction, adapter);
                //strSql = GetReplaceSql(strSql);
                adapter.SelectCommand.Parameters.Clear();
                adapter.SelectCommand.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (DbParameter parameter in parameters)
                    {
                        adapter.SelectCommand.Parameters.Add(parameter);
                    }
                }

                int result = adapter.Fill(dataTable);
                num2 = result;
            }
            catch (Exception exception)
            {
                dataTable.Clear();
                handleException(exception, strSql);
                num2 = -1;
            }
            finally
            {
                freeAdapter(adapter);
            }
            return num2;
        }

        public int FillNoName(DbTransaction transaction, DataTable dataTable, string strSql)
        {
            return FillNoName(transaction, dataTable, strSql, null);
        }

        public int FillNoName(DbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            int num2;
            if (dataSet == null)
            {
                return -1;
            }
            if (tableName == null)
            {
                return FillNoName(transaction, dataSet, strSql);
            }
            DataTable dataTable = null;
            DbDataAdapter adapter = null;
            try
            {
                adapter = GetDataAdapter(transaction, tableName);
                installAdapter(transaction, adapter);
                dataTable = dataSet.Tables[tableName] ?? dataSet.Tables.Add(tableName);
                //strSql = GetReplaceSql(strSql);
                adapter.SelectCommand.CommandText = strSql;
                int result = adapter.Fill(dataTable);
                num2 = result;
            }
            catch (Exception exception)
            {
                if (dataTable != null)
                {
                    dataTable.Clear();
                }
                handleException(exception, "表名：" + tableName + "\r\n" + strSql);
                num2 = -1;
            }
            finally
            {
                freeAdapter(adapter);
            }
            return num2;
        }

        public static int FillNoNameOnce(DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.FillNoName(dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }


        public static int FillNoNameOnce(DbTransaction transaction, DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.FillNoName(transaction, dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(strSql);
            buffer.FreeBuffer();
            return set;
        }

        public static int FillOnce(DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataSet dataSet, string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(dataSet, strSql, parameters);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataTable dataTable, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(dataTable, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataTable dataTable, string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(dataTable, strSql, parameters);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(DbTransaction transaction, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(transaction, strSql);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(string strSql, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(strSql, tableName);
            buffer.FreeBuffer();
            return set;
        }

        public static int FillOnce(DataSet dataSet, int tableIndex, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(dataSet, tableIndex, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataSet dataSet, string tableName, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(dataSet, tableName, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DbTransaction transaction, DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DbTransaction transaction, DataTable dataTable, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataTable, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(DbTransaction transaction, string strSql, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(transaction, strSql, tableName);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(string strSql, string tableName, string strNamespace)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(strSql, tableName, strNamespace);
            buffer.FreeBuffer();
            return set;
        }


        public static int FillOnce(DbTransaction transaction, DataSet dataSet, int tableIndex, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataSet, tableIndex, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataSet, tableName, strSql);
            buffer.FreeBuffer();
            return num;
        }


        public static DataSet FillOnce(DbTransaction transaction, string strSql, string tableName, string strNamespace)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(transaction, strSql, tableName, strNamespace);
            buffer.FreeBuffer();
            return set;
        }


        private void freeAdapter(DbDataAdapter adapter)
        {
            if (adapter.SelectCommand != null)
            {
                adapter.SelectCommand.Transaction = null;
                adapter.SelectCommand.Connection = _connection;
            }
            if (adapter.InsertCommand != null)
            {
                adapter.InsertCommand.Transaction = null;
                adapter.InsertCommand.Connection = _connection;
            }
            if (adapter.UpdateCommand != null)
            {
                adapter.UpdateCommand.Transaction = null;
                adapter.UpdateCommand.Connection = _connection;
            }
            if (adapter.DeleteCommand != null)
            {
                adapter.DeleteCommand.Transaction = null;
                adapter.DeleteCommand.Connection = _connection;
            }
        }

        public void FreeBuffer()
        {
            try
            {
                if (_transaction != null)
                {
                    EndTransaction(false);
                }
                if ((_connection != null) && (_connection.State == ConnectionState.Open))
                {
                    _connection.Close();
                }
            }
            catch
            {
            }
        }

        public static DBHandlerEx GetBuffer()
        {
            return new DBHandlerEx();
        }

        private DbCommand getCommand()
        {
            return DBBuilder.CreateCommand(_factory, _transaction);
        }

        public DbDataAdapter GetDataAdapter(string tableName)
        {
            return GetDataAdapter(_transaction, tableName);
        }

        public DbDataAdapter GetDataAdapter(DbTransaction transaction, string tableName)
        {
            return DBBuilder.CreateAdapter(_factory, tableName, transaction);
        }

        public DataSet GetDataSet(string tableName)
        {
            DataSet set3;
            DbDataAdapter dataAdapter = GetDataAdapter(tableName);
            if (dataAdapter == null)
            {
                return null;
            }
            try
            {
                var dataSet = new DataSet("DataSet_" + tableName.ToUpper());
                DataTable[] tableArray = dataAdapter.FillSchema(dataSet, SchemaType.Source);
                if ((tableArray == null) || (tableArray.Length < 1))
                {
                    return null;
                }
                tableArray[0].TableName = tableName;
                set3 = dataSet.Clone();
            }
            catch (Exception exception)
            {
                handleException(exception);
                set3 = null;
            }
            finally
            {
                freeAdapter(dataAdapter);
            }
            return set3;
        }

        public static DataSet GetDataSetOnce(string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet dataSet = buffer.GetDataSet(tableName);
            buffer.FreeBuffer();
            return dataSet;
        }


        public static string GetException()
        {
            return (Thread.GetData(_exceptionSlot) as string);
        }

        public Hashtable GetProcedureParameters(string procName, out DbParameter[] parameters)
        {
            return GetProcedureParameters(_factory, procName, out parameters);
        }

        public Hashtable GetProcedureParameters(IDatabaseProviderFactory factory, string procName,
            out DbParameter[] parameters)
        {
            string text = procName.ToUpper();
            var command = _procParaeters[text] as DbCommand;
            if (command == null)
            {
                command = DBBuilder.DeriveParameters(_factory, procName);
                if (command == null)
                {
                    parameters = null;
                    return null;
                }
                _procParaeters[text] = command;
            }
            parameters = DBBuilder.CreateParameter(factory, command.Parameters.Count);
            var hashtable = new Hashtable();
            for (int i = 0; i < parameters.Length; i++)
            {
                DbParameter parameter = command.Parameters[i];
                parameters[i].DbType = parameter.DbType;
                parameters[i].Direction = parameter.Direction;
                parameters[i].ParameterName = parameter.ParameterName;
                ((IDbDataParameter) parameters[i]).Precision = ((IDbDataParameter) parameter).Precision;
                ((IDbDataParameter) parameters[i]).Scale = ((IDbDataParameter) parameter).Scale;
                parameters[i].Size = parameter.Size;
                hashtable[parameters[i].ParameterName] = parameters[i];
            }
            return hashtable;
        }

        public static Hashtable GetProcedureParametersOnce(string procName, out DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            Hashtable procedureParameters = buffer.GetProcedureParameters(procName, out parameters);
            buffer.FreeBuffer();
            return procedureParameters;
        }


        public static DataSet GetRegisterDataSet(string tableName)
        {
            var type = _dataSetTypeTable[tableName.ToUpper()] as Type;
            if (type == null)
            {
                return null;
            }
            return (Activator.CreateInstance(type) as DataSet);
        }

        private static void handleException(Exception exp)
        {
            Thread.SetData(_exceptionSlot, exp.Message);
        }

        private static void handleException(Exception exp, string message)
        {
            Thread.SetData(_exceptionSlot, exp.Message + "\r\n" + message);
        }

        private void installAdapter(DbTransaction transaction, DbDataAdapter adapter)
        {
            if (adapter.SelectCommand != null)
            {
                adapter.SelectCommand.Transaction = transaction;
                if ((transaction == null) || (transaction == _transaction))
                {
                    adapter.SelectCommand.Connection = _connection;
                }
                else
                {
                    adapter.SelectCommand.Connection = transaction.Connection;
                }
            }
            if (adapter.InsertCommand != null)
            {
                adapter.InsertCommand.Transaction = transaction;
                if ((transaction == null) || (transaction == _transaction))
                {
                    adapter.InsertCommand.Connection = _connection;
                }
                else
                {
                    adapter.InsertCommand.Connection = transaction.Connection;
                }
            }
            if (adapter.UpdateCommand != null)
            {
                adapter.UpdateCommand.Transaction = transaction;
                if ((transaction == null) || (transaction == _transaction))
                {
                    adapter.UpdateCommand.Connection = _connection;
                }
                else
                {
                    adapter.UpdateCommand.Connection = transaction.Connection;
                }
            }
            if (adapter.DeleteCommand != null)
            {
                adapter.DeleteCommand.Transaction = transaction;
                if ((transaction == null) || (transaction == _transaction))
                {
                    adapter.DeleteCommand.Connection = _connection;
                }
                else
                {
                    adapter.DeleteCommand.Connection = transaction.Connection;
                }
            }
        }

        public bool OpenConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                return true;
            }
            try
            {
                _connection.Open();
                return true;
            }
            catch (Exception exception)
            {
                handleException(exception);
                return false;
            }
        }

        public static bool RegisterAssemblyDataSets(Assembly asm)
        {
            if (asm == null)
            {
                return false;
            }
            try
            {
                foreach (Type type in asm.GetTypes())
                {
                    RegisterDataSet(type);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool RegisterAssemblyDataSets(Assembly asm, string nameSpace)
        {
            if (asm == null)
            {
                return false;
            }
            try
            {
                foreach (Type type in asm.GetTypes())
                {
                    if (type.IsSubclassOf(_dataSetType) && (type.Namespace == nameSpace))
                    {
                        RegisterDataSet(type);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void RegisterDataSet(Type type)
        {
            if (type.IsSubclassOf(_dataSetType))
            {
                foreach (
                    PropertyInfo info in
                        type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    if (info.PropertyType.IsSubclassOf(_dataTableType))
                    {
                        _dataSetTypeTable[info.Name.ToUpper()] = type;
                    }
                }
            }
        }

        public static void RegisterDBDefaultType(ConnectionStringSettings connectionString)
        {
            _factory = new DatabaseFactory(connectionString);
        }

        public static bool RegisterDBDefaultType(string providerName, string connectionString)
        {
            try
            {
                _factory = new DatabaseFactory(providerName, connectionString);
                return true;
            }
            catch(Exception e)
            {
                string estr = e.ToString();
                Console.WriteLine(estr);
                _factory = null;
                return false;
            }
        }

        public int Update(DataRow dataRow)
        {
            return Update(_transaction, new[] {dataRow});
        }

        public int Update(DataSet dataSet)
        {
            if (dataSet.Tables.Count < 1)
            {
                return -2;
            }
            return Update(dataSet.Tables[0]);
        }

        public int Update(DataTable dataTable)
        {
            return Update(_transaction, dataTable);
        }

        public int Update(DataRow[] dataRows)
        {
            return Update(_transaction, dataRows);
        }

        public int Update(DataSet dataSet, int tableIndex)
        {
            if ((dataSet.Tables.Count > tableIndex) && (tableIndex >= 0))
            {
                return Update(dataSet.Tables[tableIndex]);
            }
            return -1;
        }

        public int Update(DataSet dataSet, string tableName)
        {
            if (!dataSet.Tables.Contains(tableName))
            {
                return -2;
            }
            return Update(dataSet.Tables[tableName]);
        }

        public int Update(DbTransaction transaction, DataRow dataRow)
        {
            return Update(transaction, new[] {dataRow});
        }

        public int Update(DbTransaction transaction, DataRow[] dataRows)
        {
            int num2;
            if (dataRows == null)
            {
                return -3;
            }
            if (dataRows.Length < 1)
            {
                return 0;
            }
            if ((dataRows[0].Table == null) || (dataRows[0].Table.DataSet == null))
            {
                return -2;
            }
            string tableName = dataRows[0].Table.TableName;
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = dataAdapter.Update(dataRows);
                num2 = result;
            }
            catch (Exception exception)
            {
                handleException(exception);
                num2 = -1;
            }
            finally
            {
                freeAdapter(dataAdapter);
            }
            return num2;
        }

        public int Update(DbTransaction transaction, DataSet dataSet)
        {
            if (dataSet.Tables.Count < 1)
            {
                return -2;
            }
            return Update(transaction, dataSet.Tables[0]);
        }

        public int Update(DbTransaction transaction, DataTable dataTable)
        {
            int num2;
            //TODO: DataSet为啥不能为空
            if ((dataTable == null)) // || (dataTable.DataSet == null))
            {
                return -2;
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, dataTable.TableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = dataAdapter.Update(dataTable);
                num2 = result;
            }
            catch (Exception exception)
            {
                handleException(exception);
                num2 = -1;
            }
            finally
            {
                freeAdapter(dataAdapter);
            }
            return num2;
        }

        public int Update(DbTransaction transaction, DataSet dataSet, int tableIndex)
        {
            if ((dataSet.Tables.Count > tableIndex) && (tableIndex >= 0))
            {
                return Update(transaction, dataSet.Tables[tableIndex]);
            }
            return -1;
        }

        public int Update(DbTransaction transaction, DataSet dataSet, string tableName)
        {
            if (!dataSet.Tables.Contains(tableName))
            {
                return -2;
            }
            return Update(transaction, dataSet.Tables[tableName]);
        }

        public static int UpdateOnce(DataRow dataRow)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(dataRow);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataSet dataSet)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(dataSet, 0);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataTable dataTable)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(dataTable);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataRow[] dataRows)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(dataRows);
            buffer.FreeBuffer();
            return num;
        }


        public static int UpdateOnce(DataSet dataSet, int tableIndex)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(dataSet, tableIndex);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }


        public static int UpdateOnce(DbTransaction transaction, DataRow dataRow)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataRow);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DbTransaction transaction, DataSet dataSet)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataSet, 0);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DbTransaction transaction, DataRow[] dataRows)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataRows);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DbTransaction transaction, DataTable dataTable)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataTable);
            buffer.FreeBuffer();
            return num;
        }


        public static int UpdateOnce(DbTransaction transaction, DataSet dataSet, int tableIndex)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataSet, tableIndex);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DbTransaction transaction, DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }


        public int UpdateToTable(DataRow dataRow, string tableName)
        {
            return UpdateToTable(_transaction, new[] {dataRow}, tableName);
        }

        public int UpdateToTable(DataSet dataSet, string tableName)
        {
            return UpdateToTable(_transaction, dataSet, 0, tableName);
        }

        public int UpdateToTable(DataRow[] dataRows, string tableName)
        {
            return UpdateToTable(_transaction, dataRows, tableName);
        }

        public int UpdateToTable(DataTable dataTable, string tableName)
        {
            return UpdateToTable(_transaction, dataTable, tableName);
        }

        public int UpdateToTable(DataSet dataSet, int tableIndex, string tableName)
        {
            if ((dataSet.Tables.Count > tableIndex) && (tableIndex >= 0))
            {
                return UpdateToTable(_transaction, dataSet.Tables[tableIndex], tableName);
            }
            return -1;
        }

        public int UpdateToTable(DataSet dataSet, string orgTableName, string tableName)
        {
            int index = dataSet.Tables.IndexOf(orgTableName);
            if (index < 0)
            {
                return -1;
            }
            return UpdateToTable(_transaction, dataSet, index, tableName);
        }

        public int UpdateToTable(DbTransaction transaction, DataRow dataRow, string tableName)
        {
            return UpdateToTable(transaction, new[] {dataRow}, tableName);
        }

        public int UpdateToTable(DbTransaction transaction, DataRow[] dataRows, string tableName)
        {
            int num2;
            if (dataRows.Length < 1)
            {
                return 0;
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            if (dataAdapter == null)
            {
                return -1;
            }
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = dataAdapter.Update(dataRows);
                num2 = result;
            }
            catch (Exception exception)
            {
                handleException(exception);
                num2 = -1;
            }
            finally
            {
                freeAdapter(dataAdapter);
            }
            return num2;
        }

        public int UpdateToTable(DbTransaction transaction, DataSet dataSet, string tableName)
        {
            return UpdateToTable(transaction, dataSet, 0, tableName);
        }

        public int UpdateToTable(DbTransaction transaction, DataTable dataTable, string tableName)
        {
            int num2;
            if (dataTable == null)
            {
                return -1;
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = dataAdapter.Update(dataTable);
                num2 = result;
            }
            catch (Exception exception)
            {
                handleException(exception);
                num2 = -1;
            }
            finally
            {
                freeAdapter(dataAdapter);
            }
            return num2;
        }

        public int UpdateToTable(DbTransaction transaction, DataSet dataSet, int tableIndex, string tableName)
        {
            if ((dataSet.Tables.Count > tableIndex) && (tableIndex >= 0))
            {
                return UpdateToTable(transaction, dataSet.Tables[tableIndex], tableName);
            }
            return -1;
        }

        public int UpdateToTable(DbTransaction transaction, DataSet dataSet, string orgTableName, string tableName)
        {
            int index = dataSet.Tables.IndexOf(orgTableName);
            if (index < 0)
            {
                return -1;
            }
            return UpdateToTable(transaction, dataSet, index, tableName);
        }

        public static int UpdateToTableOnce(DataRow dataRow, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(dataRow, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(dataSet, 0, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataRow[] dataRows, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(dataRows, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataTable dataTable, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(dataTable, tableName);
            buffer.FreeBuffer();
            return num;
        }


        public static int UpdateToTableOnce(DataSet dataSet, int tableIndex, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(dataSet, tableIndex, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataSet dataSet, string orgTableName, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(dataSet, orgTableName, tableName);
            buffer.FreeBuffer();
            return num;
        }


        public static int UpdateToTableOnce(DbTransaction transaction, DataRow dataRow, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataRow, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DbTransaction transaction, DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataSet, 0, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DbTransaction transaction, DataRow[] dataRows, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataRows, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DbTransaction transaction, DataTable dataTable, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataTable, tableName);
            buffer.FreeBuffer();
            return num;
        }


        public static int UpdateToTableOnce(DbTransaction transaction, DataSet dataSet, int tableIndex,
            string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataSet, tableIndex, tableName);
            buffer.FreeBuffer();
            return num;
        }


        public static int UpdateToTableOnce(DbTransaction transaction, DataSet dataSet, string orgTableName,
            string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataSet, orgTableName, tableName);
            buffer.FreeBuffer();
            return num;
        }


        public static DbParameter BuilderDBParameter()
        {
            DbParameter parameter = _factory.CreateParameter();
            return parameter;
        }
    }
}