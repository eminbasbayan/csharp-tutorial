using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Program
    {

        public int Topla(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int sonuc = program.Topla(5, 7);
            Console.WriteLine(sonuc);

            void Yazdir(string mesaj){
                Console.WriteLine(mesaj);
            }

            Yazdir("Emin Başbayan");
        }
    }
}
