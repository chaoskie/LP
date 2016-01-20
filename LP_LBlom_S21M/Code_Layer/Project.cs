using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Layer
{
    public class Project
    {
        public Gebied Gebied { get; set; }
        public DateTime Starttijd { get; set; }
        public DateTime Eindtijd { get; set; }

        public Project()
        {
            this.Starttijd = DateTime.Now;
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
