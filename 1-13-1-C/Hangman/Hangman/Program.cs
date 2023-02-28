using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman
{
    internal class Program
    {
        public static bool bennevot=false;
        public static List<string> votma = new List<string>();
        public static int leh = 0;

        static bool VaneFile(string fajl)
        {
            return File.Exists(fajl);
        }

        static void Jatek(string[] szav)
        {
            Random rnd = new Random();
            string szo = szav[rnd.Next(0,szav.Length)];
            string rzt = "";
            string tipp = "";
            
            while (true)
            {
                Console.Write("Tipp: ");
                tipp = Console.ReadLine();
                rzt = Rajz(szo, rzt, tipp);
                Console.WriteLine(rzt);
                Console.WriteLine("Még {0} leheőség van!", leh);
            }
        }

        static string Rajz(string szo, string rzt,string tipp)
        {
            if (rzt == "") {
                for (int i = 0; i < szo.Length; i++)
                {
                    rzt = rzt + "_ ";
                }
            }
            else
            {
                votma.Add(tipp);
                if (szo.Contains(tipp))
                {
                    bennevot = true;
                    char t = Convert.ToChar(tipp);
                    string[] s1=rzt.Split(' ');
                    for (int i = 0; i < szo.Length; i++)
                    {                        
                        if (szo[i]==t)
                        {
                            s1[i] = tipp;
                        }
                    }
                    rzt = "";
                    for (int i = 0; i < s1.Length; i++)
                    {
                        rzt = rzt + s1[i] + " ";
                    }
                }
                else
                {
                    bennevot = false;
                    leh--;
                }
            }
            return rzt;
        }
        
        static void Shell()
        {
            //Fájl létezés vizsgálat
            if (VaneFile("szavak.txt"))
            {
                Console.WriteLine("A fájl létzik!");
            }
            else
            {
                Console.WriteLine("A fájl nem létezik!");
            }
            string[] szavak = File.ReadAllLines("szavak.txt");
            Console.WriteLine("Bevettem {0:0,00} darab szót, mehet a játék!",szavak.Length);
            leh = 10;
            Jatek(szavak);

            Console.ReadKey();
            Shell();
        }
        
        static void Main(string[] args)
        {
            Shell();
        }
    }
}
