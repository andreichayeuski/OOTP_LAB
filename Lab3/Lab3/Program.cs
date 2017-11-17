using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point(), P2 = new Point(0), P3 = new Point(2, 0), P4 = new Point(2, 3), P5 = new Point(4, 5), P6 = new Point(4, 0);
            Triangle[] Array_Of_Triangles = new Triangle[3];
            double sum = 0, max = 0, min = 0;
            Array_Of_Triangles[0] = new Triangle(P1, P2, P6);
            Array_Of_Triangles[1] = new Triangle(P1, P4, P6);
            Array_Of_Triangles[2] = new Triangle(P1, P3, P5);
            int rstor = 0, rbedr = 0, pryam = 0, proiz = 0;
            double rstormax = 0, rstormin = 100, rbedrmax = 0, rbedrmin = 100, pryammax = 0, pryammin = 100, proizmax = 0, proizmin = 100;
            int irstormax = -2, irstormin = -2, irbedrmax = -2, irbedrmin = -2, ipryammax = -2, ipryammin = -2, iproizmax = -2, iproizmin = -2;
            Array_Of_Triangles[0].Perimetr(out sum);
            max = sum;
            min = sum;
            for (int i = 0; i < Array_Of_Triangles.Length; i++)
            {
                sum = 0;
                Array_Of_Triangles[i].Perimetr(out sum);
                if (Array_Of_Triangles[i].Rank == "Равносторонний")
                {
                    rstor += 1;

                    if (sum > rstormax)
                    {
                        rstormax = sum;
                        irstormax = i;
                    }
                    if (sum < rstormin)
                    {
                        rstormin = sum;
                        irstormin = i;
                    }
                }
                if (Array_Of_Triangles[i].Rank == "Равнобедренный")
                {
                    rbedr += 1;
                    if (sum > rbedrmax)
                    {
                        rbedrmax = sum;
                        irbedrmax = i;
                    }
                    if (sum < rbedrmin)
                    {
                        rbedrmin = sum;
                        irbedrmin = i;
                    }
                }
                if (Array_Of_Triangles[i].Rank == "Прямоугольный")
                {
                    pryam += 1;
                    if (sum > pryammax)
                    {
                        pryammax = sum;
                        ipryammax = i;
                    }
                    if (sum < pryammin)
                    {
                        pryammin = sum;
                        ipryammin = i;
                    }
                }
                if (Array_Of_Triangles[i].Rank == "Произвольный")
                {
                    proiz += 1;
                    if (sum > proizmax)
                    {
                        proizmax = sum;
                        iproizmax = i;
                    }
                    if (sum < proizmin)
                    {
                        proizmin = sum;
                        iproizmin = i;
                    }
                }
            }
            Console.WriteLine("Равносторонних - {0},  Равнобедренных - {1}, Прямоугольных - {2}, Произвольных - {3}", rstor, rbedr, pryam, proiz);
            if (irstormax != -2 && irstormin != -2)
                Console.WriteLine("Наибольший - {0}, наименьший - {1} по периметру равносторонний треугольник", irstormax + 1, irstormin + 1);
            else
                Console.WriteLine("Нет равносторонних треугольников");
            Console.WriteLine("Наибольший - {0}, наименьший - {1} по периметру равнобедренный треугольник", irbedrmax + 1, irbedrmin + 1);
            Console.WriteLine("Наибольший - {0}, наименьший - {1} по периметру прямоугольный треугольник", ipryammax + 1, ipryammin + 1);
            Console.WriteLine("Наибольший - {0}, наименьший - {1} по периметру произвольный треугольник", iproizmax + 1, iproizmin + 1);

            Console.WriteLine(Array_Of_Triangles[0].Equals(Array_Of_Triangles[1]));
            Console.WriteLine(Array_Of_Triangles[2].GetHashCode());
            Console.WriteLine(P1.ToString() + "\n" + P2.ToString() + "\n" + P6.ToString());

            Book B1 = new Book();
            Book B2 = new Book("Conan Doyle", "Sherlock Holmes");

            var varPoint = new { PointX = 2, PointY = 4 };
            Console.WriteLine("x = {0}, y = {1}", varPoint.PointX, varPoint.PointY);

            Console.ReadKey();
        }
    }
}
