using Dapper;
using Infra.ContextBase;
using Model;
using Model.Interface;

namespace Infra.Repository
{
    public class ForumRepository(DapperContext context) : DapperRepositoryBase<ForumRepository>(context), IForumRepository
    {
        public async Task<IEnumerable<Forum>> ListarForuns()
        {
            await _connection.OpenAsync();
            var foruns = await _connection.QueryAsync<Forum>("SELECT * FROM Forum");
            await _connection.CloseAsync();

            return foruns;
        }

    }
}
