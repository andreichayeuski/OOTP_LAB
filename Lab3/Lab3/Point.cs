using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Point
    {
        private int PunktX = 3;
        private int PunktY = 3;
        public int PX
        {
            get
            {
                return PunktX;
            }
            set
            {
                PunktX = value;
            }
        }
        public int PY
        {
            get
            {
                return PunktY;
            }
            set
            {
                PunktY = value;
            }
        }
        /* private Point() закрытый конструктор
         {
             stat = -1;
         }*/
        static Point()  //статический конструктор
        {
            Console.WriteLine("Static");
        }
        public Point()  // без параметров
        {
            PunktX = 0;
            PunktY = 0;
        }
        public Point(int X, int Y = 3)  // с параметрами по умолчанию
        {
            PunktX = X;
            PunktY = Y;
        }
        public override string ToString()
        {
            return "Координаты: x=" + this.PunktX.ToString() + ", y =" + this.PunktY.ToString() + ";";
        }

    }
}
