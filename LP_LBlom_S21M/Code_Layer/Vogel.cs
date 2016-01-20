using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Layer
{
    class Vogel : Diersoort, IComparer<Vogel>
    {
        //comparer atributes?

        public Vogel(string naam, string afk, DateTime startSzn, DateTime eindSzn, int punten)
            : base(naam, afk, startSzn, eindSzn, punten)
        {

        }

        public int Compare(Vogel x, Vogel y)
        {
            //todo
            throw new NotImplementedException();
        }
    }
}
