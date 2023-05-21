using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter szamok = new StreamWriter("C:\\Users\\zsolt\\Downloads\\1-13.1-2022-C-\\1-13-1-C\\Feladat 18\\bin\\Debug\\szamok.txt"))
            {
                for (int i = 3; i <= 300; i++)
                {
                    if(i%3==0)
                    {
                        szamok.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
