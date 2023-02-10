using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float osszeg, d;
            int db;

            Console.WriteLine("Add meg a hogy hány dinnyét szeretnél venni:");
            db = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a dinnye átmérőjét (cm): ");
            d = float.Parse(Console.ReadLine());
            osszeg = (float)((((d * Math.PI) * 2) + 60) * db) / 100;
            Console.WriteLine("A dinnyének {0} méter szallagra lesz szükség!", osszeg);
            Console.ReadKey();
        }
    }
}