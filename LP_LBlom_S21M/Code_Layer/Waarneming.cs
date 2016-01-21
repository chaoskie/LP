using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace Code_Layer
{
    [Serializable]
    public class Waarneming
    {
        public int LocatieX { get; set; }
        public int LocatieY { get; set; }
        public Code Afkorting { get; set; }
        public Diersoort Dier { get; set; }
        public DateTime Tijd { get; set; }

        public Waarneming()//nodig voor serialize
        {        }

        public Waarneming(int X, int Y, Code afk, Diersoort dier)
        {
            this.Afkorting = afk;
            this.Dier = dier;
            this.LocatieX = X;
            this.LocatieY = Y;
            this.Tijd = DateTime.Now;
        }

        /// <summary>
        /// details terug geven over de 
        /// waarneming
        /// </summary>
        /// <returns>lijst van entries over de waarneming</returns>
        public List<string> Geefdetails()
        {
            return null;
            //TODO
            //mogelijk vervangen/verplaatsen door...?
        }

        /// <summary>
        /// Diersoort van de waarneming aanpassen
        /// </summary>
        /// <param name="dier">nieuwe diersoort</param>
        /// <returns>succes bool</returns>
        public bool PasDiersoortAan(Diersoort dier)
        {
            this.Dier = dier;
            return true;
        }

    }
}
