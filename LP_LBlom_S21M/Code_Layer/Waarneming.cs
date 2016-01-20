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
        public PointF LocatieX { get; set; }
        public PointF LocatieY { get; set; }
        public Code Afkorting { get; set; }
        public Diersoort Dier { get; set; }
        public DateTime Tijd { get; set; }

        public Waarneming(PointF X, PointF Y, Code afk, Diersoort dier)
        {
            this.Afkorting = afk;
            this.Dier = dier;
            this.LocatieX = X;
            this.LocatieY = Y;
            this.Tijd = DateTime.Now;
        }

        public List<string> Geefdetails()
        {
            return null;
            //TODO
        }

        public bool PasDiersoortAan(Diersoort dier)
        {
            this.Dier = dier;
            return true;
        }

        public override string ToString()
        {
            //TODO
            return base.ToString();
        }
    }
}
