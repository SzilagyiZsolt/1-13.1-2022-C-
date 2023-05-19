using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;
            Random r = new Random();
            for (int i = 0; i < 67000; i++)
            {
                a = r.Next(1,100000);
                Console.WriteLine(a);
                if (a > b)
                {
                    b = a;
                }
            }
            Console.WriteLine("A legnagyobb szám: {0}",b);
            Console.ReadKey();
        }
    }
}
