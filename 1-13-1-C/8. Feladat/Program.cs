using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Elvetett búza mennyisége: ");
            a = int.Parse(Console.ReadLine());
            int[] nemrandom = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Random random = new Random();
            int b = random.Next(5, nemrandom.Length);
            int c=(b * a);
            Console.WriteLine(c);
            if (5 <= c && c <= 8)
            {
                Console.WriteLine("Átlag alatti");
            }
            else if (9 <= c && c <= 12)
            {
                Console.WriteLine("Átlagos év");
            }
            else if (13 <= c && c <= 15)
            {
                Console.WriteLine("Átlag feletti");
            }
            else
            {
                Console.WriteLine("Túl sok");
            }
            Console.ReadKey();
        }
    }
}
