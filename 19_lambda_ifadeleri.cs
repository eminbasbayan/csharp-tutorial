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
           List<int> sayilar = new List<int>() {1, 2, 3, 4, 5};

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            sayilar.ForEach(x => Console.WriteLine(x));
        }
    }
}
