using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace UploadFilesLibrary;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration config;

    public SqlDataAccess(IConfiguration config)
    {
        this.config = config;
    }

    public async Task SaveData(string storeProc, string connectionName, object parameters)
    {
        string connectionString = config.GetConnectionString(connectionName)
            ?? throw new Exception($"Missing connection string at {connectionName}");

        using var connection = new SqlConnection(connectionString);

        await connection.ExecuteAsync(storeProc, parameters, commandType: System.Data.CommandType.StoredProcedure);
    }
}

