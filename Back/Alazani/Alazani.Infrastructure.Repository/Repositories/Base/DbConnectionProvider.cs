using Alazani.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace Alazani.Infrastructure.Repository.Repositories.Base;

/// <summary>
/// use this for dapper
/// </summary>
public interface IDbConnectionProvider
{
    IDbConnection GetStoreDbConnection();
}

public class DbConnectionProvider : IDbConnectionProvider
{
    private readonly IConnectionString _str;

    public DbConnectionProvider(IConnectionString str)
    {
        _str = str;
    }

    public IDbConnection GetStoreDbConnection()
    {
        var conn = new SqlConnection(_str.Alazani);
        if (conn.State != ConnectionState.Open) conn.Open();

        return conn;
    }
}
