using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max, minIdx, maxIdx;

            //Tömb feltöltés
            Random r = new Random();
            min = 1000; 
            max = -1; 
            minIdx = 0; 
            maxIdx = 0; 
            int[] tomb = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                tomb[i] = r.Next(1001);
                Console.WriteLine(tomb[i]);
            }

            //Megoldás
            for (int i = 0; i < 10; ++i) 
            { 
                if (tomb[i] < min) 
                { 
                    min = tomb[i]; minIdx = i;
                } 
                else if (tomb[i] > max) 
                { 
                    max = tomb[i]; maxIdx = i;
                } 
            }
            //Kiírás
            Console.WriteLine("A tömb legkisebb száma: {0}. Indexe: {1}", min, minIdx);
            Console.WriteLine("A tömb legnagyobb száma: {0}. Indexe: {1}", max, maxIdx);
            Console.ReadKey();
        }
    }
}
