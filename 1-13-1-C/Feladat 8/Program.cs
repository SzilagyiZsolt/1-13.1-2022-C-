using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            int c;
            Console.WriteLine("Add meg a neved: ");
            a= Console.ReadLine();
            Console.WriteLine("Add meg a címed: ");
            b = Console.ReadLine();
            Console.WriteLine("Add meg a korod: ");
            c = int.Parse(Console.ReadLine());
            File.WriteAllText("adat.txt", a + "\n" + b + "\n" + c);
            Console.ReadKey();
        }
    }
}
