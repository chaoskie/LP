using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Layer
{
    public class Code
    {
        public string Afkorting { get; set; }
        public string Naam { get; set; }
        public int Punten { get; set; }

        public Code(string afk, string naam, int punt)
        {
            this.Afkorting = afk;
            this.Naam = naam;
            this.Punten = punt;
        }        
    }
}
