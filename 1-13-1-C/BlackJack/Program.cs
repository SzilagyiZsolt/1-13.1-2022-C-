using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        public static int egyenleg;
        public static string nev="";
        public static bool b=false;
        static void Shell()
        {
            string s;
            int cardplayer, cardCPU;

            if (!b)
            {
                Inic();
            }
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("|            BlackJack            |");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" ");

            cardplayer = Huzas(2, nev);
            cardCPU = Huzas(2, "CPU");

            Console.WriteLine("Akarod folytatni? (i/n)");
            s=Console.ReadLine().ToLower().Trim();
            if (s == "i")
            {
                Shell();
            }
        }

        static int Huzas(int v, string nev)
        {
            int card = 0;
            Random r = new Random();
            int[] k=new int[v];
            Console.Write("{0} kártáyái: " ,nev);
            for (int i = 0; i < v; i++)
            {
                k[i] = r.Next(2,12);
                Console.Write("{0}, ", k[i]);
                card+= k[i];
            }
            Console.WriteLine("Összesen: {0}", card);
            return card;
        }

        static void Inic()
        {
            while (nev == "")
            {
                Console.WriteLine("Add meg a neved: ");
                nev = Console.ReadLine();
            } 
            do
            {
                try
                {
                    Console.WriteLine("Add meg hogy mennyi pénzed van: ");
                    egyenleg = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hibás adat!");
                    Inic();
                }
            } while (egyenleg<1);
            
        }

        static void Main(string[] args)
        {
            Shell();

            Console.ReadKey();
        }
    }
}
