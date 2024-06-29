using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IRespostaForumRepository
    {
        Task<IEnumerable<RespostaForum>> ListarRespostasForum(int idForum);
    }
}
