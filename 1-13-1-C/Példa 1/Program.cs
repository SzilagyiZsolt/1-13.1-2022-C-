using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Példa_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c;
            int[] tomb=new int[10];
            Console.WriteLine("Érdemjegy átlagszámító program");
            for (int i = 0; i < tomb.Length; i++)
            {
                try
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.WriteLine("írd be az érdemjegyed: ");
                        a = int.Parse(Console.ReadLine());
                        if(a<1 || a > 5)
                        {
                            Console.WriteLine("Nincs ilyen érdemjegy");
                            break;
                        }
                        tomb[j] = a + tomb[j];
                    }
                }
                catch
                {
                    Console.WriteLine("Hibás adat!");
                }
            }
            b = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                b = b + tomb[i];
            }
            c = b / tomb.Length;
            Console.WriteLine("Az érdemjegyed átlaga: {0}", c);
            Console.ReadKey();
        }
    }
}
