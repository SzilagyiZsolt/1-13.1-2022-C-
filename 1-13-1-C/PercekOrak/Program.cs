using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercekOrak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ora, perc, sec;
            Console.WriteLine("írd be az órát, percet, és a másodpercet: ");
            ora = int.Parse(Console.ReadLine());
            perc = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());
            DateTime a = new DateTime(2023,03,11,ora,perc,sec);
            Console.WriteLine("írd be az órát, percet, és a másodpercet: ");
            ora = int.Parse(Console.ReadLine());
            perc = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());
            DateTime b = new DateTime(2023, 03, 11, ora, perc, sec);
            if (a > b)
            {
                TimeSpan vég=a-b;
                Console.WriteLine(vég.ToString());
            }
            else
            {
                TimeSpan vég = b - a;
                Console.WriteLine(vég.ToString());
            }
            Console.ReadKey();
        }
    }
}
