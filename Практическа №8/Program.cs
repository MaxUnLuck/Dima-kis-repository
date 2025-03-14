using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа__8
{
    internal class Program
    {
            public static void Main(string[] args)
            {
            double sX = -5;
            double eX = 5;
            double step = 0.5;
            Console.WriteLine("     x  |    y    ");
            double x = sX;
            while (x <= eX)
            {
                double y = 5 - (x * x) / 2;
                Console.WriteLine($"  {x,5:F1} | {y,7:F2} ");
                x += step;
            }
            Console.ReadKey();
       }
    }
}
