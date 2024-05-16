using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Program
    {
        struct Hesap
        {
            public int Id;
            public double Bakiye;
            public string Sahibi;
            public string Sehir;

            public void ParaEkle(double miktar)
            {
                Bakiye += miktar;
            }

            public void ParaCek(double miktar)
            {
                Bakiye -= miktar;
            }
        }

        static void Main(string[] args)
        {
           Hesap hesabim = new Hesap();
           hesabim.Id = 1;
           hesabim.Bakiye = 10000.50;
           hesabim.Sahibi = "Emin Başbayan";
           hesabim.Sehir = "İstanbul";

           hesabim.ParaEkle(1500);
           hesabim.ParaCek(250);
           Console.WriteLine(hesabim.Bakiye);
           
        }
    }
}
