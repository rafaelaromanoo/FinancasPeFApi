using Model;
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

        public async Task<bool> AdicionarForum(string usuarioCadastro, string tituloForum, string conteudoForum)
        {
            var foruns = await _repo.ListarForuns();

            var maxIdForum = foruns.Any() ? foruns.Max(x => x.IdForum) : 0;

            var novoForum = new Forum()
            {
                IdForum = maxIdForum + 1,
                UsuarioCadastro = usuarioCadastro,
                DataCadastro = DateTime.Now,
                IdTag = 1,
                TituloForum = tituloForum,
                ConteudoForum = conteudoForum,
                CurtidasForum = 0
            };

            return await _repo.Inserir(novoForum);
        }
    }
}
