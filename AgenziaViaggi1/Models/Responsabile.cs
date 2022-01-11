using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi1.Models
{
    internal class Responsabile
    {
        public int ResponsabileID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumeroTelefono { get; set; }
        public ICollection<Gita> Gite { get; set; } = new List<Gita>();

    }
}
