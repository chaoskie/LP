using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Layer
{
    public class Vogel : Diersoort, IComparer<Vogel>
    {
        //constructor
        public Vogel():base() { }//nodig voor xml serialisatie

        public Vogel(string naam, string afk, DateTime startSzn, DateTime eindSzn, int punten)
            : base(naam, afk, startSzn, eindSzn, punten)
        {

        }
        
        /// <summary>
        /// compare methode 
        /// vergelijk object a en b met elkaar
        /// </summary>
        /// <param name="x">object 1 </param>
        /// <param name="y">object 2</param>
        /// <returns>een nummer welke aangeeft of object a of object b grter is</returns>
        public int Compare(Vogel x, Vogel y)
        {
            //todo
            throw new NotImplementedException();
        }
    }
}
