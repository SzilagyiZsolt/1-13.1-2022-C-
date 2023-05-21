using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a=2;
            szamol(a);
            Console.ReadKey();
        }
        public static void szamol(int a)
        {
            if (a <= 40)
            {
                Console.WriteLine(a);
                a +=2;
                szamol(a);
            }
        }
    }
}
