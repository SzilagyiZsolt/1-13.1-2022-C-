using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("írj be egy 10 karakterből álló szót");
            s=Console.ReadLine();
            while (s.Length != 10)
            {
                Console.WriteLine("Ez nem 10 karakteres szó. írd be újra!");
                s = Console.ReadLine();
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.ReadKey();
        }
    }
}
