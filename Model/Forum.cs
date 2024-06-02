﻿namespace Model
{
    public class Forum
    {
        public required int IdForum { get; set; }
        public required string UsuarioCadastro { get; set; }
        public required DateTime DataCadastro { get; set; }
        public required int IdTag { get; set; }
        public required string TituloForum { get; set; }
        public string ConteudoForum { get; set; } = string.Empty;
        public int CurtidasForum { get; set; }
    }
}