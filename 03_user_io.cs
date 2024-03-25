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
            Console.WriteLine("Hoş geldiniz!");
            Console.WriteLine("Lütfen adınızı giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Merhaba, " + isim + "!");
        }
    }
}
