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

        public XMLHandler()
        {
            AppPath = Assembly.GetEntryAssembly().Location;
            FilePath = AppPath.Substring(0, AppPath.Length - "LP_LBlom_S21M\\bin\\Debug\\LP_LBlom_S21M.exe".Length);
            XMLPath = FilePath + "Code_Layer\\XMLContent\\";
        }

        public bool VewerkData(Project proj)
        {
            while (File.Exists(XMLPath + "result" + count.ToString() + ".xml"))
            {
                count++;
            }
            filename = "result" + count.ToString() + ".xml";
            try
            {
                Type t = typeof(Code_Layer.Project);
                XmlSerializer xmls = new XmlSerializer(t);
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

        public bool ExportXML()
        {
            //TODO
            //XML naar database 
            return false;
        }
    }
}
