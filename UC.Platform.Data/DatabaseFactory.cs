using System.Configuration;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace UC.Platform.Data
{
    public class DatabaseFactory : IDatabaseProviderFactory
    {
        private readonly DbProviderFactory _factory;
        private readonly string _connectionString;
        private readonly string _providerName;
        
        public DatabaseFactory(ConnectionStringSettings connectionString)
        {
            _providerName = connectionString.ProviderName;
            _connectionString = connectionString.ConnectionString;
            DataTable dataTable= DbProviderFactories.GetFactoryClasses();
            _factory = DbProviderFactories.GetFactory(connectionString.ProviderName);
        }

        public DatabaseFactory(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _factory=DbProviderFactories.GetFactory(providerName);
        }

        public DbCommand CreateCommand()
        {
            return _factory.CreateCommand();
        }

        public DbCommandBuilder CreateCommandBuilder()
        {
            return _factory.CreateCommandBuilder();
        }

        public DbCommandBuilder CreateCommandBuilder(DbDataAdapter adapter)
        {
            DbCommandBuilder builder = _factory.CreateCommandBuilder();
            if (builder != null)
            {
                builder.DataAdapter = adapter;
                return builder;
            }
            throw new DataException("创建CommnadBuilder失败！");
        }

        public DbConnection CreateConnection()
        {
            DbConnection connection = _factory.CreateConnection();
            if (connection != null)
            {
                connection.ConnectionString = ConnectionString;
                return connection;
            }
            throw new DataException("创建数据连接失败！");
        }

        public DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return _factory.CreateConnectionStringBuilder();
        }

        public DbDataAdapter CreateDataAdapter()
        {
            return _factory.CreateDataAdapter();
        }

        public DbParameter CreateParameter()
        {
            return _factory.CreateParameter();
        }

        public bool CanCreateDataSourceEnumerator
        {
            get
            {
                return _factory.CanCreateDataSourceEnumerator;
            }
        }

        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        public string ProviderName
        {
            get
            {
                return _providerName;
            }
        }
    }
}
