using System.Data.Common;

namespace UC.Platform.Data
{
    public interface IDatabaseProviderFactory  
    {
        DbCommand CreateCommand();
        DbCommandBuilder CreateCommandBuilder();
        DbCommandBuilder CreateCommandBuilder(DbDataAdapter adapter);
        DbConnection CreateConnection();
        DbConnectionStringBuilder CreateConnectionStringBuilder();
        DbDataAdapter CreateDataAdapter();
        DbParameter CreateParameter();
        bool CanCreateDataSourceEnumerator { get; }
        string ConnectionString { get; }
        string ProviderName { get; }
    }
}