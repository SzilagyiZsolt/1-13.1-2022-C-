using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tombos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Z");
            int z = int.Parse(Console.ReadLine());
            if (y>z)
            {
                Console.WriteLine("Csere volt");
                y = y + z;
                z = y - z;
                y = y - z;
            }
            int[] sz=new int[x];
            for (int i = 0; i < sz.Length; i++)
            {
                sz[i] = random.Next(y, z);
            }
            Console.WriteLine("Tömb feltöltve!");
            Console.WriteLine(" ");

            for (int i = 0; i < sz.Length; i++)
            {
                Console.Write("{0}, ", sz[i]);
            }
            Console.WriteLine("A tömbön belüli legnagyobb szám: {0}", Math.Max(sz[y], sz[z]));
            Console.WriteLine("A tömbön belüli legkisebb szám: {0}", Math.Min(sz[y], sz[z]));
            int osszeg = 0;
            for (int i = 0; i < sz.Length; i++)
            {
                osszeg=osszeg + sz[i];
            }
            Console.WriteLine("A tömb értéke: {0}", osszeg);

            Console.ReadKey();
        }
    }
}
