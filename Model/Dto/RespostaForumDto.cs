namespace Model.Dto
{
    public class RespostaForumDto(RespostaForum resposta)
    {
        public string UsuarioCadastro { get; set; } = resposta.UsuarioCadastro;
        public string ConteudoResposta { get; set; } = resposta.ConteudoResposta;
    }
}
