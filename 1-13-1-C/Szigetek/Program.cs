using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islandCount, maxIslandLength, i, tmp, tomb;
            //tömb feltöltés
            tomb = 50;
            Random r = new Random();
            int[] data = new int[tomb];
            for (i = 0; i < 50; ++i)
            {
                data[i] = r.Next(2);
                Console.WriteLine(data[i]);
            }
            //Kezdő értékek
            islandCount = 0; 
            maxIslandLength = 0; 
            i = 0; 

            //Megoldás
            while (i < data.Length)
            { 
                if (data[i].ToString() == "1") 
                { 
                    ++islandCount; 
                    tmp = 0; 
                    while (i < data.Length && data[i].ToString() == "1") 
                    { 
                        ++i; ++tmp; 
                    } 
                    if (tmp > maxIslandLength) 
                    { 
                        maxIslandLength = tmp; 
                    }
                    
                } 
                else 
                { 
                    ++i; 
                }
            }
            //Kiírás
            Console.WriteLine("A leghosszabb egybefüggő szárazföld hossza: {0}", maxIslandLength);
            Console.WriteLine("Szigetek száma: {0}", islandCount);
            Console.ReadKey();
        }
    }
}
