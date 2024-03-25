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
            Console.WriteLine("8 + 4: " + (8 + 4));
            Console.WriteLine("8 - 4: " + (8 - 4));
            Console.WriteLine("8 * 4: " + (8 * 4));
            Console.WriteLine("8 / 4: " + (8 / 4));
            Console.WriteLine("8 % 4: " + (8 % 4));

            int i = 1;
            Console.WriteLine("i = " + i++);
            Console.WriteLine("i = " + ++i);
        }
    }
}
