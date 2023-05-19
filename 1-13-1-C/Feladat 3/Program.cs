using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                a = r.Next();
            }
            Console.ReadKey();
        }
    }
}
