using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztály_gyakorlás
{
    class Téglalap
    {

        private int a;
        private int b;
        private int K;

        public void setK(int a, int b)
        {
            Convert.ToInt32(K = 2 * (a + b));
        }
        public int getK()
        {
            return K;
        }
        private int T;
        
        public void setT(int a, int b)
        {
            Convert.ToInt32(T = a*b);
        }
        public int getT()
        {
            return T;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Téglalap első = new Téglalap();
            első.setK(1, 2);
            Console.WriteLine("Kerülte: {0}", első.getK());
            Téglalap kettő = new Téglalap();
            kettő.setT(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Terület: {0}", kettő.getT());
            Console.ReadKey();
        }
    }
}
