using Model.Dto;

namespace Model.Interface
{
    public interface IPublicacaoService
    {
        Task<IEnumerable<PublicacaoDto>> ListarPublicacoes();
        Task<PublicacaoDto> CurtirPublicacao(int idPublicacao);
    }
}
