using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Layer
{
    public abstract class Diersoort
    {
        public string Naam { get; set; }
        public string Afkorting { get; set; }
        public DateTime StartBroedseizoen { get; set; }
        public DateTime EindBroedseizoen { get; set; }
        public int BroedPunten { get; set; }

        public Diersoort() { }//nodig voor xml serialisatie
        public Diersoort(string naam, string afk, DateTime startSzn, DateTime eindSzn, int punten)
        {
            this.Afkorting = afk;
            this.BroedPunten = punten;
            this.EindBroedseizoen = eindSzn;
            this.Naam = naam;
            this.StartBroedseizoen = startSzn;
        }
    }
}
