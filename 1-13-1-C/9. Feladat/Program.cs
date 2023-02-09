using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Add meg a CO2-t: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg O2-t: ");
            b = float.Parse(Console.ReadLine());
            c = (a / b);
            if (0.8 < c)
            {
                Console.WriteLine("Szénhidrátokból nyeri");
            }
            else if (0.8 > c)
            {
                Console.WriteLine("Zsírból nyeri");
            }
            else
            {
                Console.WriteLine("Tökéletes");
            }
            Console.ReadKey();
        }
    }
}
