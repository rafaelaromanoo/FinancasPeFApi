namespace Model.Dto
{
    public class ForumDto(Forum forum)
    {
        public int IdForum { get; set; } = forum.IdForum;
        public string UsuarioCadastro { get; set; } = forum.UsuarioCadastro;
        public string DataCadastro { get; set; } = forum.DataCadastro.ToString();
        public int IdTag { get; set; } = forum.IdTag;
        public string TituloForum { get; set; } = forum.TituloForum;
        public string ConteudoForum { get; set; } = forum.ConteudoForum;
        public int CurtidasForum { get; set; } = forum.CurtidasForum;
        public int QuantidadeRespostas { get; set; } = forum.QuantidadeRespostas;
    }
}