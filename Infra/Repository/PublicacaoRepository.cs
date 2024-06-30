using Dapper;
using Infra.ContextBase;
using Model;
using Model.Dto;
using Model.Interface;

namespace Infra.Repository
{
    public class PublicacaoRepository(DapperContext context) : DapperRepositoryBase<PublicacaoRepository>(context), IPublicacaoRepository
    {
        public async Task<IEnumerable<Publicacao>> ListarPublicacoes()
        {
            await _connection.OpenAsync();
            var publicacoes = await _connection.QueryAsync<Publicacao>(@"
                                                                        SELECT 
	                                                                        IdPublicacao, UsuarioCadastro, DataCadastro,
	                                                                        p.IdTag, Descricao as DescricaoTag, TituloPublicacao,
	                                                                        ConteudoPublicacao, CurtidasPublicacao
                                                                        FROM Publicacao p 
	                                                                        JOIN Tag t on p.IdTag = t.IdTag
                                                                        ");
            await _connection.CloseAsync();

            return publicacoes;
        }

        public async Task<Publicacao> CurtirPublicacao(int idPublicacao)
        {
            await _connection.OpenAsync();
            var publicacaoCurtida = await _connection.QueryAsync<Publicacao>(@"
                                                        UPDATE Publicacao SET 
                                                                            CurtidasPublicacao = 
                                                                                    ((SELECT CurtidasPublicacao 
                                                                                    FROM Publicacao 
                                                                                    WHERE idPublicacao = @idPublicacao) + 1)
                                                        WHERE idPublicacao = @idPublicacao;
                                                        SELECT * FROM Publicacao WHERE IdPublicacao = @idPublicacao", new { idPublicacao });

            await _connection.CloseAsync();

            return publicacaoCurtida.FirstOrDefault()!;
        }
    }
}
