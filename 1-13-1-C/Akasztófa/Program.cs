using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace Akasztófa
{
    internal class Program
    {
        public static bool bennevot=false;
        public static List<string> voltma=new List<string>();
        static bool VaneFile(string fajl)
        {
            bool b = false;
            if (File.Exists(fajl))
            {
                b = true;
            }
            return b;
        }

        static void Jatek(int leh, string[] szav)
        {
            Random rnd = new Random();
            string szo=szav[rnd.Next(0, szav.Length)];
            Console.WriteLine(szo);
            string rzt = "";
            string tipp = "";
            Console.WriteLine(Rajz(szo, rzt, tipp));
            Console.WriteLine(rzt);
            while (true)
            {
                Console.Write("Tipp: ");
                tipp = Console.ReadLine();
                rzt = Rajz(szo, rzt, tipp);
                Console.WriteLine(rzt);
            }
            
        }

        static string Rajz(string szo, string rzt, string tipp)
        {
            if (rzt == ""){
                for(int i=0; i<szo.Length; i++)
                {
                    rzt = rzt + "_ ";
                }
            }
            else
            {
                voltma.Add(tipp);
                if (szo.Contains(tipp))
                {
                    bennevot=true;
                    char t = Convert.ToChar(tipp);
                    string[] s1 = rzt.Split(' ');
                    for (int i = 0; i < szo.Length; i++)
                    {
                        if (szo[i] == t)
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
                }
            }
            return rzt;
        }


        //A fájl létezésének vizsgálata
        static void Shell()
        {
            if (VaneFile("szavak.txt"))
            {
                Console.WriteLine("A file létezik!");
            }
            else
            {
                Console.WriteLine("A file nem létezik!");
            }
            string[] szavak = File.ReadAllLines("szavak.txt");
            Console.WriteLine("Bevettem {0:0,00} darab szót, mehet a játék", szavak.Length);
            Jatek(10, szavak);

            Console.ReadKey();
            Shell();
        }

        static void Main(string[] args)
        {
            Shell();
        }
    }
}
