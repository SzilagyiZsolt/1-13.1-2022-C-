using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _12.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c, i;

            Console.WriteLine("Adj meg egy összeget:");
            a = Convert.ToInt32(Console.ReadLine());
            c = 0;
            int[] b = new int[] { 10, 20, 50, 100, 200 };

            for (i = b.Length - 1; i >= 0; i--)
            {
                while (a >= b[i])
                {
                    a -= b[i];
                    c++;
                }
            }

            Console.WriteLine("Az összeg a lehető legkevesebb pénzérméből összeállítva: {0} db.", c);
            Console.ReadLine();
        }
    }
}