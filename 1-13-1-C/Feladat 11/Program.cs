using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b=int.MaxValue;
            Console.WriteLine("írj be 5 számot: ");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a < b)
                    {
                        b = a;
                    }
                }
                catch
                {
                    Console.WriteLine("Ez nem szám!");
                    Console.WriteLine("írj be 5 számot: ");
                    i--;
                }
            }
            Console.WriteLine("A legkisebb szám: {0}", b);
            Console.ReadKey();
        }
    }
}