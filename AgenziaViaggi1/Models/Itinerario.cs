using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi1.Models
{
    internal class Itinerario
    {
        public int ItinerarioID { get; set; }
        public string Descrizione { get; set; }
        public int Durata { get; set; }
        public decimal Prezzo { get; set; }
        public ICollection<Gita> Gite { get; set; } = new List<Gita>();

    }
}
