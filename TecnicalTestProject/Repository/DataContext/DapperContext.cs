using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Repository.DataContext
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;

        public DapperContext(IConfiguration configuration) => _configuration = configuration;
        public IDbConnection GetDbConnection() => new SqlConnection(_configuration["DatabaseSettings:ConnectionString"]);

    }
}
