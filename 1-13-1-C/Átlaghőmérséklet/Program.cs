using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Átlaghőmérséklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max, összeg;
            double átlag;

            Random r = new Random();
            min = 40;
            max = -20;
            összeg = 0;
            int[] tomb = new int[360];
            double[] átlagok = new double[12];

            for (int i=1; i < tomb.Length; ++i)
            {
                tomb[i] = r.Next(max,min);

                if (i <= 30)
                {
                    Console.WriteLine("Az év {0}. napján, Januárban a hőmérséklet: {1}", i ,tomb[i]);
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 30)
                    {
                        Console.WriteLine("Januárban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                        
                    }
                }
                if (30 < i && i <= 60)
                {
                    Console.WriteLine("Az év {0}. napján, Februárban a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 31)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 60)
                    {
                        Console.WriteLine("Februárban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (60 < i && i <= 90)
                {
                    Console.WriteLine("Az év {0}. napján, Márciusban a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 61)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 90)
                    {
                        Console.WriteLine("Márciusban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (90 < i && i <= 120)
                {
                    Console.WriteLine("Az év {0}. napján, Áprilisban a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 91)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 120)
                    {
                        Console.WriteLine("Áprilisban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (120 < i && i <= 150)
                {
                    Console.WriteLine("Az év {0}. napján, Májusban a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 121)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 150)
                    {
                        Console.WriteLine("Májusban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (150 < i && i <= 180)
                {
                    Console.WriteLine("Az év {0}. napján, Júniusban a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 151)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 180)
                    {
                        Console.WriteLine("Júniusban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (180 < i && i <= 210)
                {
                    Console.WriteLine("Az év {0}. napján, Júliusban a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 181)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 210)
                    {
                        Console.WriteLine("Júliusban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (210 < i && i <= 240)
                {
                    Console.WriteLine("Az év {0}. napján, Augusztusban a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 211)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 240)
                    {
                        Console.WriteLine("Augusztusban az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (240 < i && i <= 270)
                {
                    Console.WriteLine("Az év {0}. napján, Szeptemberben a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 241)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 270)
                    {
                        Console.WriteLine("Szeptemberben az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (270 < i && i <= 300)
                {
                    Console.WriteLine("Az év {0}. napján, Októberben a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 271)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 300)
                    {
                        Console.WriteLine("Októberben az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (300 < i && i <= 330)
                {
                    Console.WriteLine("Az év {0}. napján, Novemberben a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 301)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 330)
                    {
                        Console.WriteLine("Novemberben az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
                if (330 < i && i <= 360)
                {
                    Console.WriteLine("Az év {0}. napján, Decemberben a hőmérséklet: {1}", i, tomb[i]);
                    if (i == 331)
                    {
                        összeg = 0;
                    }
                    összeg = összeg + tomb[i];
                    átlag = összeg / 30;
                    if (i == 360)
                    {
                        Console.WriteLine("Decemberben az átlaghőmérséklet: {0}", átlag);
                        Console.WriteLine(" ");
                    }
                }
            }

            for (int j = 0; j < tomb.Length; j++)
            {
                if (tomb[j] < min)
                {
                    min = tomb[j];
                }
                else if (tomb[j] > max)
                {
                    max = tomb[j];
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Az év leghidegebb napja: {0}.", min);
            Console.WriteLine("Az év legmelegebb napja: {0}.", max);
            Console.ReadKey();
        }
    }
}
