﻿namespace Model
{
    public class Forum
    {
        public required int IdForum { get; set; }
        public required string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public required int IdTag { get; set; }
        public string DescricaoTag { get; set; } = string.Empty;
        public required string TituloForum { get; set; }
        public required string ConteudoForum { get; set; }
        public int CurtidasForum { get; set; }
        public int QuantidadeRespostas { get; set; }
    }
}