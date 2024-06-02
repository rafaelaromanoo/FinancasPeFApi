using Dapper;
using Infra.ContextBase;
using Model;
using Model.Dto;
using Model.Interface;

namespace Infra.Repository
{
    public class PublicacaoRepository(DapperContext context) : DapperRepositoryBase<PublicacaoRepository>(context), IPublicacaoRepository
    {
        public async Task<IEnumerable<Publicacao>> Teste()
        {
            await _connection.OpenAsync();
            var publicacoes = await _connection.QueryAsync<Publicacao>("SELECT * FROM Publicacao");
            await _connection.CloseAsync();

            return publicacoes;
        }
    }
}
