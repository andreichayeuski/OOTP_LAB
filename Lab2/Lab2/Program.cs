using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte Sbyte = 1;
            short Short = 2;
            int Int = 3;
            long Long = 4;
            byte Byte = 5;
            ushort Ushort = 6;
            uint Uint = 7;
            ulong Ulong = 8;
            char Char = ' ';
            bool Bool = true;
            float Float = 1.1f;
            double Double = 1.2;
            decimal Decimal = 9;
            string String = "Andrei";
            object Object = "Chayeuski";

            Int = (int)Uint;
            Long = (long)Ulong;
            Short = (short)Ushort;
            Float = (float)Double;
            Long = (long)Decimal;

            Int = Byte;
            Int = Short;
            Long = Int;
            Decimal = Long;
            Double = Float;

            Object ObjInt = Int;
            int Int2 = (int)Int;
            Console.WriteLine(Int2 + "\n");

            var Var1 = 5;
            var Var2 = 8;
            var Var1_Str = "Tuman";
            var Var2_Str = "Yozhike";

            Console.WriteLine(Var1 + Var2 + "\n");
            Console.WriteLine(Var1_Str + " v " + Var2_Str + "\n");

            short? Null1 = null;
            short? Null2 = null;
            Console.WriteLine("{0} \n----------------------", Null1.HasValue && Null2.HasValue ? "Not null" : "null");


            string String2 = "Vladimir";
            Console.WriteLine("{0} {2} {1}\n", String, String2, String == String2 ? "==" : "!=");

            String Str1 = "POIT ";
            String Str2 = "ISIT ";
            String Str3 = "DEIVY ";
            String Str4 = "I am STARosta";

            Console.WriteLine("{0}\n", String.Concat(Str1, Str2, Str3));

            Str2 = String.Copy(Str1);
            Console.WriteLine("{0}\n", Str2);

            Console.WriteLine("{0}\n", Str3.Substring(2));

            Console.WriteLine("{2} {1} {0}\n", Str4.Split(' ')[0], Str4.Split(' ')[1], Str4.Split(' ')[2]);

            Console.WriteLine("{0}\n", Str4.Insert(5, Str1));

            Console.WriteLine("{0}\n", Str4.Remove(5, Str1.Length - 1));

            String Empty = "";
            String Null = null;

            Console.WriteLine("{0}\t{1}\n", Empty.Length, Empty == Null);

            StringBuilder NewString = new StringBuilder("My Group ", 5);
            Console.WriteLine("{0}\n", NewString.Remove(1, 2));
            Console.WriteLine("{0}\n", NewString.Remove(0, 1));
            Console.WriteLine("{0}\n", NewString.Insert(0, "Fourth "));
            Console.WriteLine("{0}\n", NewString.Insert(NewString.Length, "is the best"));

            int[,] Matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string[] Sentence = new string[] { "My ", "First ", "Laboratornaya ", "On ", "C#. " };
            for (int i = 0; i < Sentence.Length; i++)
                Console.Write(Sentence[i]);
            Console.WriteLine("Sentence.Length = " + Sentence.Length);
            Console.WriteLine("\nWrite position and substitution");
            int position = Int32.Parse(Console.ReadLine());
            Sentence[position] = Console.ReadLine();
            for (int i = 0; i < Sentence.Length; i++)
                Console.Write(Sentence[i]);
            Console.WriteLine();

            float[][] FloatArray = new float[3][];
            FloatArray[0] = new float[2];
            FloatArray[1] = new float[3];
            FloatArray[2] = new float[4];
            Console.WriteLine("Write float numbers");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < FloatArray[i].Length; j++)
                {
                    Console.Write("FloatArray[{0}][{1}] ", i, j);
                    FloatArray[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < FloatArray[i].Length; j++)
                {
                    Console.Write(FloatArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            var VarArray = new[] { 1, 2, 3 };
            var VarString = "VarString";

            Console.WriteLine("------------------------");

            (int DefaultInt, string DefaultString, char DefaultChar, string DefaultString2, ulong DefaultUlong) Default = (13, "My ", 'l', "Number", 1000000);
            Console.WriteLine($"{Default}");
            Console.WriteLine(Default.DefaultInt + " " + Default.DefaultChar + " " + Default.DefaultString2);

            var (First, Second, Third, Fourth, Fifth) = (Default.DefaultInt, Default.DefaultString, Default.DefaultChar, Default.DefaultString2, Default.DefaultUlong);
            var Type_1 = (a: 13, b: 'A');
            var Type_2 = (c: 13, d: "Chayeuski");
            Console.WriteLine("Кортежи {0} и {1} - {2}", Type_1, Type_2, Object.Equals(Type_1, Type_2) ? "равны\n" : "не равны\n");

            Console.WriteLine("------------------------");

            (int, int, int, char) MainFunction(int[] arr,string str)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), str.First());
            }

            Console.WriteLine("Write int number");
            int[] Task = new int[4];
            for (int i = 0; i < Task.Length; i++)
            {
                Console.WriteLine("Task[{0}]",i);
                Task[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Write string");
            string Task2 = Console.ReadLine();
            Console.WriteLine(MainFunction(Task,Task2));
            Console.ReadKey();
        }
    }
}
