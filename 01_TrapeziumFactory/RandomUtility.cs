using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    public static class RandomUtility
    {
        private static Random rnd = new System.Random();
        public static double GetRandomDouble(double minimum, double maximum)
        {
            return rnd.NextDouble() * (maximum - minimum) + minimum;
        }

        public static int GetRandomInteger(int minimum, int maximum)
        {
            return rnd.Next(minimum, maximum);
        }
    }
}
