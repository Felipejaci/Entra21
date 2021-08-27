using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpt4
{
    class Habitacao : Endereco
    {
        string tipeHabi, nomeDono;

        public string TipeHabi { get; set; }
        public string NomeDono { get; set; }
    }
}
