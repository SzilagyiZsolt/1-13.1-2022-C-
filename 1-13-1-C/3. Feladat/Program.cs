using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            
        Console.WriteLine("Add meg a hőmérsékletet: ");
            a = int.Parse(Console.ReadLine());
        Console.WriteLine("celsius vagy fahrenheit (c/f): ");
            if (Console.ReadKey(true).KeyChar == 'c')
                Console.WriteLine("Át akarod váltani fahrenheitba? (i/n) ");
                if (Console.ReadKey(true).KeyChar == 'i')
                    Console.WriteLine("Ennyi fahrenheitban: {0}", a * 1.8 + 32);
            else if (Console.ReadKey(true).KeyChar == 'f')
                Console.WriteLine("Át akarod váltani fahrenheitba? (i/n) ");
                if (Console.ReadKey(true).KeyChar == 'i')
                    Console.WriteLine("Ennyi celsiusban: {0}", (a - 32)*0.5556 );
            Console.ReadKey();

        }
    }
}
