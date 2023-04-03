using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbElem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;
            int paros = 0;
            int paratlan = 0;
            int szam;
            while (osszeg < 100)
            {
                Console.WriteLine("Adj meg egy számot:");
                szam = int.Parse(Console.ReadLine());
                if (szam % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }
                osszeg += szam;

            }
<<<<<<< HEAD
            Console.WriteLine("Páros szám {0}, Páratlan {1}", paros,paratlan);
=======
            Console.WriteLine("Páros szám {0}, Páratlan {1}", paros, paratlan);
>>>>>>> e02bcea01199af8e67f747da43ee22431d1e63a7
            Console.ReadKey();

        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> e02bcea01199af8e67f747da43ee22431d1e63a7
