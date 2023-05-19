using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("írj be egy páros számot!");
            a = int.Parse(Console.ReadLine());
            while (a % 2 != 0)
            {
                Console.WriteLine("Ez a szám nem páros. Próbáld meg újra!");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Jó");
            Console.ReadKey();
        }
    }
}
