using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Handler()
        {
            CSVReader CSV = new CSVReader();
            Diersoorten = CSV.Load();
            VulVogelNamen();
            
            xml = new XMLHandler();
            xml.VewerkData(proj);
        }

        public void VulVogelNamen()
        {
            VogelNamen = new List<KeyValuePair<string,string>>();
            foreach (Diersoort d in Diersoorten)
            {
                VogelNamen.Add(new KeyValuePair<string, string>(d.Naam, d.Afkorting));
            }
        }

        public bool NewBezoek()
        {
            bez = new Bezoek();
            proj.addBezoek(bez);
            return true;
        }

        public bool NewWaarneming()
        {
            bez.AddWaarneming();
        }


       
    }
}
