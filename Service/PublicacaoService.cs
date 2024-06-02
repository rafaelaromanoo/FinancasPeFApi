using Model;
using Model.Dto;
using Model.Interface;

namespace Service
{
    public class PublicacaoService(IPublicacaoRepository repo) : IPublicacaoService
    {
        private readonly IPublicacaoRepository _repo = repo;

        public async Task<IEnumerable<PublicacaoDto>> Teste()
        {
            var publicacoes = await _repo.Teste();
            var publicacoesDto = new List<PublicacaoDto>();

            foreach (var publicacao in publicacoes)
            {
                var publicacaoDto = new PublicacaoDto(publicacao);
                publicacoesDto.Add(publicacaoDto);
            }

            return publicacoesDto;
        }
    }
}
