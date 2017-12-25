using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CHAWDiskInfo diskInfo = new CHAWDiskInfo();
                diskInfo.DiskInfo();

                CHAWFileInfo file = new CHAWFileInfo();
                file.FileData("D:\\Документы\\Университет\\3 семестр\\ЯП\\КП\\CHAW-2017\\CHAW-2017\\Lexer.cpp");

                CHAWDirInfo dirInfo = new CHAWDirInfo();
                dirInfo.DirInfo("D:\\Документы\\Университет\\3 семестр\\ЯП\\КП\\CHAW-2017");

                CHAWFileManager fileManager = new CHAWFileManager();
                fileManager.CHAW("D:\\");

                Archive ar = new Archive();
                ar.GetArchive("D:\\CHAWFiles");

                Console.WriteLine("Folders CHAW, CHAWFiles will be deleted");
                if (Console.ReadKey().KeyChar == 'y')
                {
                    Directory.Delete("D:\\CHAWInspect", true);
                    Directory.Delete("D:\\CHAWFiles", true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
