using Microsoft.Data.SqlClient;

namespace Infra.ContextBase
{
    public class DapperContext
    {
        public readonly SqlConnection conn;

        public DapperContext(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException($"Falha ao obter a ConnectionString.");
            }

            conn = new SqlConnection(connectionString);
        }
    }
}
