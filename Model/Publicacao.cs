﻿namespace Model
{
    public class Publicacao
    {
        public required int IdPublicacao { get; set; }
        public required string UsuarioCadastro { get; set; }
        public required DateTime DataCadastro { get; set; }
        public required int IdTag { get; set; }
        public string DescricaoTag { get; set; } = string.Empty;
        public required string TituloPublicacao { get; set; }
        public required string ConteudoPublicacao { get; set; }
        public int CurtidasPublicacao { get; set; }
    }
}
