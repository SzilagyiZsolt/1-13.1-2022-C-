using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;
            string s;
            int b;
            Random random= new Random();
            do
            {
                Console.WriteLine("írj egy kérdést: ");
                s = Console.ReadLine();
                a = s.Last<char>();
                if (a == '?')
                {
                    b = random.Next(1, 2);
                    if (b == 1)
                    {
                        Console.WriteLine("Igen");
                    }
                    else
                    {
                        Console.WriteLine("Nem");
                    }
                }
            } while (a != '?');
            Console.ReadKey();
        }
    }
}
