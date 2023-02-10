using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, m, átló, szög, r, R;

            Console.WriteLine("Add meg hány szögű a szabályos alakzatod (3,4,5,6): ");
            szög = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az oldal hosszát (cm): ");
            a = double.Parse(Console.ReadLine());

            if (szög == 3)
            {
                Console.WriteLine("Az átló hossza: {0}cm", a);
                Console.WriteLine("Add meg a magasságot (cm): ");
                m = double.Parse(Console.ReadLine());
                r=a * (Math.Sqrt(3)/6);
                Console.WriteLine("A beírható kör sugara: {0}cm", r);
                R = m - r;
                Console.WriteLine("A körülírt kör sugara: {0}cm", R);
            }
            else if (szög == 4)
            {
                átló = a * Math.Sqrt(2);
                Console.WriteLine("Az átló hossza: {0}cm", átló);
                r = a / 2;
                Console.WriteLine("A beírható kör sugara: {0}cm", r);
                R = (Math.Sqrt(2) * a) / 2;
                Console.WriteLine("A körülírt kör sugara: {0}cm", R);
            }
            else if (szög == 5)
            {
                Console.WriteLine("Add meg a magasságot (cm): ");
                m = double.Parse(Console.ReadLine());
                átló = Math.Pow(a, 2) + Math.Pow(m, 2);
                Console.WriteLine("Az átló hossza: {0}cm", átló);
                r = 5 / Math.Tan(36);
                Console.WriteLine("A beírható kör sugara: {0}cm", r);
                R = 5 / Math.Sin(36);
                Console.WriteLine("A körülírt kör sugara: {0}cm", R);
            }
            else if (szög == 6)
            {
                Console.WriteLine("Add meg a magasságot (cm): ");
                m = double.Parse(Console.ReadLine());
                átló = Math.Pow(a, 2) + Math.Pow(m, 2);
                Console.WriteLine("Az átló hossza: {0}cm", átló);
                r = (a * Math.Sqrt(3)) / 2;
                Console.WriteLine("A beírható kör sugara: {0}cm", r);
                R = a;
                Console.WriteLine("A körülírt kör sugara: {0}cm", R);
            }
            else if (szög <= 2)
            {
                Console.WriteLine("Nincs ilyen alakzat!");
            }
            Console.ReadKey();
        }
    }
}