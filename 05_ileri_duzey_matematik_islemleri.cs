using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5.3;
            Console.WriteLine("Cos(x): " + Math.Cos(x));
            Console.WriteLine("Sin(x): " + Math.Sin(x));
            Console.WriteLine("Tan(x): " + Math.Tan(x));

            double negatifX = -5.3;
            Console.WriteLine("Abs(negatifX): " + Math.Abs(negatifX));

            double y = x + 2; // 7.3
            Console.WriteLine("Min(x, y): " + Math.Min(x, y));
            Console.WriteLine("Min(x, y): " + Math.Max(x, y));

            Console.WriteLine("Sqrt(x): " + Math.Sqrt(x));

            Console.WriteLine("Sqrt(x): " + Math.Pow(x, 2)); // x^2

            Console.WriteLine("Floor(x): " + Math.Floor(x));
            Console.WriteLine("Ceiling(x): " + Math.Ceiling(x));

        }
    }
}
