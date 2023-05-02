using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw=new StreamWriter("adat.txt");
            Random random = new Random();
            for (int i = 0; i < 12500; i++)
            {
                sw.WriteLine(random.Next(1,12500));
            }
            sw.Close();

            string[] t = File.ReadAllLines("adat.txt");
            int[] ts = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                ts[i] = Convert.ToInt32(t[i]);
            }

            Console.ReadKey();
        }
    }
}
