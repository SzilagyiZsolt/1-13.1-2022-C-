using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b=0;
            Random r = new Random();
            for (int i = 0; i < 345000; i++)
            {
                a = r.Next(1,10000);
                if (a %2== 0)
                {
                    b++;
                }
            }
            Console.WriteLine("{0} db páros szám van!", b);
            Console.ReadKey();
        }
    }
}
