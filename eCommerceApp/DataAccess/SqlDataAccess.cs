using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace eCommerceApp.DataAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _configuration;
    public SqlDataAccess(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionStringName = "Default")
    {
        string connectionString = _configuration.GetConnectionString(connectionStringName)!;

        using IDbConnection connection = new SqlConnection(connectionString);

        var result = await connection.QueryAsync<T>(sql, parameters);

        return result.ToList();
    }

    public async Task SaveData<T>(string sql, T paramters, string connectionStringName = "Default")
    {
        string connectionString = _configuration.GetConnectionString(connectionStringName)!;

        using IDbConnection connection = new SqlConnection(connectionString);

        await connection.ExecuteAsync(sql, paramters);
    }
}
