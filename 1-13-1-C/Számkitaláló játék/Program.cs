using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace második_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Adj meg egy számot: ");
            a = int.Parse(Console.ReadLine());
            if (a % 3 == 0) { 
                Console.WriteLine("A számod amit megadtál osztható hárommal");
            }
            if (a % 4 == 0)
            {
                Console.WriteLine("A számod amit megadtál osztható néggyel");
            }
            if (a % 9 == 0)
            {
                Console.WriteLine("A számod amit megadtál osztható kilenccel");
            }
            Console.ReadKey();
        }
    }
}
