using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborékrendezés_gyakorlás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            int max = 0;
            int i;

            Console.WriteLine("0 Vége az adatbevitelnek ");

            do
            {
                Console.WriteLine("Kérem a/az "+ max + ". adatot: ");
                tomb[max] = Convert.ToInt32( Console.ReadLine());
                max++;
            } while (tomb[max-1]!=0);
            max--;

            Boolean voltcsere;
            do
            {
                voltcsere = false;
                for (i = 0; i < max-1; i++)
                {
                    if (tomb[i] > tomb[i + 1])
                    {
                        int tmp = tomb[i];
                        tomb[i] = tomb[i + 1];
                        tomb[i + 1] = tmp;
                        voltcsere = true;
                    }
                }
            } while (voltcsere);

            for (i = 0; i < max; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.ReadKey();
            return;
        }
    }
}
