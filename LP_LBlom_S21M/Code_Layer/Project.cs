using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Code_Layer
{
    [Serializable]
    public class Project
    {
        public Gebied Gebied { get; set; }
        public DateTime Starttijd { get; set; } 
        public DateTime Eindtijd { get; set; }

        public List<Bezoek> Bezoeken { get; set; }

        public Project()
        {
             this.Starttijd = DateTime.Now;
            Bezoeken = new List<Bezoek>();
        }

        public bool addBezoek(Bezoek b)
        {
            Bezoeken.Add(b);
            return true;
        }

        public bool SluitProject()
        {
            this.Eindtijd = DateTime.Now;
            return true;
        }

        public bool TekstUitdraai()
        {
            //TODO
            //CheckEisen()
            return false;
        }

        public bool CheckEisen()
        {
            //TODO
            return false;
        }

        public List<string> BerekenBroedparen()
        {
            //TODO
            return null;
        }
    }
}
