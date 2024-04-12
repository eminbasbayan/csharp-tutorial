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
            StringBuilder stringBuilder = new StringBuilder();

            //StringBuilder'a Metin Ekleme
            //stringBuilder.Append("Bu bir StringBuilder örneğidir");
            //Console.WriteLine(stringBuilder.ToString());

            //Metin Biçimlendirme ve Ekleme
            stringBuilder.AppendFormat("Merhaba, benim adım {0} ve {1} yaşındayım.", "Emin", 36);


            //StringBuilder'dan Metin Çıkarma ve Değiştirme

            //Metin Çıkarma
            stringBuilder.Remove(0, 3);
            //Console.WriteLine(stringBuilder.ToString());

            //Metin Değiştirme
            stringBuilder.Replace("Emin", "Veli");

            //StringBuilder'ı Temizleme
            stringBuilder.Clear();
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
