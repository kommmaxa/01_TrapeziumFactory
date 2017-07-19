using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    class Program
    {
        const int Quantity = 5;
        
        static void Main(string[] args)
        {
            QuadrilateralBuilder builder = new TrapeziumBuilder();
            List<Quadrilateral> trapezia = new List<Quadrilateral>();
            for (int i = 0; i < Quantity; i++)
            {
                trapezia.Add(builder.Generate(i));
                Console.WriteLine(trapezia[i]);
            }
            double TrapeziaAverageSquare = Trapezium.CalculateAverageSquare(trapezia);
            int TrapeziaWhooseSquareAboveAverage = Trapezium.CalculateQuadrilateralWhooseSquareAboveAverage(trapezia, TrapeziaAverageSquare);
            Console.WriteLine();
            Console.WriteLine("Average square = " + TrapeziaAverageSquare);
            Console.WriteLine("Number of trapezia above average equals " + TrapeziaWhooseSquareAboveAverage);

            Console.ReadLine();
        }
    }
}