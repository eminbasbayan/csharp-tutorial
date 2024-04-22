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
            List<int> sayilar = new List<int>();

            sayilar.Add(1);
            sayilar.Add(24);
            sayilar.Add(50);

            sayilar.Remove(24);
            sayilar.Remove(50);

            foreach (int eleman in sayilar)
            {
                Console.WriteLine(eleman);
            }

            Console.WriteLine(sayilar.Count);
        }
    }
}
