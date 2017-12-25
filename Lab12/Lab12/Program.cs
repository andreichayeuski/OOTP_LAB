using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector("Lab3.Book");
            reflector.AboutClass();
            reflector.PublicMethods();
            reflector.Fields();
            reflector.Interfaces();
            reflector.Methods();
            reflector.Runtimemethod("Met");
        }
    }
}
