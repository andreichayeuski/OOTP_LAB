using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal partial class Book
    {
        private string Author;
        private string Name;
        public Book()
        {
            Author = "No author";
            Name = "No name";
            WriteInfo();
        }
        partial void WriteInfo();
    }

    internal sealed partial class Book
    {
        public Book(string auth, string name)
        {
            Author = auth;
            Name = name;
            WriteInfo();
        }
        partial void WriteInfo()
        {
            Console.WriteLine("{0} from {1}", this.Name, this.Author);
        }
    }
}
