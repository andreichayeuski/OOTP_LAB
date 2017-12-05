using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class NullException : Exception
    {
        public NullException(string message) : base(message)
        {
        }
        public void GetInfo()
        {
            Console.WriteLine("NullException: " + this.Message);
        }
    }

    public class EmptyException : Exception
    {

        public EmptyException(string message) : base(message)
        {

        }
        public void GetInfo()
        {
            Console.WriteLine("EmptyException: " + this.Message);
        }
    }
}
