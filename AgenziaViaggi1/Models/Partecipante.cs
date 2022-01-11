using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi1.Models
{
    internal class Partecipante
    {
        public int PartecipanteID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Indirizzo { get; set; }
        public string Città { get; set; }

        public ICollection<Gita> Gite { get; set; } = new List<Gita>();
    }
}
