using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool False=true;
            try
            {
                Console.WriteLine("Adj egy számot: ");
                a=int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ez nem szám!");
                False=false;
            }
            
            if (False)
            {
                Console.WriteLine("Igaz");
            }
            else
            {
                Console.WriteLine("Nem volt igaz");
                Console.WriteLine("És még rossz is");
            }
            Console.ReadLine();
        }
    }
}
