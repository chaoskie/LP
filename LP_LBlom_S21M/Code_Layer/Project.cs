using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Code_Layer
{
    [Serializable]
    public class Project
    {
        public Gebied Gebied { get; set; }
        public DateTime Starttijd { get; set; }
        public DateTime Eindtijd { get; set; }

        public List<Bezoek> Bezoeken { get; set; }

        //constructor
        public Project()
        {
            this.Starttijd = DateTime.Now;
            Bezoeken = new List<Bezoek>();
        }
        /// <summary>
        /// bezoek toevoegen aan het huidige project
        /// </summary>
        /// <param name="b">toe te voegen bezoek</param>
        /// <returns>succes bool</returns>
        public bool addBezoek(Bezoek b)
        {
            Bezoeken.Add(b);
            return true;
        }
        /// <summary>
        /// het huidige project afsluiten
        /// </summary>
        /// <returns>succes bool</returns>
        public bool SluitProject()
        {
            this.Eindtijd = DateTime.Now;
            return true;
        }
        /// <summary>
        /// het maken van de tekstuitdraai
        /// </summary>
        /// <returns>succes bool</returns>
        public bool TekstUitdraai()
        {
            //TODO
            //CheckEisen()
            return false;
        }
        /// <summary>
        /// controleer of voldaan is aan de eisen 
        /// om een uitdraai te mogen maken
        /// </summary>
        /// <returns>boolof er voldaan is aan de uitdraai eisen</returns>
        public bool CheckEisen()
        {
            //TODO
            return false;
        }
        /// <summary>
        /// Methode voor het optellen van de broedpunten 
        /// aan de hand van de waarnemingen
        /// gefilterd op het broedseizoen
        /// </summary>
        /// <param name="broedpunten">deze lijst bevat alle broedpunten</param>
        /// <returns>lijst van alle vogels die geregistreerd zijn als broedend in het huidige seizoen</returns>
        public List<string> BerekenBroedparen(out List<int> broedpunten)
        {
            List<string> vogelnamen = new List<string>();
            broedpunten = new List<int>();

            foreach (Bezoek b in Bezoeken)
            {
                foreach (Waarneming w in b.Waarnemingen)
                {
                    if (vogelnamen.FirstOrDefault(x => w.Dier.Naam == x) == null)//alle waarnemingen doorlopen
                    {
                        if ((w.Dier.StartBroedseizoen <= w.Tijd) && (w.Dier.EindBroedseizoen > w.Tijd))//kijk of waarneming al bestaat
                        {//controleer of de waarneming in het juiste seizoen valt
                            vogelnamen.Add(w.Dier.Naam);
                            broedpunten.Add(w.Afkorting.Punten);
                        }
                    }
                    if (vogelnamen.FirstOrDefault(x => w.Dier.Naam == x) != null)//kijk of waarneming bestaat
                    {
                        int i = vogelnamen.IndexOf(w.Dier.Naam);
                        if ((w.Dier.StartBroedseizoen <= w.Tijd) && (w.Dier.EindBroedseizoen > w.Tijd))//kijk of waarneming in het seizoen valt
                        {
                            broedpunten[i] += w.Afkorting.Punten;
                        }
                    }
                }
            }

            return vogelnamen;
        }
    }
}
