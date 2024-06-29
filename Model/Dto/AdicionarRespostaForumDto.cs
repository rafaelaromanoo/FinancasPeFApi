using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class AdicionarRespostaForumDto
    {
        public int IdForum { get; set; }
        public string UsuarioCadastro { get; set; } = string.Empty;
        public string ConteudoResposta { get; set; } = string.Empty;
    }
}
