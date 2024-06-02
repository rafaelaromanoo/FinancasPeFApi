using Model.Dto;

namespace Model.Interface
{
    public interface IForumRepository
    {
        Task<IEnumerable<Forum>> ListarForuns();
    }
}
