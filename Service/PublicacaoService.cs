using Model;
using Model.Dto;
using Model.Interface;

namespace Service
{
    public class PublicacaoService(IPublicacaoRepository repo) : IPublicacaoService
    {
        private readonly IPublicacaoRepository _repo = repo;

        public async Task<IEnumerable<PublicacaoDto>> ListarPublicacoes()
        {
            var publicacoes = await _repo.ListarPublicacoes();
            var publicacoesDto = new List<PublicacaoDto>();

            foreach (var publicacao in publicacoes)
            {
                var publicacaoDto = new PublicacaoDto(publicacao);
                publicacoesDto.Add(publicacaoDto);
            }

            return publicacoesDto;
        }

        public async Task<PublicacaoDto> CurtirPublicacao(int idPublicacao)
        {
            var publicacaoCurtida = await _repo.CurtirPublicacao(idPublicacao);

            return new PublicacaoDto(publicacaoCurtida);
        }
    }
}
