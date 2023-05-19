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
            int b=999999999;
            Console.WriteLine("írj be 5 számot: ");
            for (int i = 0; i < 5; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < b)
                {
                    b = a;
                }
            }
            Console.WriteLine("A legkissebb szám: {0}", b);
            Console.ReadKey();
        }
    }
}
