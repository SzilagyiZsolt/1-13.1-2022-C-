using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarátokOOP
{
    internal class Program
    {
        private static Barátok barat;
        private static BaratScreen barat1;
        private static BaratPage barat2;
        private static BaratBuli barat3;
        static void Main(string[] args) // Statikus Main
        {
            barat2 = new BaratPage();
            barat2.Beolvas();
            barat2.Page();

            barat3 = new BaratBuli();
            barat3.Beolvas();
            barat3.bulizas();

            Console.ReadKey();
        }
        private static void vizsga(string t) // Visszatérési érték
        {

            if (barat.keres(t))
            {
                Console.WriteLine("Már van ilyen barátunk.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen barátunk.");
            }
        }
    }
}
