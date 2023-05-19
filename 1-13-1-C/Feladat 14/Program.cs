using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("írj be 5 szót: ");
            for (int i = 0; i < 5; i++)
            {
                a=Console.ReadLine();
                if (a.Length % 2 == 1)
                {
                    Console.WriteLine("Ez a szó páratlan: {0}",a);
                }
            }

            Console.ReadKey();
        }
    }
}
