using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            Console.WriteLine("írj be egy szót");
            a=Console.ReadLine();
            char[] d = new char[a.Length];
            Console.WriteLine("írj be egy másik szót");
            b = Console.ReadLine();
            char[] c = new char[b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                d[i] = a[i]; 
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[i] = b[i];
            }
            Console.ReadKey();
        }
    }
}
