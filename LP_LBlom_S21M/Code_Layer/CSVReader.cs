using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace Code_Layer
{
    public class CSVReader
    {
        private string AppPath;
        private string FilePath;

        public CSVReader()
        {
            AppPath = Assembly.GetEntryAssembly().Location;
            FilePath = AppPath.Substring(0, AppPath.Length - "LP_LBlom_S21M.exe".Length);            
        }

        /// <summary>
        /// Loads from the default location
        /// </summary>
        public List<Diersoort> Load()
        {
            List<Diersoort> loadedAnimals = new List<Diersoort>();
            //Get all the animal names from the local storage
            using (TextFieldParser parser = new TextFieldParser(FilePath + "broedvogels.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        string[] columns = field.Split(';');
                        string[] startDatetime = columns[2].Split('-');
                        string[] endDatetime = columns[3].Split('-');
                        DateTime sdt = new DateTime(2000, Convert.ToInt32(startDatetime[1]), Convert.ToInt32(startDatetime[0]));
                        DateTime edt = new DateTime(2000, Convert.ToInt32(endDatetime[1]), Convert.ToInt32(endDatetime[0]));
                        Diersoort toAdd = new Vogel(
                            columns[0],
                            columns[1],
                            sdt,
                            edt,
                            Convert.ToInt32(columns[4]));
                        loadedAnimals.Add(toAdd);
                    }
                }
            }
            return loadedAnimals;
        }
    }
}

