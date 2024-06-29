using Model.Dto;

namespace Model.Interface
{
    public interface IForumRepository
    {
        Task<IEnumerable<Forum>> ListarForuns();
        Task<bool> Inserir(Forum forum);
        Task<Forum> CurtirForum(int idForum);
    }
}
