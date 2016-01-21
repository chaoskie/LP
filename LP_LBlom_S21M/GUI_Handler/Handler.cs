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
        public List<string> VogelNamen;
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
            VogelNamen = new List<string>();
            foreach (Diersoort d in Diersoorten)
            {
                VogelNamen.Add(d.Naam);
            }
        }

        public bool NewBezoek()
        {
            bez = new Bezoek();
            proj.addBezoek(bez);
            xml.VewerkData(proj, true);
            return true;
        }

        public bool NewWaarneming(int xcoord, int ycoord, string code, int diersoort)
        {
            if (Diersoorten.FirstOrDefault(x => x.Naam == VogelNamen[diersoort]) == null)
            {
                return false;
            }
            else
            {
                Waarneming w = new Waarneming(xcoord, ycoord, codes.FirstOrDefault(x => x.Afkorting == code),
                                            Diersoorten.FirstOrDefault(x => x.Naam == VogelNamen[diersoort]));
                bez.AddWaarneming(w);
                xml.VewerkData(proj, false);
                return true;
            }

        }

        public List<string> FindWaarnemingOnClick(int xcoord, int ycoord)
        {
            List<string> returnMe = new List<string>();
            List<Waarneming> w = bez.WaarnemingenOphalen();
            if (w.Count <= 0)
            {
                return returnMe;
            }
            Waarneming found = w.FirstOrDefault(x => ((xcoord + 5 >= x.LocatieX) && (xcoord - 5 <= x.LocatieX)) &&
                                                                 ((ycoord + 5 >= x.LocatieY) && (ycoord - 5 <= x.LocatieY)));
            if (found == null)
            {
                return returnMe;
            }

            returnMe.Add("X-coordinaten: " + found.LocatieX.ToString());
            returnMe.Add("Y-coordinaten: " + found.LocatieY.ToString());
            returnMe.Add("Tijd: " + found.Tijd.ToShortTimeString());
            returnMe.Add("Dier: " + found.Dier.Naam);
            returnMe.Add("Soort waarneming: " + found.Afkorting.Afkorting);
            returnMe.Add(found.Afkorting.Naam);

            return returnMe;
        }

        public List<string> berekenBroedpunten()
        {
            List<string> returnMe = new List<string>();
            List<int> punten = new List<int>();

            returnMe = proj.BerekenBroedparen(out punten);

            foreach (Diersoort d in Diersoorten)
            {
                for (int i = 0; i < returnMe.Count; i++)
                {
                    if (d.Naam == returnMe[i])
                    {
                        punten[i] = (int)Math.Floor((double)punten[i] / d.BroedPunten);
                    }
                }
            }

            for (int i = 0; i < returnMe.Count; i++)
            {
                returnMe[i] += " " + (punten[i]).ToString() + "\n";
            }

            return returnMe;
        }

    }
}
