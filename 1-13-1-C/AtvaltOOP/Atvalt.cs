using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    internal class Atvalt
    {
        public Atvalt() { }
        public void Bin()
        {
            try
            {
                Console.WriteLine("írj egy számot: ");
                int a = int.Parse(Console.ReadLine());
                List<int> Bin = new List<int>();
                while (a != 0)
                {
                    if (a % 2 == 0)
                    {
                        a = a / 2;
                        Bin.Add(0);
                    }
                    else
                    {
                        a = (a - 1) / 2;
                        Bin.Add(1);
                    }
                }
                Console.WriteLine("A számod kettes számrendszerben: ");
                for (int i = 0; i < Bin.Count; i++)
                {
                    Console.Write(Bin[Bin.Count - i - 1]);
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            catch
            {
                Console.WriteLine("Hibás bement! Próbáld meg újra");
            }
        }
        public void Dec()
        {
            Console.Write("írj egy bináris számot: ");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = 0;
                int c = 1;
                int d = 0;
                if (a != 0 || a != 1)
                {
                    Console.WriteLine("Hibás bement! Próbáld meg újra");
                }
                else
                {
                    while (a > 0)
                    {
                        d = a % 10;
                        a = a / 10;
                        b += d * c;
                        c = c * 2;
                    }
                    Console.WriteLine($"A számod Decimális értékben: {b} ");
                }
            }
            catch
            {
                Console.WriteLine("Hibás bement! Próbáld meg újra");
            }
        }
        public void Össz()
        {
            string a;
            bool b = true;
            while (b == true)
            {
                Console.WriteLine("Mit akarsz átváltani?");
                Console.WriteLine("Bináris számot, Decimálisba? (B)");
                Console.WriteLine("Decimális számot Binárisba? (D)");
                Console.WriteLine("Bezárás (Vége)");
                a = Console.ReadLine();
                if (a == "D")
                {
                    Bin();
                }
                else if (a == "B")
                {
                    Dec();
                }
                else if (a == "Vége")
                {
                    b = false;
                }
                else
                {
                    Console.WriteLine("Hibás bement! Próbáld meg újra");
                }
            }
        }
    }
}
