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

        public async Task<bool> Inserir(Forum forum)
        {
            await _connection.OpenAsync();
            var inserido = await _connection.ExecuteAsync(
                @"INSERT INTO Forum (IdForum, 
                                        UsuarioCadastro, 
                                        DataCadastro, 
                                        IdTag, 
                                        TituloForum, 
                                        ConteudoForum, 
                                        CurtidasForum)
                    VALUES (@IdForum, 
                            @UsuarioCadastro, 
                            @DataCadastro, 
                            @IdTag, 
                            @TituloForum, 
                            @ConteudoForum, 
                            @CurtidasForum)",
                new
                {
                    forum.IdForum,
                    forum.UsuarioCadastro,
                    forum.DataCadastro,
                    forum.IdTag,
                    forum.TituloForum,
                    forum.ConteudoForum,
                    forum.CurtidasForum
                });
            await _connection.CloseAsync();

            return inserido > 0;
        }

    }
}
