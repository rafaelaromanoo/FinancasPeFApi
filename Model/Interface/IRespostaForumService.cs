﻿using Model.Dto;

namespace Model.Interface
{
    public interface IRespostaForumService
    {
        Task<IEnumerable<RespostaForumDto>> ListarRespostasForum();
    }
}