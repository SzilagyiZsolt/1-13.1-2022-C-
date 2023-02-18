using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborékrendezés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max;

            Random r = new Random();

            min = 1000;
            max = -1;
            int[] tomb = new int[20];
            for (int i = 0; i < 20; ++i)
            {
                tomb[i] = r.Next(1001);
            }
            for (int i = 0; i < tomb.Length - 1; ++i) 
            {
                for (int j = tomb.Length - 1; j > i; --j) 
                { 
                    if (tomb[j - 1] > tomb[j]) 
                    { 
                        int tmp = tomb[j]; 
                        tomb[j] = tomb[j - 1]; 
                        tomb[j - 1] = tmp; 
                    } 
                } 
            }
            for (int i = 1; i < tomb.Length; ++i) 
            { 
                int y = tomb[i]; 
                int j = i - 1; 
                while (j > -1 && y < tomb[j]) 
                {
                    tomb[j + 1] = tomb[j]; 
                    --j; 
                } 
                tomb[j + 1] = y;
                Console.WriteLine(tomb[i]);
            }
            Console.ReadKey();
        }
    }
}
