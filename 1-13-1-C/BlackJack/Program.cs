using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel.Design;

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

            do
            {
                if (!b)
                {
                    Inic();
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|            BlackJack            |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(" ");

                cardplayer = Huzas(2, nev);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine(" ");
                cardCPU = Huzas(2, "CPU");
                Console.WriteLine("\nÖsszesen: {0}", cardplayer);
                Console.WriteLine("Mennyi a tét?");
                int tet = int.Parse(Console.ReadLine());
                bool megall = false;
                string m = Men();
                if (m == "1")
                {
                    cardplayer += Huzas(1, nev);

                    Console.WriteLine("Összesen: {0}", cardplayer);
                }
                else if (m == "2")
                {
                    megall = true;
                }
                else if (m == "3")
                {
                    Lose(tet, nev);
                }
                while (cardplayer < 18)
                {
                    cardplayer += Huzas(1, "CPU");
                }
                if (cardplayer > 21 && cardCPU > 21)
                {
                    Console.WriteLine("Mindenki veszített");
                    Lose(tet, nev);
                }
                else if (cardCPU > 21)
                {
                    Console.WriteLine("Nyertél");
                    Win(tet, nev);
                }
                else if (cardplayer > 21)
                {
                    Console.WriteLine("Vesztettél");
                    Lose(tet, nev);
                }
                else if (cardplayer == cardCPU)
                {
                    Console.WriteLine("Döntetlen");
                }
                else if (cardplayer > cardCPU)
                {
                    Console.WriteLine("Nyertél");
                    Win(tet, nev);
                }
                else if (cardplayer < cardCPU)
                {
                    Console.WriteLine("Vesztettél");
                    Lose(tet, nev);
                }
                b = true;

                Console.WriteLine("Akarod folytatni? (i/n)");
                s = Console.ReadLine().ToLower().Trim();
                if (s == "i" && egyenleg>=1)
                {
                    Console.Clear();
                    Shell();
                }
            } while (egyenleg > 1 || s=="i");
        }
        static void Lose(int tet, string nv)
        {
            egyenleg-=(tet*2);
            Console.WriteLine("Vesztettél {0}! Egyenleged: {1}", nv, egyenleg);
        }
        static void Win(int tet, string nv)
        {
            egyenleg += (tet * 2);
            Console.WriteLine("Nyertél {0}! Egyenleged: {1}", nv, egyenleg);
        }
        static string Men()
        {
            string valasz="";
            do
            {
                Console.WriteLine("Mit akarsz?");
                Console.WriteLine("\t1 - még lapot");
                Console.WriteLine("\t2 - megállok");
                Console.WriteLine("\t3 - feladom");
                valasz = Console.ReadLine().Trim();
            } while (valasz != "1" && valasz != "2" && valasz != "3");
            return valasz;
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
            Console.WriteLine("Köszönöm a játékot!");

            Console.ReadKey();
        }
    }
}
