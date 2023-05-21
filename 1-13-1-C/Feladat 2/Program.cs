using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                a=r.Next(500,1000);
                if (a%2==0 || a % 3 == 0 || a % 4 == 0 || a % 5 == 0 || a % 6 == 0 || a % 7 == 0 || a % 8 == 0 || a % 9 == 0)
                {
                    i--;
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            Console.ReadKey();
        }
    }
}
