using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Igazolatlan órák száma: ");
            int c = int.Parse(Console.ReadLine());
            if (c < 10)
            {
                if (c <= 2)
                {
                    Console.WriteLine("Jegy: 5");
                }
                else if (c >= 2 && c <= 4)
                {
                    Console.WriteLine("Jegy: 4");
                }
                else if (c >= 4 && c <= 6)
                {
                    Console.WriteLine("Jegy: 3");
                }
                else if (c >= 6 && c <= 10)
                {
                    Console.WriteLine("Jegy: 2");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Adja meg a tanuló születési dátumát: ");
                string s = Console.ReadLine();
                if (10 < c && c <= 20)
                {
                    Console.WriteLine("Figyelmeztetés! Igazolatlan órák száma: {0}", c);
                }
                else if (20 < c && c <= 30)
                {
                    Console.WriteLine("Osztályfönőki intő!  Igazolatlan órák száma: {0}", c);
                }
                else if (30 < c && c <= 40)
                {
                    Console.WriteLine("Igazgatói megrovás!  Igazolatlan órák száma: {0}", c);
                }
                else if (40 < c)
                {
                    Console.WriteLine("Felfüggesztés!  Igazolatlan órák száma: {0}", c);
                }
                Console.ReadKey();
            }
        }
    }
}

