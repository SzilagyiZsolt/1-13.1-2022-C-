using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kivétel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam;
            bool a = true;
            while (a)
            {
                Console.WriteLine("\nSaját Hiba objektummal kivételezés\nAdjon meg egy számot!");
                try
                {
                    szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt szám: {0}", szam);
                }
                catch
                {
                    a = false;
                    Console.WriteLine("Karakter adtál meg szám helyett");
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
