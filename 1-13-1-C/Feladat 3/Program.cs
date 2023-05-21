using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b=0;
            int c=0;
            int d = 0;
            int e = 0;
            int f = 0;
            int[] tomb= new int[5];
            Random r = new Random();
            for (int i = 0;i < tomb.Length; i++)
            {
                a = r.Next(1, 6);
                if (a == 1)
                {
                    tomb[0] = a;
                    if (b>=1)
                    {
                        i--;
                    }
                    b++;
                }
                else if (a == 2)
                {
                    tomb[1] = a;
                    if (c >= 1)
                    {
                        i--;
                    }
                    c++;
                }
                else if (a == 3 )
                {
                    tomb[2] = a;
                    if (d >= 1)
                    {
                        i--;
                    }
                    d++;
                }
                else if (a == 4)
                {
                    tomb[3] = a;
                    if (e >= 1)
                    {
                        i--;
                    }
                    e++;
                }
                else if (a == 5)
                {
                    tomb[4] = a;
                    if (f >= 1)
                    {
                        i--;
                    }
                    f++;
                }
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
