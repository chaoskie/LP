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
        public XMLHandler xml;
        public Handler()
        {
            CSVReader CSV = new CSVReader();
            Diersoorten = CSV.Load();
        }
    }
}
