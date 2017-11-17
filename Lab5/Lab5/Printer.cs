using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Printer
    {
        public static string IAmPrinting(Interface1 someobj)
        {
            return someobj.ToString();
        }
    }
}
