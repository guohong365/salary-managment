using System;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace UC.Platform.Data.DBHelper
{
    internal sealed class DBBuilder
    {
        public static DbDataAdapter CreateAdapter(IDatabaseProviderFactory factory)
        {
            var adapter = factory.CreateDataAdapter();
            return adapter;
        }

        public static DbDataAdapter CreateAdapter(IDatabaseProviderFactory factory, string tableName)
        {
            var adapter = CreateAdapter(factory);
            if (adapter == null) throw new DataException();
            adapter.SelectCommand = CreateCommand(factory);
            adapter.SelectCommand.CommandText = "SELECT * FROM " + tableName;
            adapter.MissingSchemaAction = MissingSchemaAction.Add;
            DbCommandBuilder builder = factory.CreateCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand(true);
            adapter.UpdateCommand = builder.GetUpdateCommand(true);
            adapter.DeleteCommand = builder.GetDeleteCommand(true);
            return adapter;
        }

        public static DbDataAdapter CreateAdapter(IDatabaseProviderFactory factory, string tableName, DbTransaction transaction)
        {
            DbDataAdapter adapter = CreateAdapter(factory);
            adapter.SelectCommand = CreateCommand(factory);
            adapter.SelectCommand.Transaction = transaction;
            adapter.SelectCommand.CommandText = "SELECT * FROM " + tableName;
            adapter.MissingSchemaAction = MissingSchemaAction.Add;
            DbCommandBuilder builder = factory.CreateCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand(true);
            adapter.UpdateCommand = builder.GetUpdateCommand(true);
            adapter.DeleteCommand = builder.GetDeleteCommand(true);
            return adapter;
        }

        public static DbCommand CreateCommand(IDatabaseProviderFactory factory)
        {
            DbCommand command = factory.CreateCommand();
            command.Connection = factory.CreateConnection();
            return command;
        }

        public static DbCommand CreateCommand(IDatabaseProviderFactory factory, DbTransaction transaction)
        {
            var command = CreateCommand(factory);
            command.Transaction = transaction;
            return command;
        }

        public static DbParameter CreateParameter(IDatabaseProviderFactory factory)
        {
            return factory.CreateParameter();
        }

        public static DbParameter[] CreateParameter(IDatabaseProviderFactory factory, int count)
        {   
            var parameterArray = new DbParameter[count];
            for (var i = 0; i < count; i++)
            {
                parameterArray[i] = factory.CreateParameter();
            }
            return parameterArray;
        }

        public static bool DeriveParameters(IDatabaseProviderFactory factory, DbCommand cmd)
        {
            if ((cmd == null) || (cmd.Connection == null) || cmd.CommandType!= CommandType.StoredProcedure)
            {
                return false;
            }
            DbCommandBuilder builder = factory.CreateCommandBuilder();
            MethodInfo methodInfo = builder.GetType().GetMethod("DeriveParameters", new []{typeof(DbCommand)});
            if (methodInfo == null) return false;
            bool isOpened = cmd.Connection.State == ConnectionState.Open;
            try
            {
                if(!isOpened) cmd.Connection.Open();
                methodInfo.Invoke(null, new object[] {cmd});
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if(!isOpened)cmd.Connection.Close();
            }
        }

        public static DbCommand DeriveParameters(IDatabaseProviderFactory factory, string procName)
        {
            DbCommand command = factory.CreateCommand();
            if (command == null) return null;
            command.Connection = factory.CreateConnection();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            if (DeriveParameters(factory, command))
            {
                return command;
            }
            return null;
        }
    }
}
