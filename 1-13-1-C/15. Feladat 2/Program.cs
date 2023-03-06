using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, m, átló, szög;

            Console.WriteLine("Add meg hány szögű a szabályos alakzatod (3,4,5,6): ");
            szög=double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az oldal hosszát (cm): ");
            a = double.Parse(Console.ReadLine());

            if (szög == 3 )
            {
                Console.WriteLine("Az átló hossza: {0}cm", a);
            }
            else if (szög == 4 )
            {
                átló = a * Math.Sqrt(2);
                Console.WriteLine("Az átló hossza: {0}cm", átló);
            }
            else if (szög >= 5)
            {
                Console.WriteLine("Add meg a magasságot: ");
                m = double.Parse(Console.ReadLine());
                átló=Math.Pow(a, 2)+Math.Pow(m,2);
                Console.WriteLine("Az átló hossza: {0}cm", átló);
            }
            else
            {
                Console.WriteLine("Nincs ilyen alakzat!");
            }
            Console.ReadKey();
        }
    }
}
