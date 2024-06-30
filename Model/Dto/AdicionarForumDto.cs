namespace Model.Dto
{
    public class AdicionarForumDto
    {
        public int IdTag { get; set; }
        public string UsuarioCadastroForum { get; set; } = string.Empty;
        public string TituloForum { get; set; } = string.Empty;
        public string ConteudoForum { get; set; } = string.Empty;
    }
}
