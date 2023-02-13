using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hossz = 10;
            int alsoHatar = 10,
                felsoHatar = 1000;
            int[] tomb=new int[hossz];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(alsoHatar,felsoHatar);
                Console.WriteLine(tomb[i]);
            }
            foreach (int i in tomb)
                Console.WriteLine(i);
            
            Console.ReadLine();
        }
    }
}
