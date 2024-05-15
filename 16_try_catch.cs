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
            
            try
            {
                int sayi = 10;
                int sonuc = sayi / 10;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı!");
            }
        }
    }
}
