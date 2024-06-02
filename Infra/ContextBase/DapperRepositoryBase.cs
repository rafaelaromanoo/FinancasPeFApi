using Microsoft.Data.SqlClient;

namespace Infra.ContextBase
{
    public class DapperRepositoryBase<T>
    {
        protected readonly DapperContext _context;
        protected readonly SqlConnection _connection;

        public DapperRepositoryBase(DapperContext context)
        {
            _context = context;
            _connection = _context.conn;
        }
    }
}