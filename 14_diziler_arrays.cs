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
            int not1 = 70;
            int not2 = 40;
            int not3 = 80;

            int[] notlar = { 70, 40, 80, 50, 36, 43};

            int toplam = 0;

            foreach(int not in notlar) {
                toplam += not;
            }

            Console.WriteLine(notlar.Length);

            double ortalama = (double)toplam / notlar.Length;

            Console.WriteLine(ortalama);
        }
    }
}
