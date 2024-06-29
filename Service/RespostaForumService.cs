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
    }
}
