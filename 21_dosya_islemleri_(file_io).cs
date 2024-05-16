using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter write = new StreamWriter("ornek.txt"))
            //{
            //    write.WriteLine("Hello World!");
            //}

            using (StreamReader reader = new StreamReader("C:\\Users\\eminb\\source\\repos\\CSharpTutorial\\CSharpTutorial\\bin\\Debug\\ornek.txt"))
            {
                string icerik = reader.ReadToEnd();
                Console.WriteLine(icerik);
            }
        }
    }
}
