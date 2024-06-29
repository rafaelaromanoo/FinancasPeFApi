using Model.Dto;

namespace Model.Interface
{
    public interface IRespostaForumService
    {
        Task<IEnumerable<RespostaForumDto>> ListarRespostasForum(int idForum);
        Task<bool> AdicionarRespostaForum(AdicionarRespostaForumDto respostaDto);
    }
}
