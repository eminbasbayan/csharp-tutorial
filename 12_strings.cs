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
            //String Tanımlama
            string cumle = "Bugün güzel bir gün.";

            //String Metodları ve Özellikleri
            //String Uzunluğu
            Console.WriteLine(cumle.Length);

            //Karakterlere Erişim
            Console.WriteLine(cumle[0]);

            //String İçinde Arama
            Console.WriteLine(cumle.IndexOf("güzel"));

            //String Karşılaştırma
            string baskaCumle = "Bugün güzel bir gün..";
            Console.WriteLine(cumle.Equals(baskaCumle)); //Boolean

            //String Değiştirme
            Console.WriteLine(cumle.Replace("güzel", "müthiş"));
        }
    }
}
