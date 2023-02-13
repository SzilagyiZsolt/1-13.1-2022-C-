using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Ez egy szöveg";
            Console.WriteLine("Kiíratás tömb elemenként");
            Console.WriteLine(s);
            Console.Write("Kiiratás stringként:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }
            Console.ReadLine();
        }
    }
}
