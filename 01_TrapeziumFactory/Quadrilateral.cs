using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    public abstract class Quadrilateral
    {
        protected Point Point1 { get; set; }
        protected Point Point2 { get; set; }
        protected Point Point3 { get; set; }
        protected Point Point4 { get; set; }
        protected string Name { get; set; }
        protected Segment LeftSide { get; set; }
        protected Segment UpperSide { get; set; }
        protected Segment RightSide { get; set; }
        protected Segment BottomSide { get; set; }
        public virtual string Perimeter { get; set; }
        public virtual string Square { get; set; }
        public abstract double CalculateSquare();
        public abstract double CalculatePerimeter();
        public Quadrilateral(Point point1, Point point2, Point point3, Point point4, string name)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
            LeftSide = new Segment(point1, point2);
            UpperSide = new Segment(point2, point3);
            RightSide = new Segment(point3, point4);
            BottomSide = new Segment(point4, point1);
            Name = name;
        }

        public override string ToString()
        {
            return "Points: " + Point1.ToString() + " " + Point2.ToString() + " " + Point3.ToString() + " " + Point4.ToString();
        }
        public string DisplaySideLengths()
        {
            string result = "\n";
            result += "Left side has length of " + LeftSide + "\n";
            result += "Upper side has length of " + UpperSide + "\n";
            result += "Right side has length of " + RightSide + "\n";
            result += "Bottom side has length of " + BottomSide + "\n";
            return result;
        }

        public string DisplayPerimeter()
        {
            return "Figure's perimeter = " + Perimeter + "\n";
        }
        public string DisplaySquare()
        {
            return "Figure's square = " + Square;
        }

        public static double CalculateAverageSquare(List<Quadrilateral> quadrilaterials)
        {
            double sum = 0;
            for (int i = 0; i < quadrilaterials.Count; i++)
            {
                sum += quadrilaterials[i].CalculateSquare();
            }
            return Math.Round(sum / quadrilaterials.Count, 2);
        }

        public static int CalculateQuadrilateralWhooseSquareAboveAverage(List<Quadrilateral> quadrilaterials, double averageSquare)
        {
            int count = 0;
            for (int i = 0; i < quadrilaterials.Count; i++)
            {
                if (quadrilaterials[i].CalculateSquare() > averageSquare)
                    count++;
            }
            return count;
        }
    }
}
