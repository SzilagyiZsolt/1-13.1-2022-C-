using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Hány pontod lett? ");
            a = int.Parse(Console.ReadLine());
            if (0 <= a && a <= 49)
            {
                Console.WriteLine("A jegyed: 1");
            }
            else if (50 <= a && a <= 64)
            {
                Console.WriteLine("A jegyed: 2");
            }
            else if (65 <= a && a <= 79) 
            {
                Console.WriteLine("A jegyed: 3");
            }
            else if (80 <= a && a <= 89)
            {
                Console.WriteLine("A jegyed: 4");
            }
            else if (90 <= a && a <= 100)
            {
                Console.WriteLine("A jegyed: 5");
            }
            else 
            {
                Console.WriteLine("Hibás adat!");
            }
            Console.ReadKey();
        }
    }
}
