﻿using Model;
using Model.Dto;
using Model.Helper;
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

        public async Task<bool> AdicionarForum(AdicionarForumDto adicionarForumDto)
        {
            var foruns = await _repo.ListarForuns();
            var maxIdForum = foruns.Any() ? foruns.Max(x => x.IdForum) : 0;
            var eTag = (Tag)adicionarForumDto.IdTag;

            var novoForum = new Forum()
            {
                IdForum = maxIdForum + 1,
                UsuarioCadastro = adicionarForumDto.UsuarioCadastroForum,
                DataCadastro = DateTime.Now,
                IdTag = adicionarForumDto.IdTag,
                DescricaoTag = eTag.GetDescription(),
                TituloForum = adicionarForumDto.TituloForum,
                ConteudoForum = adicionarForumDto.ConteudoForum,
                CurtidasForum = 0
            };

            return await _repo.Inserir(novoForum);
        }

        public async Task<ForumDto> CurtirForum(int idForum)
        {
            var forumCurtida = await _repo.CurtirForum(idForum);

            return new ForumDto(forumCurtida);
        }
    }
}
