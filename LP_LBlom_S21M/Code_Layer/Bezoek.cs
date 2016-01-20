﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Code_Layer
{
    [Serializable]
    public class Bezoek
    {      
        public DateTime Starttijd ;

        public DateTime Eindtijd;

        public List<Waarneming> Waarnemingen;

        public Bezoek()
        {
            Waarnemingen = new List<Waarneming>();
            this.Starttijd = DateTime.Now;
        }

        public bool Sluitbezoek()
        {
            this.Eindtijd = DateTime.Now;
            return true;
        }

        public bool AddWaarneming(Waarneming waarneming)
        {
            return false;
            //TODO
        }

        public bool VerwijderWaarneming(Waarneming waarneming)
        {
            return false;
            //TODO
        }
        public List<Waarneming> WaarnemingenOphalen()
        {
            return this.Waarnemingen;
        }
    }
}
