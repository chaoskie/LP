using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace Code_Layer
{
    public class XMLHandler
    {
        private string AppPath;
        private string FilePath;
        private string XMLPath;
        private string filename;

        int count = 0;

        //constructor
        public XMLHandler()
        {
            AppPath = Assembly.GetEntryAssembly().Location;
            FilePath = AppPath.Substring(0, AppPath.Length - "LP_LBlom_S21M\\bin\\Debug\\LP_LBlom_S21M.exe".Length);
            XMLPath = FilePath + "Code_Layer\\XMLContent\\";
        }
        /// <summary>
        /// deze methode gaat controleren welke naam 
        /// er beschikbaar is in de XML bestanden
        /// </summary>
        public void NewNameFile()
        {
            while (File.Exists(XMLPath + "result" + count.ToString() + ".xml"))
            {
                count++;
            }            
        }

        /// <summary>
        /// verwerk de data in het project object tot XML file
        /// </summary>
        /// <param name="proj">te verwerken tot XML file</param>
        /// <param name="newFile">moet er een nieuw bestand gemaakt worden</param>
        /// <returns>succes boolean</returns>
        public bool VewerkData(Project proj, bool newFile)
        {
            if (newFile)
            {
                NewNameFile();
            }
            filename = "result" + count.ToString() + ".xml";

            // elk overridden field, property, of type heeft een XmlAttributes instance nodig.
            XmlAttributes xmlAttrs = new XmlAttributes();
            // maken van het attribuut
            XmlElementAttribute attr = new XmlElementAttribute();
            attr.ElementName = "newVogel";
            attr.Type = typeof(Vogel);

            xmlAttrs.XmlElements.Add(attr);

            // maken van het override attribuut
            XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();

            // voeg de override waarde toe aan de lijst met het veld dat de inheritance heeft samen met de attribuuten
            attrOverrides.Add(typeof(Waarneming), "Dier", xmlAttrs);

            try
            {
                Type t = typeof(Code_Layer.Project);
                XmlSerializer xmls = new XmlSerializer(t, attrOverrides);
                using (FileStream fs = new FileStream(XMLPath + filename, FileMode.Create))
                {
                    xmls.Serialize(fs, proj);
                }
            }
            catch (Exception e)//error afhandelen
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }
        /// <summary>
        /// exporteer de XML bestanden naar de database
        /// </summary>
        /// <returns>succes boolean</returns>
        public bool ExportXML()
        {
            //TODO
            //XML naar database 
            return false;
        }
    }
}
