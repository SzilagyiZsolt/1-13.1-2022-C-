using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt2
{
    internal class Program
    {
        static double Szam(int osz)
        {
            Console.WriteLine(osz);
            return 0.0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg hány oldal: ");
            double ered = Szam(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
