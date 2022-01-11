using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi1.Models
{
    internal class Gita
    {
        public int GitaID { get; set; }
        public DateTime DataPartenza { get; set; }
        public ICollection<Partecipante> Partecipanti { get; set; } = new List<Partecipante>();
        public int ItinerarioID { get; set; }
        public Itinerario Itinerario { get; set; }
        public int ResponsabileID { get; set; }
        public Responsabile Responsabile { get; set; }

    }
}
