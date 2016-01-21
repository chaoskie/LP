using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Code_Layer
{
    public class Bezoek
    {      
        
        public DateTime Starttijd {get; set;} 

        public DateTime Eindtijd {get; set;}

        public List<Waarneming> Waarnemingen;

        //constructor
        public Bezoek()
        {
            Waarnemingen = new List<Waarneming>();
            this.Starttijd = DateTime.Now;
        }

        /// <summary>
        /// sluit bezoek af
        /// </summary>
        /// <returns>succesion bool</returns>
        public bool Sluitbezoek()
        {
            this.Eindtijd = DateTime.Now;
            return true;
        }
        /// <summary>
        /// voegt waarneming toe aan lijst van waarnemingen
        /// </summary>
        /// <param name="w">toe te voegen waarneming</param>
        /// <returns>succession bool</returns>
        public bool AddWaarneming(Waarneming w)
        {
            Waarnemingen.Add(w);
            return true;
        }
        /// <summary>
        /// verwijderd waarneming uit lijst van waarnemingen
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public bool VerwijderWaarneming(Waarneming w)
        {
            return false;
            //TODO
        }
        /// <summary>
        /// haalt lijst van waarnemingen op 
        /// </summary>
        /// <returns>lijst van op te halen waarnemingen</returns>
        public List<Waarneming> WaarnemingenOphalen()
        {
            return this.Waarnemingen;
        }
    }
}
