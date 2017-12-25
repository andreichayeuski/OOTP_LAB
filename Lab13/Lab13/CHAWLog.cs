using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    public class CHAWLog
    {
        public void Search()
        {
            string curTimeLong = DateTime.Now.ToLongTimeString();
            using (StreamWriter sw = new StreamWriter(@"E:\SAM\NEWFile.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("File created time : " + curTimeLong);
            }
        }
    }
}