using Dapper;
using Infra.ContextBase;
using Model;
using Model.Interface;

namespace Infra.Repository
{
    public class RespostaForumRepository(DapperContext context) : DapperRepositoryBase<RespostaForumRepository>(context), IRespostaForumRepository
    {
        public async Task<IEnumerable<RespostaForum>> ListarRespostasForum(int idForum)
        {
            await _connection.OpenAsync();
            var respostas = await _connection
                .QueryAsync<RespostaForum>(@"SELECT * FROM RespostaForum 
                                           WHERE IdForum = @idForum", new { idForum });
            await _connection.CloseAsync();

            return respostas;
        }
    }
}
