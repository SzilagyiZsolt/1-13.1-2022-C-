using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            szamol(a);
            Console.ReadKey();
        }
        public static void szamol(int a)
        {
            if (a <= 50)
            {
                Console.WriteLine(a);
                a ++;
                szamol(a);
            }
        }
    }
}
