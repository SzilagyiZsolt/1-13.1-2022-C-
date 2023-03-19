using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHatOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Add meg a pontodat: ");
            a = int.Parse(Console.ReadLine());
            PontHatOOP P1 = new PontHatOOP();
            P1.setPont(a);
            P1.setJegy();

            Console.ReadKey();
        }
    }
}
