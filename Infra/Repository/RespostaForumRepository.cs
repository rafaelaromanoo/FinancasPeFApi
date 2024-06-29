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

        public async Task<IEnumerable<RespostaForum>> ListarRespostasForum()
        {
            await _connection.OpenAsync();
            var respostas = await _connection.QueryAsync<RespostaForum>(@"SELECT * FROM RespostaForum");
            await _connection.CloseAsync();

            return respostas;
        }

        public async Task<bool> Inserir(RespostaForum resposta)
        {
            await _connection.OpenAsync();

            var inserido = await _connection.ExecuteAsync(
                @"INSERT INTO RespostaForum (IdRespostaForum, IdForum, UsuarioCadastro, ConteudoResposta) 
                    VALUES (@IdRespostaForum, @IdForum, @UsuarioCadastro, @ConteudoResposta)",
                new
                {
                    resposta.IdRespostaForum,
                    resposta.IdForum,
                    resposta.UsuarioCadastro,
                    resposta.ConteudoResposta
                });

            await _connection.CloseAsync();

            return inserido > 0;
        }
    }
}
