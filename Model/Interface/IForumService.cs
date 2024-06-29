using Model.Dto;

namespace Model.Interface
{
    public interface IForumService
    {
        Task<IEnumerable<ForumDto>> ListarForuns();
        Task<bool> AdicionarForum(AdicionarForumDto adicionarForumDto);
        Task<ForumDto> CurtirForum(int idForum);
    }
}
