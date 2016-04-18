using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Threading;
using UC.Platform.Data.Utils;

namespace UC.Platform.Data
{
    public sealed class DBHandlerEx
    {
        private static IDatabaseProviderFactory _factory;

        private static readonly Type _dataSetType = typeof (DataSet);
        private static readonly Type _dataTableType = typeof (DataTable);

        private static readonly Hashtable _dataSetTypeTable = new Hashtable();
        private static readonly LocalDataStoreSlot _exceptionSlot = Thread.GetNamedDataSlot("PlatformDBHandlerException");

        private readonly DbConnection _connection;
        private readonly Hashtable _procParaeters = new Hashtable();
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
            DbCommand command = _factory.CreateCommand(transaction);
            command.CommandType = CommandType.Text;
            command.Parameters.Clear();

            //��ΰ2007-12-05ע
            command.CommandText = strSql;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            return command.ExecuteNonQuery();
        }


        public static int ExecuteNonQueryOnce(string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.ExecuteNonQuery(strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int ExecuteNonQueryOnce(string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                return buffer.ExecuteNonQuery(strSql, parameters);
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
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
            try
            {
                int num = buffer.ExecuteNonQuery(transaction, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int ExecuteNonQueryOnce(DbTransaction transaction, string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.ExecuteNonQuery(transaction, strSql, parameters);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
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
            DbCommand command = _factory.CreateCommand(transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            command.CommandText = procName;
            int num = command.ExecuteNonQuery();
            object result = command.Parameters.Contains("ReturnValue")
                ? command.Parameters["ReturnValue"].Value
                : num;
            if ((outParameters == null) || (outParameters.Length <= 0)) return result;
            var objArray = new object[outParameters.Length + 1];
            objArray[0] = result;
            for (int i = 0; i < outParameters.Length; i++)
            {
                if ((outParameters[i] == null) || (outParameters[i] == "")) continue;
                DbParameter parameter2 = command.Parameters[outParameters[i]];
                if (parameter2 != null)
                {
                    objArray[i + 1] = parameter2.Value;
                }
            }
            result = objArray;
            return result;
        }

        public object ExecuteProc(string procName, string[] parametersName, object[] parameters, string[] outParameters)
        {
            return ExecuteProc(_transaction, procName, parametersName, parameters, outParameters);
        }

        public object ExecuteProc(DbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, string[] outParameters)
        {
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
            DbCommand cmd = _factory.CreateCommand(transaction);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.Clear();
            if (!_factory.DeriveParameters(cmd))
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
            return result;
        }

        public static object ExecuteProcOnce(string procName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(procName);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(transaction, procName);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(string procName, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(procName, parameters, null);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(string procName, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(procName, outParameters);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(transaction, procName, parameters, null);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(transaction, procName, outParameters);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static object ExecuteProcOnce(string procName, DbParameter[] parameters, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(procName, parameters, outParameters);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, null);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static object ExecuteProcOnce(DbTransaction transaction, string procName, DbParameter[] parameters,
            string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(transaction, procName, parameters, outParameters);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(DbTransaction transaction, string procName, string[] parametersName,
            object[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, null);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters,
            string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, outParameters);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static object ExecuteProcOnce(DbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, outParameters);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public DbDataReader ExecuteReader(string strSql)
        {
            return ExecuteReader(strSql, CommandBehavior.Default);
        }

        public DbDataReader ExecuteReader(string strSql, CommandBehavior behavior)
        {
            DbCommand command = _factory.CreateCommand((DbConnection) null);
            command.CommandType = CommandType.Text;
            command.Parameters.Clear();
            command.CommandText = strSql;
            return command.ExecuteReader(behavior);
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
            DbCommand command = _factory.CreateCommand(transaction);
            command.CommandType = CommandType.Text;
            command.Parameters.Clear();
            command.CommandText = strSql;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            return command.ExecuteScalar();
        }

        public static object ExecuteScalarOnce(string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteScalar(strSql);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteScalarOnce(string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteScalar(strSql, parameters);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static object ExecuteScalarOnce(DbTransaction transaction, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                object obj2 = buffer.ExecuteScalar(transaction, strSql);
                return obj2;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
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
            if (dataTable == null)
            {
                return -1;
            }
            if ((dataTable.DataSet == null) || (dataTable.DataSet.GetType() == _dataSetType))
            {
                return FillNoName(transaction, dataTable, strSql);
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, dataTable.TableName);
            installAdapter(transaction, dataAdapter);
            //strSql = GetReplaceSql(strSql);
            dataAdapter.SelectCommand.Parameters.Clear();
            dataAdapter.SelectCommand.CommandText = strSql;
            if (parameters != null)
            {
                foreach (DbParameter parameter in parameters)
                {
                    dataAdapter.SelectCommand.Parameters.Add(parameter);
                }
            }
            int result = dataAdapter.Fill(dataTable);
            freeAdapter(dataAdapter);
            return result;
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
            foreach (string text in tableNames)
            {
                DbDataAdapter dataAdapter = GetDataAdapter(text);
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
                freeAdapter(dataAdapter);
            }
            return true;
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
            if (dataSet == null)
            {
                return -1;
            }
            DbDataAdapter adapter = _factory.CreateDataAdapter();
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
            freeAdapter(adapter);
            return result;
        }


        public int FillNoName(DbTransaction transaction, DataTable dataTable, string strSql, DbParameter[] parameters)
        {
            if (dataTable == null)
            {
                return -1;
            }
            DbDataAdapter adapter = _factory.CreateDataAdapter();
            adapter.SelectCommand.CommandText = strSql;
            adapter.SelectCommand.CommandType = CommandType.Text;

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
            freeAdapter(adapter);
            return result;
        }

        public int FillNoName(DbTransaction transaction, DataTable dataTable, string strSql)
        {
            return FillNoName(transaction, dataTable, strSql, null);
        }

        public int FillNoName(DbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            if (dataSet == null)
            {
                return -1;
            }
            if (tableName == null)
            {
                return FillNoName(transaction, dataSet, strSql);
            }
            DbDataAdapter adapter = GetDataAdapter(transaction, tableName);
            installAdapter(transaction, adapter);
            DataTable dataTable = dataSet.Tables[tableName] ?? dataSet.Tables.Add(tableName);
            //strSql = GetReplaceSql(strSql);
            adapter.SelectCommand.CommandText = strSql;
            int result = adapter.Fill(dataTable);
            freeAdapter(adapter);
            return result;
        }

        public static int FillNoNameOnce(DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.FillNoName(dataSet, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int FillNoNameOnce(DbTransaction transaction, DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.FillNoName(transaction, dataSet, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static DataSet FillOnce(string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                DataSet set = buffer.Fill(strSql);
                return set;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(dataSet, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DataSet dataSet, string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(dataSet, strSql, parameters);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DataTable dataTable, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(dataTable, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DataTable dataTable, string strSql, DbParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(dataTable, strSql, parameters);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static DataSet FillOnce(DbTransaction transaction, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                DataSet set = buffer.Fill(transaction, strSql);
                return set;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static DataSet FillOnce(string strSql, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                DataSet set = buffer.Fill(strSql, tableName);
                return set;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DataSet dataSet, int tableIndex, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(dataSet, tableIndex, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DataSet dataSet, string tableName, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(dataSet, tableName, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DbTransaction transaction, DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(transaction, dataSet, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally 
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DbTransaction transaction, DataTable dataTable, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(transaction, dataTable, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static DataSet FillOnce(DbTransaction transaction, string strSql, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                DataSet set = buffer.Fill(transaction, strSql, tableName);
                return set;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static DataSet FillOnce(string strSql, string tableName, string strNamespace)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                DataSet set = buffer.Fill(strSql, tableName, strNamespace);
                return set;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int FillOnce(DbTransaction transaction, DataSet dataSet, int tableIndex, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(transaction, dataSet, tableIndex, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int FillOnce(DbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Fill(transaction, dataSet, tableName, strSql);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static DataSet FillOnce(DbTransaction transaction, string strSql, string tableName, string strNamespace)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                DataSet set = buffer.Fill(transaction, strSql, tableName, strNamespace);
                return set;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
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

        public bool FreeBuffer()
        {
            return FreeBuffer(false);
        }

        public bool FreeBuffer(bool commit)
        {
            try
            {
                if (_transaction != null)
                {
                    EndTransaction(commit);
                }
                if (_connection != null && _connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DBHandlerEx GetBuffer()
        {
            return new DBHandlerEx();
        }

        public DbDataAdapter GetDataAdapter(string tableName)
        {
            return GetDataAdapter(_transaction, tableName);
        }

        public DbDataAdapter GetDataAdapter(DbTransaction transaction, string tableName)
        {
            return _factory.CreateDataAdapter(tableName, transaction);
        }

        public DataSet GetDataSet(string tableName)
        {
            DbDataAdapter dataAdapter = GetDataAdapter(tableName);
            if (dataAdapter == null)
            {
                return null;
            }
            var dataSet = new DataSet("DataSet_" + tableName.ToUpper());
            DataTable[] tableArray = dataAdapter.FillSchema(dataSet, SchemaType.Source);
            if ((tableArray == null) || (tableArray.Length < 1))
            {
                return null;
            }
            tableArray[0].TableName = tableName;
            DataSet set3 = dataSet.Clone();
            freeAdapter(dataAdapter);
            return set3;
        }

        public static DataSet GetDataSetOnce(string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                DataSet dataSet = buffer.GetDataSet(tableName);
                return dataSet;
            }
            catch
            {
                return null;
            }
            finally
            {
                buffer.FreeBuffer();
            }
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
                command = _factory.DeriveParameters(procName);
                if (command == null)
                {
                    parameters = null;
                    return null;
                }
                _procParaeters[text] = command;
            }
            parameters = _factory.CreateParameters(command.Parameters.Count);
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
            catch (Exception e)
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
            installAdapter(transaction, dataAdapter);
            int result = dataAdapter.Update(dataRows);
            freeAdapter(dataAdapter);
            return result;
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
            //TODO: DataSetΪɶ����Ϊ��
            if ((dataTable == null)) // || (dataTable.DataSet == null))
            {
                return -2;
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, dataTable.TableName);
            installAdapter(transaction, dataAdapter);
            int result = dataAdapter.Update(dataTable);
            freeAdapter(dataAdapter);
            return result;
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
            try
            {
                int num = buffer.Update(dataRow);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DataSet dataSet)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(dataSet, 0);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DataTable dataTable)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(dataTable);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DataRow[] dataRows)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(dataRows);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int UpdateOnce(DataSet dataSet, int tableIndex)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(dataSet, tableIndex);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(dataSet, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int UpdateOnce(DbTransaction transaction, DataRow dataRow)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(transaction, dataRow);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DbTransaction transaction, DataSet dataSet)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(transaction, dataSet, 0);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DbTransaction transaction, DataRow[] dataRows)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(transaction, dataRows);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DbTransaction transaction, DataTable dataTable)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(transaction, dataTable);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int UpdateOnce(DbTransaction transaction, DataSet dataSet, int tableIndex)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(transaction, dataSet, tableIndex);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateOnce(DbTransaction transaction, DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.Update(transaction, dataSet, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
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
            if (dataRows.Length < 1)
            {
                return 0;
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            if (dataAdapter == null)
            {
                return -1;
            }
            installAdapter(transaction, dataAdapter);
            int result = dataAdapter.Update(dataRows);
            freeAdapter(dataAdapter);
            return result;
        }

        public int UpdateToTable(DbTransaction transaction, DataSet dataSet, string tableName)
        {
            return UpdateToTable(transaction, dataSet, 0, tableName);
        }

        public int UpdateToTable(DbTransaction transaction, DataTable dataTable, string tableName)
        {
            if (dataTable == null)
            {
                return -1;
            }
            DbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            installAdapter(transaction, dataAdapter);
            int result = dataAdapter.Update(dataTable);
            freeAdapter(dataAdapter);
            return result;
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
            try
            {
                int num = buffer.UpdateToTable(dataRow, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateToTableOnce(DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(dataSet, 0, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateToTableOnce(DataRow[] dataRows, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(dataRows, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateToTableOnce(DataTable dataTable, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(dataTable, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int UpdateToTableOnce(DataSet dataSet, int tableIndex, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(dataSet, tableIndex, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateToTableOnce(DataSet dataSet, string orgTableName, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(dataSet, orgTableName, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int UpdateToTableOnce(DbTransaction transaction, DataRow dataRow, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(transaction, dataRow, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateToTableOnce(DbTransaction transaction, DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(transaction, dataSet, 0, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateToTableOnce(DbTransaction transaction, DataRow[] dataRows, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(transaction, dataRows, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }

        public static int UpdateToTableOnce(DbTransaction transaction, DataTable dataTable, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(transaction, dataTable, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int UpdateToTableOnce(DbTransaction transaction, DataSet dataSet, int tableIndex,
            string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(transaction, dataSet, tableIndex, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static int UpdateToTableOnce(DbTransaction transaction, DataSet dataSet, string orgTableName,
            string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int num = buffer.UpdateToTable(transaction, dataSet, orgTableName, tableName);
                return num;
            }
            catch
            {
                return -1;
            }
            finally
            {
                buffer.FreeBuffer();
            }
        }


        public static DbParameter BuilderDBParameter()
        {
            DbParameter parameter = _factory.CreateParameter();
            return parameter;
        }
    }
}