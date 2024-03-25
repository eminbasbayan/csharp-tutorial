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
            int a = 15;

            if (a < 15) {
                Console.WriteLine("a sayısı 15'ten küçük!");
            } else if (a <= 15) {
                Console.WriteLine("a sayısı 15'e eşit veya küçük!");
            } else {
                Console.WriteLine("a sayısı 15'ten büyük!");
            }
        }
    }
}
