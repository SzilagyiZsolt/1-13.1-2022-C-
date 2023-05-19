using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarátokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] t = {"teszt aranka","1991.11.12","N","4"};

            Barátok barat =new Barátok();
            BaratScreen barat1 =new BaratScreen();
            barat.Beolvas();
            vizsga(t[0]);

            barat.InsertBarat(t);
            vizsga(t[0]);
            barat.delete(t[0]);
            vizsga(t[0]);
            barat.kiir();
            vizsga(t[0]);
            barat1.listazas();
            Console.ReadKey();
        }
        public static void vizsga(string t)
        {
            Barátok barat = new Barátok();
            if (barat.keres(t))
            {
                Console.WriteLine("Már van ilyen barátunk");
            }
            else
            {
                Console.WriteLine("Nincs ilyen barátunk");
            }
        }
    }
}
