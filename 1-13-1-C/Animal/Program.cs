using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    {
        enum Animal { Macska=2, Kutya=5, Tigris, Farkas };
        static void Main(string[] args)
        {
            Animal a=Animal.Farkas;
            Animal b=Animal.Macska;

            // Értéktípusú változók nulla értéke
            int c = 0;
            string s ="";

            //Nullázható értéktípusú változó
            int? x = null;

            if(a!=b)
            {
                Console.WriteLine("A Farkas nem Macska");
            }
            Console.WriteLine("A macska indexe: {0}", (int)Animal.Macska);
            Console.WriteLine("A kutya indexe: {0}", (int)Animal.Kutya);
            Console.WriteLine("A farkas indexe: {0}", (int)Animal.Farkas);
            Console.ReadKey();
        }
    }
}
