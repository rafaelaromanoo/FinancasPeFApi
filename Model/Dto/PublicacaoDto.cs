namespace Model.Dto
{
    public class PublicacaoDto(Publicacao publicacao)
    {
        public int IdPublicacao { get; set; } = publicacao.IdPublicacao;
        public string UsuarioCadastro { get; set; } = publicacao.UsuarioCadastro;
        public string DataCadastro { get; set; } = publicacao.DataCadastro.ToString();
        public int IdTag { get; set; } = publicacao.IdTag;
        public string DescricaoTag { get; set; } = publicacao.DescricaoTag;
        public string TituloPublicacao { get; set; } = publicacao.TituloPublicacao;
        public string ConteudoPublicacao { get; set; } = publicacao.ConteudoPublicacao;
        public int CurtidasPublicacao { get; set; } = publicacao.CurtidasPublicacao;
    }
}