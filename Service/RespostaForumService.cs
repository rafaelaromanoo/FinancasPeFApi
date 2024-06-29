using Model;
using Model.Dto;
using Model.Interface;

namespace Service
{
    public class RespostaForumService(IRespostaForumRepository repo) : IRespostaForumService
    {
        private readonly IRespostaForumRepository _repo = repo;

        public async Task<IEnumerable<RespostaForumDto>> ListarRespostasForum(int idForum)
        {
            var respostas = await _repo.ListarRespostasForum(idForum);
            var respostasDto = new List<RespostaForumDto>();

            foreach (var resposta in respostas)
            {
                var respostaDto = new RespostaForumDto(resposta);
                respostasDto.Add(respostaDto);
            }

            return respostasDto;
        }

        public async Task<bool> AdicionarRespostaForum(AdicionarRespostaForumDto respostaDto)
        {
            var respostasForum = await _repo.ListarRespostasForum();

            var maxIdRespostaForum = respostasForum.Any() ? respostasForum.Max(x => x.IdRespostaForum) : 0;

            var novaRespostaForum = new RespostaForum()
            {
                IdRespostaForum = maxIdRespostaForum + 1,
                IdForum = respostaDto.IdForum,
                UsuarioCadastro = respostaDto.UsuarioCadastro,
                ConteudoResposta = respostaDto.ConteudoResposta
            };

            return await _repo.Inserir(novaRespostaForum);
        }
    }
}
