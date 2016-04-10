using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading;
using UC.Platform.Data.Utils;

namespace UC.Platform.Data.DBHelper
{
    public sealed class DBHandlerEx
    {
        private static readonly Type _dataSetType = typeof (DataSet);
        private static readonly Type _dataTableType = typeof (DataTable);

        private IDbDataAdapter _adapter;
        private readonly Hashtable _adapters = new Hashtable();
        private IDbCommand _command;
        private IDbConnection _connection;
        private Type _currentType;
        private static readonly Hashtable _dataSetTypeTable = new Hashtable();
        private static readonly Hashtable _dbHandlerTypeDataSets = new Hashtable();
        private static string _defaultConnectionString;
        private static Type _defaultType;


        private static readonly LocalDataStoreSlot _exceptionSlot = Thread.GetNamedDataSlot("PlatformDBHandlerException");
        private bool _isConnectionType;
        private object _object;
        private readonly Hashtable _procParaeters = new Hashtable();
        private IDbTransaction _transaction;
        private bool _transactionOpenConnection;

        private DBHandlerEx()
        {
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

        public IDbDataParameter CreateParameter()
        {
            return DBBuilder.CreateParameter(_connection);
        }

        public IDbDataParameter CreateParameter(string name)
        {
            IDbDataParameter parameter = DBBuilder.CreateParameter(_connection);
            parameter.ParameterName = name;
            return parameter;
        }

        public IDbDataParameter CreateParameter(string name, object value)
        {
            IDbDataParameter parameter = DBBuilder.CreateParameter(_connection);
            parameter.ParameterName = name;
            parameter.Value = value ?? DBNull.Value;
            return parameter;
        }

        public bool EndTransaction(bool commit)
        {
            bool flag;
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
                flag = true;
            }
            catch (Exception exception)
            {
                handleException(exception, commit ? "Commit" : "Rollback");
                flag = false;
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
            return flag;
        }

        public int ExecuteNonQuery(string strSql)
        {
            return ExecuteNonQuery(_transaction, strSql);
        }

        public int ExecuteNonQuery(string strSql, IDbDataParameter[] parameters)
        {
            return ExecuteNonQuery(_transaction, strSql, parameters);
        }

        public int ExecuteNonQuery(IDbTransaction transaction, string strSql)
        {
            return ExecuteNonQuery(transaction, strSql, null);
            //int num2;
            //bool flag = false;
            //DateTime now = DateTime.Now;
            //IDbCommand command = this.GetCommand(transaction);
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

        public int ExecuteNonQuery(IDbTransaction transaction, string strSql, IDbDataParameter[] parameters)
        {
            int num2;
            bool flag = false;
            IDbCommand command = getCommand(transaction);
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
                    foreach (IDbDataParameter parameter in parameters)
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

        public static int ExecuteNonQueryOnce(string strSql, IDbDataParameter[] parameters)
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
                int[] numArray = new int[strSql.Length];
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

        public static int ExecuteNonQueryOnce(IDbTransaction transaction, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.ExecuteNonQuery(transaction, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int ExecuteNonQueryOnce(IDbTransaction transaction, string strSql, IDbDataParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.ExecuteNonQuery(transaction, strSql, parameters);
            buffer.FreeBuffer();
            return num;
        }

        public static int[] ExecuteNonQueryOnce(IDbTransaction transaction, string[] strSql)
        {
            int[] numArray2;
            DBHandlerEx buffer = GetBuffer();
            try
            {
                int[] numArray = new int[strSql.Length];
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

        public static int ExecuteNonQueryOnce(string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.ExecuteNonQuery(strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int[] ExecuteNonQueryOnce(string[] strSql, Type type)
        {
            int[] numArray2;
            DBHandlerEx buffer = GetBuffer(type);
            try
            {
                if (!buffer.BeginTransaction())
                {
                    return null;
                }
                int[] numArray = new int[strSql.Length];
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

        public static int[] ExecuteNonQueryOnce(IDbTransaction transaction, string[] strSql, Type type)
        {
            int[] numArray2;
            DBHandlerEx buffer = GetBuffer(type);
            try
            {
                int[] numArray = new int[strSql.Length];
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

        public static int ExecuteNonQueryOnce(IDbTransaction transaction, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.ExecuteNonQuery(transaction, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int ExecuteNonQueryOnce(string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.ExecuteNonQuery(strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int[] ExecuteNonQueryOnce(string[] strSql, Type type, string connectionString)
        {
            int[] numArray2;
            DBHandlerEx buffer = GetBuffer(type);
            try
            {
                if (!buffer.BeginTransaction())
                {
                    return null;
                }
                int[] numArray = new int[strSql.Length];
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

        public static int[] ExecuteNonQueryOnce(IDbTransaction transaction, string[] strSql, Type type,
            string connectionString)
        {
            int[] numArray2;
            DBHandlerEx buffer = GetBuffer(type);
            try
            {
                int[] numArray = new int[strSql.Length];
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

        public static int ExecuteNonQueryOnce(IDbTransaction transaction, string strSql, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.ExecuteNonQuery(transaction, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public object ExecuteProc(string procName)
        {
            return ExecuteProc(_transaction, procName, null, null, null);
        }

        public object ExecuteProc(IDbTransaction transaction, string procName)
        {
            return ExecuteProc(transaction, procName, null, null, null);
        }

        public object ExecuteProc(string procName, IDbDataParameter[] parameters)
        {
            return ExecuteProc(_transaction, procName, parameters, null);
        }

        public object ExecuteProc(string procName, string[] outParameters)
        {
            return ExecuteProc(_transaction, procName, null, null, outParameters);
        }

        public object ExecuteProc(IDbTransaction transaction, string procName, string[] outParameters)
        {
            return ExecuteProc(transaction, procName, null, null, outParameters);
        }

        public object ExecuteProc(string procName, IDbDataParameter[] parameters, string[] outParameters)
        {
            return ExecuteProc(_transaction, procName, parameters, outParameters);
        }

        public object ExecuteProc(string procName, string[] parametersName, object[] parameters)
        {
            return ExecuteProc(_transaction, procName, parametersName, parameters, null);
        }

        public object ExecuteProc(IDbTransaction transaction, string procName, IDbDataParameter[] parameters,
            string[] outParameters)
        {
            object obj3;
            bool flag = false;
            IDbCommand command = getCommand(transaction);
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
                    foreach (IDbDataParameter parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.CommandText = procName;
                int num = command.ExecuteNonQuery();
                object result = command.Parameters.Contains("ReturnValue")
                    ? ((IDbDataParameter) command.Parameters["ReturnValue"]).Value
                    : num;
                if ((outParameters != null) && (outParameters.Length > 0))
                {
                    object[] objArray = new object[outParameters.Length + 1];
                    objArray[0] = result;
                    for (int i = 0; i < outParameters.Length; i++)
                    {
                        if ((outParameters[i] != null) && (outParameters[i] != ""))
                        {
                            IDbDataParameter parameter2 = command.Parameters[outParameters[i]] as IDbDataParameter;
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

        public object ExecuteProc(IDbTransaction transaction, string procName, string[] parametersName,
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
            IDbCommand cmd = getCommand(transaction);
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
                if (!DBBuilder.DeriveParameters(cmd))
                {
                    return null;
                }
                if ((parametersName != null) && (parametersName.Length > 0))
                {
                    for (int i = 0; i < parametersName.Length; i++)
                    {
                        IDbDataParameter parameter = cmd.Parameters[parametersName[i]] as IDbDataParameter;
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
                    ? ((IDbDataParameter) cmd.Parameters["ReturnValue"]).Value
                    : num2;

                if ((outParameters != null) && (outParameters.Length > 0))
                {
                    object[] objArray = new object[outParameters.Length + 1];
                    objArray[0] = result;
                    for (int j = 0; j < outParameters.Length; j++)
                    {
                        if ((outParameters[j] != null) && (outParameters[j] != ""))
                        {
                            IDbDataParameter parameter2 = cmd.Parameters[outParameters[j]] as IDbDataParameter;
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

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, Type type)
        {
            return ExecuteProcOnce(procName, null, null, null, type);
        }

        public static object ExecuteProcOnce(string procName, IDbDataParameter[] parameters)
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

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, IDbDataParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, Type type)
        {
            return ExecuteProcOnce(transaction, procName, null, null, null, type);
        }

        public static object ExecuteProcOnce(string procName, IDbDataParameter[] parameters, string[] outParameters)
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

        public static object ExecuteProcOnce(string procName, Type type, string connectionString)
        {
            return ExecuteProcOnce(procName, null, null, null, type, connectionString);
        }

        public static object ExecuteProcOnce(string procName, IDbDataParameter[] parameters, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(procName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, string[] outParameters, Type type)
        {
            return ExecuteProcOnce(procName, null, null, outParameters, type);
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, IDbDataParameter[] parameters,
            Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, IDbDataParameter[] parameters,
            string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] parametersName,
            object[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, Type type,
            string connectionString)
        {
            return ExecuteProcOnce(transaction, procName, null, null, null, type, connectionString);
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] outParameters,
            Type type)
        {
            return ExecuteProcOnce(transaction, procName, null, null, outParameters, type);
        }

        public static object ExecuteProcOnce(string procName, IDbDataParameter[] parameters, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteProc(procName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, IDbDataParameter[] parameters, string[] outParameters,
            Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(procName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, string[] outParameters, Type type, string connectionString)
        {
            return ExecuteProcOnce(procName, null, null, outParameters, type, connectionString);
        }

        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, null);
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

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, IDbDataParameter[] parameters,
            string[] outParameters, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, IDbDataParameter[] parameters,
            Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, string[] outParameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] outParameters,
            Type type, string connectionString)
        {
            return ExecuteProcOnce(transaction, procName, null, null, outParameters, type, connectionString);
        }

        public static object ExecuteProcOnce(string procName, IDbDataParameter[] parameters, string[] outParameters,
            Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteProc(procName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters,
            string[] outParameters, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, IDbDataParameter[] parameters,
            string[] outParameters, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteProc(transaction, procName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, null);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, string[] outParameters, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteProc(transaction, procName, parametersName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(string procName, string[] parametersName, object[] parameters,
            string[] outParameters, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteProc(procName, parametersName, parameters, outParameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteProcOnce(IDbTransaction transaction, string procName, string[] parametersName,
            object[] parameters, string[] outParameters, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
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
            IDbCommand command = getCommand(_transaction);
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

        public object ExecuteScalar(string strSql, IDbDataParameter[] parameters)
        {
            return ExecuteScalar(_transaction, strSql, parameters);
        }

        public object ExecuteScalar(IDbTransaction transaction, string strSql)
        {
            return ExecuteScalar(transaction, strSql, null);
        }

        public object ExecuteScalar(IDbTransaction transaction, string strSql, IDbDataParameter[] parameters)
        {
            object obj3;
            bool flag = false;
            IDbCommand command = getCommand(transaction);
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
                    foreach (IDbDataParameter parameter in parameters)
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

        public static object ExecuteScalarOnce(string strSql, IDbDataParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteScalar(strSql, parameters);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteScalarOnce(IDbTransaction transaction, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            object obj2 = buffer.ExecuteScalar(transaction, strSql);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteScalarOnce(string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteScalar(strSql);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteScalarOnce(IDbTransaction transaction, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            object obj2 = buffer.ExecuteScalar(transaction, strSql);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteScalarOnce(string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteScalar(strSql);
            buffer.FreeBuffer();
            return obj2;
        }

        public static object ExecuteScalarOnce(IDbTransaction transaction, string strSql, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            object obj2 = buffer.ExecuteScalar(transaction, strSql);
            buffer.FreeBuffer();
            return obj2;
        }

        public DataSet Fill(string strSql)
        {
            DataSet dataSet = new DataSet();
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

        public int Fill(DataSet dataSet, string strSql, IDbDataParameter[] parameters)
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

        public int Fill(DataTable dataTable, string strSql, IDbDataParameter[] parameters)
        {
            return Fill(_transaction, dataTable, strSql, parameters);
        }

        public DataSet Fill(IDbTransaction transaction, string strSql)
        {
            DataSet dataSet = new DataSet();
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

        public int Fill(IDbTransaction transaction, DataSet dataSet, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataSet, strSql);
            }
            return Fill(transaction, dataSet.Tables[0], strSql);
        }

        public int Fill(IDbTransaction transaction, DataTable dataTable, string strSql)
        {
            if (dataTable.DataSet != null && dataTable.DataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataTable, strSql);
            }
            return Fill(transaction, dataTable, strSql, null);
        }

        public int Fill(IDbTransaction transaction, DataTable dataTable, string strSql, IDbDataParameter[] parameters)
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
            IDbDataAdapter dataAdapter = GetDataAdapter(transaction, dataTable.TableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                //strSql = GetReplaceSql(strSql);
                dataAdapter.SelectCommand.Parameters.Clear();
                dataAdapter.SelectCommand.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (IDbDataParameter parameter in parameters)
                    {
                        dataAdapter.SelectCommand.Parameters.Add(parameter);
                    }
                }
                int result = ((DbDataAdapter) dataAdapter).Fill(dataTable);

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

        public DataSet Fill(IDbTransaction transaction, string strSql, string tableName)
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

        public int Fill(IDbTransaction transaction, DataSet dataSet, int tableIndex, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataSet, strSql);
            }
            return Fill(transaction, dataSet.Tables[tableIndex], strSql);
        }

        public int Fill(IDbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            if (dataSet.GetType() == _dataSetType)
            {
                return FillNoName(transaction, dataSet, tableName, strSql);
            }
            DataTable dataTable = dataSet.Tables[tableName] ?? dataSet.Tables.Add(tableName);
            return Fill(transaction, dataTable, strSql);
        }

        public DataSet Fill(IDbTransaction transaction, string strSql, string tableName, string strNamespace)
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
                    IDbDataAdapter dataAdapter = GetDataAdapter(text);
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

        public static bool FillDataSetSchemaOnce(DataSet ds, string[] tableNames, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            bool flag = buffer.FillDataSetSchema(ds, tableNames);
            buffer.FreeBuffer();
            return flag;
        }

        public static bool FillDataSetSchemaOnce(DataSet ds, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            bool flag = buffer.FillDataSetSchema(ds, new[] {tableName});
            buffer.FreeBuffer();
            return flag;
        }

        public static bool FillDataSetSchemaOnce(DataSet ds, string[] tableNames, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            bool flag = buffer.FillDataSetSchema(ds, tableNames);
            buffer.FreeBuffer();
            return flag;
        }

        public static bool FillDataSetSchemaOnce(DataSet ds, string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            bool flag = buffer.FillDataSetSchema(ds, new[] {tableName});
            buffer.FreeBuffer();
            return flag;
        }

        public int FillNoName(DataSet dataSet, string strSql)
        {
            return FillNoName(_transaction, dataSet, null, strSql);
        }

        public int FillNoName(DataSet dataSet, string strSql, IDbDataParameter[] parameters)
        {
            return FillNoName(_transaction, dataSet, strSql, parameters);
        }

        public int FillNoName(DataTable dataTable, string strSql)
        {
            return FillNoName(_transaction, dataTable, strSql);
        }

        public int FillNoName(DataTable dataTable, string strSql, IDbDataParameter[] parameters)
        {
            return FillNoName(_transaction, dataTable, strSql, parameters);
        }

        public int FillNoName(DataSet dataSet, string tableName, string strSql)
        {
            return FillNoName(_transaction, dataSet, tableName, strSql);
        }

        public int FillNoName(IDbTransaction transaction, DataSet dataSet, string strSql)
        {
            return FillNoName(transaction, dataSet, strSql, new IDbDataParameter[] {});
        }

        public int FillNoName(IDbTransaction transaction, DataSet dataSet, string strSql, IDbDataParameter[] parameters)
        {
            int num2;
            if (_adapter == null)
            {
                return -1;
            }
            if (dataSet == null)
            {
                return -1;
            }
            try
            {
                installAdapter(transaction, _adapter);
                //strSql = GetReplaceSql(strSql);
                _adapter.SelectCommand.Parameters.Clear();
                _adapter.SelectCommand.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (IDbDataParameter parameter in parameters)
                    {
                        _adapter.SelectCommand.Parameters.Add(parameter);
                    }
                }
                int result = _adapter.Fill(dataSet);
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
                freeAdapter(_adapter);
            }
            return num2;
        }


        public int FillNoName(IDbTransaction transaction, DataTable dataTable, string strSql,
            IDbDataParameter[] parameters)
        {
            int num2;
            if (_adapter == null)
            {
                return -1;
            }
            if (dataTable == null)
            {
                return -1;
            }
            try
            {
                installAdapter(transaction, _adapter);
                //strSql = GetReplaceSql(strSql);
                _adapter.SelectCommand.Parameters.Clear();
                _adapter.SelectCommand.CommandText = strSql;
                if (parameters != null)
                {
                    foreach (IDbDataParameter parameter in parameters)
                    {
                        _adapter.SelectCommand.Parameters.Add(parameter);
                    }
                }

                int result = ((DbDataAdapter) _adapter).Fill(dataTable);
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
                freeAdapter(_adapter);
            }
            return num2;
        }

        public int FillNoName(IDbTransaction transaction, DataTable dataTable, string strSql)
        {
            return FillNoName(transaction, dataTable, strSql, null);
        }

        public int FillNoName(IDbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            int num2;
            if (_adapter == null)
            {
                return -1;
            }
            if (dataSet == null)
            {
                return -1;
            }
            if (tableName == null)
            {
                return FillNoName(transaction, dataSet, strSql);
            }
            DataTable dataTable = null;
            try
            {
                installAdapter(transaction, _adapter);
                dataTable = dataSet.Tables[tableName] ?? dataSet.Tables.Add(tableName);
                //strSql = GetReplaceSql(strSql);
                _adapter.SelectCommand.CommandText = strSql;
                int result = ((DbDataAdapter) _adapter).Fill(dataTable);
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
                freeAdapter(_adapter);
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

        public static int FillNoNameOnce(DataSet dataSet, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.FillNoName(dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillNoNameOnce(IDbTransaction transaction, DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.FillNoName(transaction, dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillNoNameOnce(DataSet dataSet, string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.FillNoName(dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillNoNameOnce(IDbTransaction transaction, DataSet dataSet, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.FillNoName(transaction, dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillNoNameOnce(IDbTransaction transaction, DataSet dataSet, string strSql, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
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

        public static int FillOnce(DataSet dataSet, string strSql, IDbDataParameter[] parameters)
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

        public static int FillOnce(DataTable dataTable, string strSql, IDbDataParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(dataTable, strSql, parameters);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql)
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

        public static DataSet FillOnce(string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            DataSet set = buffer.Fill(strSql);
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

        public static int FillOnce(DataSet dataSet, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataTable dataTable, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(dataTable, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataTable dataTable, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataTable, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(transaction, strSql, tableName);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            DataSet set = buffer.Fill(transaction, strSql);
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

        public static DataSet FillOnce(string strSql, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            DataSet set = buffer.Fill(strSql, tableName);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            DataSet set = buffer.Fill(strSql);
            buffer.FreeBuffer();
            return set;
        }

        public static int FillOnce(DataSet dataSet, int tableIndex, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(dataSet, tableIndex, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataSet dataSet, string tableName, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(dataSet, tableName, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataSet dataSet, string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataTable dataTable, string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(dataTable, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataSet, tableIndex, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, string tableName, string strSql)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Fill(transaction, dataSet, tableName, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(transaction, dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataTable dataTable, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(transaction, dataTable, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, string tableName, string strNamespace)
        {
            DBHandlerEx buffer = GetBuffer();
            DataSet set = buffer.Fill(transaction, strSql, tableName, strNamespace);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            DataSet set = buffer.Fill(transaction, strSql, tableName);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            DataSet set = buffer.Fill(transaction, strSql);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(string strSql, string tableName, string strNamespace, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            DataSet set = buffer.Fill(strSql, tableName, strNamespace);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(string strSql, string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            DataSet set = buffer.Fill(strSql, tableName);
            buffer.FreeBuffer();
            return set;
        }

        public static int FillOnce(DataSet dataSet, int tableIndex, string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(dataSet, tableIndex, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(DataSet dataSet, string tableName, string strSql, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(dataSet, tableName, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex, string strSql, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(transaction, dataSet, tableIndex, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, string tableName, string strSql,
            Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Fill(transaction, dataSet, tableName, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, string strSql, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(transaction, dataSet, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataTable dataTable, string strSql, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(transaction, dataTable, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, string tableName, string strNamespace,
            Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            DataSet set = buffer.Fill(transaction, strSql, tableName, strNamespace);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            DataSet set = buffer.Fill(transaction, strSql, tableName);
            buffer.FreeBuffer();
            return set;
        }

        public static DataSet FillOnce(string strSql, string tableName, string strNamespace, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            DataSet set = buffer.Fill(strSql, tableName, strNamespace);
            buffer.FreeBuffer();
            return set;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex, string strSql, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(transaction, dataSet, tableIndex, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static int FillOnce(IDbTransaction transaction, DataSet dataSet, string tableName, string strSql,
            Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Fill(transaction, dataSet, tableName, strSql);
            buffer.FreeBuffer();
            return num;
        }

        public static DataSet FillOnce(IDbTransaction transaction, string strSql, string tableName, string strNamespace,
            Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            DataSet set = buffer.Fill(transaction, strSql, tableName, strNamespace);
            buffer.FreeBuffer();
            return set;
        }

        private void freeAdapter(IDbDataAdapter adapter)
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
            return GetBuffer(_defaultType, _defaultConnectionString);
        }

        public static DBHandlerEx GetBuffer(Type type)
        {
            return GetBuffer(type, null);
        }

        public static DBHandlerEx GetBuffer(Type type, string connectionString)
        {
            CleanException();
            DBHandlerEx handler = new DBHandlerEx();
            if (isConnection(type))
            {
                handler._object = Activator.CreateInstance(type);
                ((IDbConnection) handler._object).ConnectionString = connectionString;
                handler._isConnectionType = true;
            }
            else
            {
                handler._object = Activator.CreateInstance(type);
                handler._isConnectionType = false;
            }
            handler._currentType = type;
            handler.initializeAdapterTable();
            return handler;
        }

        private IDbCommand getCommand(IDbTransaction transaction)
        {
            if ((transaction != null) && (transaction != _transaction))
            {
                return DBBuilder.CreateCommand(transaction.Connection, transaction);
            }
            _command.Transaction = transaction;
            _command.Connection = _connection;
            return _command;
        }

        public IDbDataAdapter GetDataAdapter(string tableName)
        {
            return GetDataAdapter(_transaction, tableName);
        }

        public IDbDataAdapter GetDataAdapter(IDbTransaction transaction, string tableName)
        {
            IDbDataAdapter adapter = _adapters[tableName.ToUpper()] as IDbDataAdapter;
            if (adapter != null)
            {
                return adapter;
            }
            IDbConnection connection = ((transaction == _transaction) || (transaction == null))
                ? _connection
                : transaction.Connection;
            adapter = DBBuilder.CreateAdapter(connection, tableName, transaction);
            if (adapter != null)
            {
                _adapters[tableName.ToUpper()] = adapter;
                return adapter;
            }
            return _adapter;
        }

        public DataSet GetDataSet(string tableName)
        {
            DataSet set3;
            IDbDataAdapter dataAdapter = GetDataAdapter(tableName);
            if (dataAdapter == null)
            {
                return null;
            }
            try
            {
                DataSet dataSet = new DataSet("DataSet_" + tableName.ToUpper());
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

        public static DataSet GetDataSetOnce(string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            DataSet dataSet = buffer.GetDataSet(tableName);
            buffer.FreeBuffer();
            return dataSet;
        }

        public static DataSet GetDataSetOnce(string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            DataSet dataSet = buffer.GetDataSet(tableName);
            buffer.FreeBuffer();
            return dataSet;
        }

        public static string GetException()
        {
            return (Thread.GetData(_exceptionSlot) as string);
        }

        public Hashtable GetProcedureParameters(string procName, out IDbDataParameter[] parameters)
        {
            return GetProcedureParameters(_connection, procName, out parameters);
        }

        public Hashtable GetProcedureParameters(IDbConnection connection, string procName,
            out IDbDataParameter[] parameters)
        {
            string text = procName.ToUpper();
            IDbCommand command = _procParaeters[text] as IDbCommand;
            if (command == null)
            {
                command = DBBuilder.DeriveParameters(connection, procName);
                if (command == null)
                {
                    parameters = null;
                    return null;
                }
                _procParaeters[text] = command;
            }
            parameters = DBBuilder.CreateParameter(connection, command.Parameters.Count);
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i].DbType = ((IDbDataParameter) command.Parameters[i]).DbType;
                parameters[i].Direction = ((IDbDataParameter) command.Parameters[i]).Direction;
                parameters[i].ParameterName = ((IDbDataParameter) command.Parameters[i]).ParameterName;
                parameters[i].Precision = ((IDbDataParameter) command.Parameters[i]).Precision;
                parameters[i].Scale = ((IDbDataParameter) command.Parameters[i]).Scale;
                parameters[i].Size = ((IDbDataParameter) command.Parameters[i]).Size;
                hashtable[parameters[i].ParameterName] = parameters[i];
            }
            return hashtable;
        }

        public static Hashtable GetProcedureParametersOnce(string procName, out IDbDataParameter[] parameters)
        {
            DBHandlerEx buffer = GetBuffer();
            Hashtable procedureParameters = buffer.GetProcedureParameters(procName, out parameters);
            buffer.FreeBuffer();
            return procedureParameters;
        }

        public static Hashtable GetProcedureParametersOnce(string procName, out IDbDataParameter[] parameters, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            Hashtable procedureParameters = buffer.GetProcedureParameters(procName, out parameters);
            buffer.FreeBuffer();
            return procedureParameters;
        }

        public static Hashtable GetProcedureParametersOnce(string procName, out IDbDataParameter[] parameters, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            Hashtable procedureParameters = buffer.GetProcedureParameters(procName, out parameters);
            buffer.FreeBuffer();
            return procedureParameters;
        }

        public static DataSet GetRegisterDataSet(string tableName)
        {
            Type type = _dataSetTypeTable[tableName.ToUpper()] as Type;
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

        private void initializeAdapterTable()
        {
            _adapters.Clear();
            if (_isConnectionType)
            {
                _connection = _object as IDbConnection;
            }
            else
            {
                foreach (
                    FieldInfo info in
                        _currentType.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                                               BindingFlags.DeclaredOnly))
                {
                    if (isConnection(info.FieldType))
                    {
                        _connection = info.GetValue(_object) as IDbConnection;
                    }
                    else if (isDbAdapter(info.FieldType))
                    {
                        DbDataAdapter adapter = info.GetValue(_object) as DbDataAdapter;
                        if ((adapter != null) && (adapter.TableMappings.Count >= 1))
                        {
                            DataTableMapping mapping = adapter.TableMappings[0];
                            if (mapping != null)
                            {
                                _adapters[mapping.DataSetTable.ToUpper()] = adapter;
                            }
                        }
                    }
                }
                if (_connection == null)
                {
                    throw new Exception("无法找到有效的数据库连接");
                }
            }
            if (DBBuilder.GetDBType(_connection) < DBType.ODBC)
            {
                throw new Exception("不支持数据库连接类型");
            }
            _adapter = DBBuilder.CreateAdapter(_connection);
            _command = DBBuilder.CreateCommand(_connection);
        }

        private void installAdapter(IDbTransaction transaction, IDbDataAdapter adapter)
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

        private static bool isConnection(Type type)
        {
            return !type.IsInstanceOfType(typeof(IDbConnection)) || (type.GetInterface("System.Data.IDbConnection") != null);
        }

        private static bool isDbAdapter(Type type)
        {
            return type.IsInstanceOfType(typeof (IDbDataAdapter)) || (type.GetInterface("System.Data.IDbDataAdapter") != null);
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

        public static bool RegisterDBDefaultType(Type type)
        {
            if (
                !type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                                BindingFlags.DeclaredOnly).Any(info => isConnection(info.FieldType))) return false;
            _defaultType = type;
            _defaultConnectionString = null;
            return true;
        }

        public static bool RegisterDBDefaultType(Type type, string connectionString)
        {
            if (type == null)
            {
                return false;
            }
            if (!isConnection(type))
            {
                return false;
            }
            _defaultType = type;
            _defaultConnectionString = connectionString;
            return true;
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

        public int Update(IDbTransaction transaction, DataRow dataRow)
        {
            return Update(transaction, new[] {dataRow});
        }

        public int Update(IDbTransaction transaction, DataRow[] dataRows)
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
            IDbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = ((DbDataAdapter) dataAdapter).Update(dataRows);
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

        public int Update(IDbTransaction transaction, DataSet dataSet)
        {
            if (dataSet.Tables.Count < 1)
            {
                return -2;
            }
            return Update(transaction, dataSet.Tables[0]);
        }

        public int Update(IDbTransaction transaction, DataTable dataTable)
        {
            int num2;
            if ((dataTable == null) || (dataTable.DataSet == null))
            {
                return -2;
            }
            IDbDataAdapter dataAdapter = GetDataAdapter(transaction, dataTable.TableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = ((DbDataAdapter) dataAdapter).Update(dataTable);
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

        public int Update(IDbTransaction transaction, DataSet dataSet, int tableIndex)
        {
            if ((dataSet.Tables.Count > tableIndex) && (tableIndex >= 0))
            {
                return Update(transaction, dataSet.Tables[tableIndex]);
            }
            return -1;
        }

        public int Update(IDbTransaction transaction, DataSet dataSet, string tableName)
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

        public static int UpdateOnce(DataRow dataRow, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(dataRow);
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

        public static int UpdateOnce(DataSet dataSet, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(dataSet);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataTable dataTable, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(dataTable);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataRow[] dataRows, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(dataRows);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataRow dataRow)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataRow);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataSet, 0);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataRow[] dataRows)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataRows);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataTable dataTable)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataTable);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataRow dataRow, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(dataRow);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataSet dataSet, int tableIndex, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(dataSet, tableIndex);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataSet dataSet, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataSet dataSet, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(dataSet);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataTable dataTable, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(dataTable);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataRow[] dataRows, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(dataRows);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataRow dataRow, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(transaction, dataRow);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataSet, tableIndex);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.Update(transaction, dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(transaction, dataSet);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataTable dataTable, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(transaction, dataTable);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataRow[] dataRows, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(transaction, dataRows);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataSet dataSet, int tableIndex, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(dataSet, tableIndex);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(DataSet dataSet, string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataRow dataRow, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(transaction, dataRow);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(transaction, dataSet, tableIndex);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.Update(transaction, dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(transaction, dataSet);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataTable dataTable, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(transaction, dataTable);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataRow[] dataRows, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(transaction, dataRows);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.Update(transaction, dataSet, tableIndex);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateOnce(IDbTransaction transaction, DataSet dataSet, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
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

        public int UpdateToTable(IDbTransaction transaction, DataRow dataRow, string tableName)
        {
            return UpdateToTable(transaction, new[] {dataRow}, tableName);
        }

        public int UpdateToTable(IDbTransaction transaction, DataRow[] dataRows, string tableName)
        {
            int num2;
            if (dataRows.Length < 1)
            {
                return 0;
            }
            IDbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            if (dataAdapter == null)
            {
                return -1;
            }
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = ((DbDataAdapter) dataAdapter).Update(dataRows);
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

        public int UpdateToTable(IDbTransaction transaction, DataSet dataSet, string tableName)
        {
            return UpdateToTable(transaction, dataSet, 0, tableName);
        }

        public int UpdateToTable(IDbTransaction transaction, DataTable dataTable, string tableName)
        {
            int num2;
            if (dataTable == null)
            {
                return -1;
            }
            IDbDataAdapter dataAdapter = GetDataAdapter(transaction, tableName);
            try
            {
                installAdapter(transaction, dataAdapter);
                int result = ((DbDataAdapter) dataAdapter).Update(dataTable);
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

        public int UpdateToTable(IDbTransaction transaction, DataSet dataSet, int tableIndex, string tableName)
        {
            if ((dataSet.Tables.Count > tableIndex) && (tableIndex >= 0))
            {
                return UpdateToTable(transaction, dataSet.Tables[tableIndex], tableName);
            }
            return -1;
        }

        public int UpdateToTable(IDbTransaction transaction, DataSet dataSet, string orgTableName, string tableName)
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

        public static int UpdateToTableOnce(DataRow dataRow, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(dataRow, tableName);
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

        public static int UpdateToTableOnce(DataSet dataSet, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataTable dataTable, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(dataTable, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataRow dataRow, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataRow, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataSet, 0, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataRow[] dataRows, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataRows, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataTable dataTable, string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataTable, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataRow[] dataRows, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(dataRows, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataRow dataRow, string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(dataRow, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataSet dataSet, int tableIndex, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(dataSet, tableIndex, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataSet dataSet, string orgTableName, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(dataSet, orgTableName, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataSet dataSet, string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex,
            string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataSet, tableIndex, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataRow[] dataRows, string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(dataRows, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataTable dataTable, string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(dataTable, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataRow dataRow, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(transaction, dataRow, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, string orgTableName,
            string tableName)
        {
            DBHandlerEx buffer = GetBuffer();
            int num = buffer.UpdateToTable(transaction, dataSet, orgTableName, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(transaction, dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataTable dataTable, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(transaction, dataTable, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataRow[] dataRows, string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(transaction, dataRows, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataSet dataSet, int tableIndex, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(dataSet, tableIndex, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(DataSet dataSet, string orgTableName, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(dataSet, orgTableName, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataRow dataRow, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(transaction, dataRow, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex,
            string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(transaction, dataSet, tableIndex, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, string orgTableName,
            string tableName, Type type)
        {
            DBHandlerEx buffer = GetBuffer(type);
            int num = buffer.UpdateToTable(transaction, dataSet, orgTableName, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(transaction, dataSet, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataTable dataTable, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(transaction, dataTable, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataRow[] dataRows, string tableName, Type type,
            string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(transaction, dataRows, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, int tableIndex,
            string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(transaction, dataSet, tableIndex, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public static int UpdateToTableOnce(IDbTransaction transaction, DataSet dataSet, string orgTableName,
            string tableName, Type type, string connectionString)
        {
            DBHandlerEx buffer = GetBuffer(type, connectionString);
            int num = buffer.UpdateToTable(transaction, dataSet, orgTableName, tableName);
            buffer.FreeBuffer();
            return num;
        }

        public IDbDataAdapter Adapter
        {
            get { return _adapter; }
        }

        public IDbCommand Command
        {
            get { return _command; }
        }

        public IDbConnection Connection
        {
            get { return _connection; }
        }

        public string ConnectionString
        {
            get
            {
                if (_connection == null)
                {
                    return null;
                }
                return _connection.ConnectionString;
            }
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

        public IDbTransaction Transaction
        {
            get { return _transaction; }
        }


        public static IDbDataParameter BuilderDBParameter()
        {
            IDbDataParameter parameter = null;
            if (_defaultType != null)
            {
                if (_defaultType == typeof (SqlConnection))
                {
                    parameter = new SqlParameter();
                }
                else if (_defaultType == typeof (OracleConnection))
                {
                    parameter = new OracleParameter();
                }
            }
            return parameter;
        }
    }
}