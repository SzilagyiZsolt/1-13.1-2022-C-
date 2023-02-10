using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, i;

            Console.WriteLine("Adj meg két számot:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (i = 0; i < 3; i++)
            {
                c = random.Next(a, b);
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}