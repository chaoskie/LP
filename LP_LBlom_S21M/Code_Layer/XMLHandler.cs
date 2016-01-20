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

        public XMLHandler()
        {
            AppPath = Assembly.GetEntryAssembly().Location;
            FilePath = AppPath.Substring(0, AppPath.Length - "LP_LBlom_S21M\\bin\\Debug\\LP_LBlom_S21M.exe".Length);
            XMLPath = FilePath + "Code_Layer\\XMLContent\\";
        }

        public bool VewerkData(Bezoek bezoek)
        {/*
            //stop bezoek in xml file
            Object o = bezoek;
            Assembly a = Assembly.Load("Code_Layer");
            Type t = a.GetType("Code_Layer." + o.GetType().Name);

            XmlSerializer xmls = new XmlSerializer(t);
            StreamWriter writer = new StreamWriter(XMLPath + "result.xml");
            xmls.Serialize(writer, bezoek);
            writer.Close();*/
            return false;
        }

        public bool ExportXML()
        {
            //TODO
            //XML naar database 
            return false;
        }
    }
}
