using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fájlolvasás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Név;
            Console.WriteLine("Fájlolvasás!");
            Név=Console.ReadLine();
            StreamReader Munkafüzet1 = File.OpenText(@Név);
            while (Munkafüzet1.Peek() != -1)
            {
                Console.WriteLine(Munkafüzet1.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
