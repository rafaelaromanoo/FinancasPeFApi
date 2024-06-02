using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IPublicacaoRepository
    {
        Task<IEnumerable<Publicacao>> ListarPublicacoes();
        Task<Publicacao> CurtirPublicacao(int idPublicacao);
    }
}
