using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Program
    {
        enum ArabaModeli
        {
          BMW,
          Mercedes,
          Ferrari,
          Rover
        }
        static void Main(string[] args)
        {
            ArabaModeli benimArabam = ArabaModeli.Ferrari;

            if(benimArabam == ArabaModeli.Mercedes)
            {
                Console.WriteLine("Arabam BMW modelidir.");
            }

            switch(benimArabam)
            {
                case ArabaModeli.Ferrari:
                    Console.WriteLine("Arabam Ferrari modelidir.");
                    break;
                case ArabaModeli.Mercedes:
                    Console.WriteLine("Arabam Mercedes modelidir.");
                    break;
                case ArabaModeli.BMW:
                    Console.WriteLine("Arabam BMW modelidir.");
                    break;
            }
        }
    }
}
