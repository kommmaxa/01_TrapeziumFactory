using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    class TrapeziumBuilder : QuadrilateralBuilder
    {
        

        public override Quadrilateral Generate (int currentNumber)
        {
            const int upperRangeForRandomCalculation = 10;
            const int lowerRangeForRandomCalculation = 9;
            double randomValueForRightCoordinates = Math.Round(RandomUtility.GetRandomDouble(lowerRangeForRandomCalculation, upperRangeForRandomCalculation), 2);
            int randomValueForUpCoordinates = RandomUtility.GetRandomInteger(1, 100);

            Point LeftBottom = new Point(0, 0, "Left Bottom");
            Point RightBottom = new Point(randomValueForRightCoordinates, 0, "Right Bottom");
            Point LeftUp = new Point(2, randomValueForUpCoordinates, "Left Up");
            Point RightUp = new Point(randomValueForRightCoordinates - 2, randomValueForUpCoordinates, "Right Up");

            return new Trapezium(LeftBottom, LeftUp, RightUp, RightBottom, (currentNumber + 1).ToString());
        }
    }
}
