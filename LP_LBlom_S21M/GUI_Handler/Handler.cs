using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Code_Layer;

namespace GUI_Handler
{
    public class Handler
    {
        public List<Diersoort> Diersoorten;
        public List<KeyValuePair<string, string>> VogelNamen;
        public XMLHandler xml;
        public Project proj = new Project();
        public Bezoek bez;
        public List<Code> codes;
        public Handler()
        {
            CSVReader CSV = new CSVReader();
            Diersoorten = CSV.Load();
            VulVogelNamen();
            MaakCodes();
            xml = new XMLHandler();
        }       

        public void MaakCodes()
        {
            codes = new List<Code>();
            codes.Add(new Code("VA", "Vogel Aanwezig", 1));
            codes.Add(new Code("TI", "Territorium Indicerend", 2));
            codes.Add(new Code("NI", "Nest Indicerend", 3));
        }

        public void VulVogelNamen()
        {
            VogelNamen = new List<KeyValuePair<string, string>>();
            foreach (Diersoort d in Diersoorten)
            {
                VogelNamen.Add(new KeyValuePair<string, string>(d.Naam, d.Afkorting));
            }
        }

        public bool NewBezoek()
        {
            bez = new Bezoek();
            proj.addBezoek(bez);
            xml.VewerkData(proj, true);
            return true;
        }

        public bool NewWaarneming(int xcoord, int ycoord, string code, string diersoort)
        {
            if (Diersoorten.FirstOrDefault(x => x.Naam == diersoort) == null)
            {
                return false;
            }
            else
            {
                Waarneming w = new Waarneming(xcoord, ycoord, codes.FirstOrDefault(x => x.Afkorting == code), Diersoorten.FirstOrDefault(x => x.Naam == diersoort));
                bez.AddWaarneming(w);
                xml.VewerkData(proj, false);
                return true;
            }
            
        }



    }
}
