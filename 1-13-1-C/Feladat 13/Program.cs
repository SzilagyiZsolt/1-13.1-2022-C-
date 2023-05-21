using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            Console.WriteLine("írj be egy szót: ");
            a=Console.ReadLine();
            b = a.Replace("e", "a");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
