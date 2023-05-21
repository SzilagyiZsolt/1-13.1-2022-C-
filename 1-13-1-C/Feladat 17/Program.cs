using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            using (StreamWriter lotto = new StreamWriter("C:\\Users\\zsolt\\Downloads\\1-13.1-2022-C-\\1-13-1-C\\Feladat 17\\bin\\Debug\\lotto.txt"))
            {
                Console.WriteLine("Húzz öt számot 1-90-ig: ");
                int[] tomb = new int[5];
                for (int i = 0; i < tomb.Length; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    if(a>0 && a <= 90)
                    {
                        
                        if (tomb[0]==a || tomb[1]==a || tomb[2] == a || tomb[3] == a || tomb[4]==a)
                        {
                            if (tomb[0] == a)
                            {
                                tomb[0] = a;
                                i--;
                            }
                            else if (tomb[1] == a)
                            {
                                tomb[1] = a;
                                i--;
                            }
                            else if (tomb[2] == a)
                            {
                                tomb[2] = a;
                                i--;
                            }
                            else if (tomb[3] == a)
                            {
                                tomb[3] = a;
                                i--;
                            }
                            else if (tomb[4] == a)
                            {
                                tomb[4] = a;
                                i--;
                            }
                        }
                        else
                        {
                            tomb[i] = a;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem megfelelő a szám!");
                        i--;
                    }
                }
                for (int i = 0; i < tomb.Length; i++)
                {
                    lotto.WriteLine(tomb[i]);
                }
                
            }
            Console.ReadKey();
        }
    }
}
