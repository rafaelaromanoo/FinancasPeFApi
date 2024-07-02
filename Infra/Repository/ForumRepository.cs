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
            var foruns = await _connection.QueryAsync<Forum>(@"
                                                            SELECT
	                                                            IdForum, UsuarioCadastro, DataCadastro,
	                                                            f.IdTag, Descricao as DescricaoTag, TituloForum,
	                                                            ConteudoForum, CurtidasForum, QuantidadeRespostas
                                                            FROM
	                                                            Forum f
	                                                            JOIN Tag t on f.IdTag = t.IdTag
                                                            ");
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

        public async Task<Forum> CurtirForum(int idForum)
        {
            await _connection.OpenAsync();

            var forumCurtida = await _connection.QueryAsync<Forum>(@"
                                                        UPDATE Forum SET 
                                                                        CurtidasForum = 
                                                                                ((SELECT CurtidasForum 
                                                                                FROM Forum 
                                                                                WHERE idForum = @idForum) + 1)
                                                        WHERE idForum = @idForum;
                                                        SELECT * FROM Forum WHERE IdForum = @idForum", new { idForum });

            await _connection.CloseAsync();

            return forumCurtida.FirstOrDefault()!;
        }
    }
}
