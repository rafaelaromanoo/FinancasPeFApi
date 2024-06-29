using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RespostaForum
    {
        public int IdRespostaForum { get; set; }
        public int IdForum { get; set; }
        public string UsuarioCadastro { get; set; } = string.Empty;
        public string ConteudoResposta { get; set; } = string.Empty;
        public int CurtidasRespostaForum { get; set; }
    }
}
