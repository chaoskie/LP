using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Layer
{
    public class Gebied
    {
        public string Naam { get; set; }
        public string Kaart { get; set; }

        public Gebied(string naam, string kaartPath)
        {
            this.Kaart = kaartPath;
            this.Naam = naam;
        }
    }
}
