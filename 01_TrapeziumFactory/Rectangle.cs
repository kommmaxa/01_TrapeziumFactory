using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    class Rectangle : Quadrilateral
    {

        public override string Perimeter
        {
            get { return CalculatePerimeter().ToString(); }
        }
        public override string Square
        {
            get { return CalculateSquare().ToString(); }
        }

        public Rectangle(Point point1, Point point2, Point point3, Point point4, string name): base(point1, point2, point3, point4, name) { }

        public override double CalculatePerimeter()
        {
            return Math.Round((BottomSide.Length + RightSide.Length) * 2, 2);
        }

        public override double CalculateSquare()
        {
            return Math.Round(BottomSide.Length * RightSide.Length, 2);
        }
    }
}
