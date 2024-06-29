namespace Model.Dto
{
    public class RespostaForumDto(RespostaForum resposta)
    {
        public int IdRespostaForum { get; set; } = resposta.IdRespostaForum;
        public int IdForum { get; set; } = resposta.IdForum;
        public string UsuarioCadastro { get; set; } = resposta.UsuarioCadastro;
        public string ConteudoResposta { get; set; } = resposta.ConteudoResposta;
    }
}
