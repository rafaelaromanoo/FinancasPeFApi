using Model.Dto;
using Model.Interface;

namespace Service
{
    public class ForumService(IForumRepository repo) : IForumService
    {
        private readonly IForumRepository _repo = repo;

        public async Task<IEnumerable<ForumDto>> ListarForuns()
        {
            var foruns = await _repo.ListarForuns();
            var forunsDto = new List<ForumDto>();

            foreach (var forum in foruns)
            {
                var forumDto = new ForumDto(forum);
                forunsDto.Add(forumDto);
            }

            return forunsDto;
        }
    }
}
