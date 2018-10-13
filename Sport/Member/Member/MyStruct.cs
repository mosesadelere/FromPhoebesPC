using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    struct point2D
    {

        private double x;
        private double y;

        public point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }
    }
    class MyStruct
    {
        public void PrintPoint(point2D p)
        {
            Console.WriteLine("({0}, {1})", p.X, p.Y);
        }

        public void TryToChangePoint(point2D p)
        {
            p.X++;
            p.Y++;
        }
    }
}
