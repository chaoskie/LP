using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Handler
{

    public class ExportException : Exception
    {
        public ExportException(string ex) : base(ex) { }
    }
}

