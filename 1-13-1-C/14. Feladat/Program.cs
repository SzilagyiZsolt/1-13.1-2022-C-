using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, T, cs, TT;
            Console.WriteLine("Add meg a szoba szélességét: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a szoba magasságát: ");
            b = float.Parse(Console.ReadLine());
            T = a * b;
            cs = (float)(T / (0.2 * 0.2));
            TT = (float)(cs * 1.1);
            Console.WriteLine("{0} csempére lesz szükség!", TT);
            Console.ReadKey();
        }
    }
}
