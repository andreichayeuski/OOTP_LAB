using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Triangle
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Triangle tr = obj as Triangle;

            if (tr as Triangle == null)
            {
                return false;
            }

            return ((tr.Points[0] == this.Points[0]) && (tr.Points[1] == this.Points[1]) && (tr.Points[2] == this.Points[2]));
        }

        public override int GetHashCode()
        {
            int unitCode;
            if (this.Rank == "Равносторонний")
            {
                unitCode = 1;
            }
            else
            {
                unitCode = 2;
            }

            return unitCode;
        }


        public readonly int id = -1;
        private Point[] Points;
        public string Rank = "";
        static int number = 0;
        const int size = 3;
        public int Size
        {
            get
            {
                return size;
            }
        }
        public Point[] POINT
        {
            get
            {
                return Points;
            }
            set
            {
                Points = value;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
        }
        public Triangle()   // без параметров
        {
            Points = new Point[size] { null, null, null };
            id = this.Points[0].GetHashCode() + this.Points[1].GetHashCode() + this.Points[2].GetHashCode();
            number++;
        }
        public Triangle(Point P1, Point P2, Point P3)   // с параметрами
        {
            Points = new Point[size] { P1, P2, P3 };
            id = this.Points[0].GetHashCode() + this.Points[1].GetHashCode() + this.Points[2].GetHashCode();
            double[] arr_of_tr = this.Calc();
            int Index = 0, sz = 0;
            int[] In = new int[2];
            for (int i = 0; i < arr_of_tr.Length; i++)
            {
                if (arr_of_tr[i] == arr_of_tr.Max())
                {
                    Index = i;
                }
                else
                {
                    In[sz] = i;
                    sz++;
                }
            }
            if ((arr_of_tr[0] == arr_of_tr[1]) && (arr_of_tr[2] == arr_of_tr[1]))
            {
                Rank += "Равносторонний";
            }
            if ((arr_of_tr[0] == arr_of_tr[1]) || (arr_of_tr[2] == arr_of_tr[1]) || (arr_of_tr[0] == arr_of_tr[2]))
            {
                Rank += "Равнобедренный";
            }
            if (Math.Pow(arr_of_tr[Index], 2) == (Math.Pow(arr_of_tr[In[0]], 2) + Math.Pow(arr_of_tr[In[1]], 2)))
            {
                Rank += "Прямоугольный";
            }
            if (Rank == "")
            {
                Rank = "Произвольный";
            }
            number++;
        }

        public static void WriteInfo()
        {
            Console.WriteLine("Info about class");
        }

        public void Write()
        {
            for (int i = 0; i < this.Size; i++)
            {
                Console.WriteLine("{2}: X = {0} Y = {1}", this.Points[i].PX, this.Points[i].PY, i + 1);
            }
        }

        public double[] Calc()
        {
            double[] result = new double[this.Size];
            result[0] = Math.Sqrt(Math.Pow((this.Points[0].PX - this.Points[1].PX), 2) + Math.Pow((this.Points[0].PY - this.Points[1].PY), 2));
            result[1] = Math.Sqrt(Math.Pow((this.Points[1].PX - this.Points[2].PX), 2) + Math.Pow((this.Points[1].PY - this.Points[2].PY), 2));
            result[2] = Math.Sqrt(Math.Pow((this.Points[2].PX - this.Points[0].PX), 2) + Math.Pow((this.Points[2].PY - this.Points[0].PY), 2));
            return result;
        }
        public void Perimetr(out double sum)
        {
            double Sum = 0;
            double[] Arr = this.Calc();
            for (int i = 0; i < this.Size; i++)
            {
                Sum += Arr[i];
            }
            sum = Sum;
        }

    }
}
