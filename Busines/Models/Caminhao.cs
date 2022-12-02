using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Models
{
    public class Caminhao:Veiculo
    {
        public string Chassi { get; set; }
        public int PesoEmTonelada { get; set; }
    }
}
