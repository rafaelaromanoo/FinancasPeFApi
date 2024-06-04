namespace Model.Interface
{
    public interface IPublicacaoRepository
    {
        Task<IEnumerable<Publicacao>> ListarPublicacoes();
        Task<Publicacao> CurtirPublicacao(int idPublicacao);
    }
}
