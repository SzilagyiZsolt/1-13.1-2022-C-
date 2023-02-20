using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf
{
    class Ember
    {
        public string Nev { get; set; }
        private string bemut = "Üdvözlöm a nevem: ";
        public Ember(string nev)
        {
            Nev = nev;
        }
        public string beszel()
        {
            return (bemut+Nev);
        }
    }
    class Ferfi : Ember
    {
        public int Kor { get; set; }
        public Ferfi(string nev, int kor): base(nev)
        {
            Kor = kor;
        }
    }
    class No : Ember
    {
        public string SzemSzin { get; set; }
        public No(string nev, string szemszin) :base(nev)
        {
            SzemSzin = szemszin;
        }
    }
    class Haz
    {
        private List<Ember> lakok = new List<Ember>();
        public void hazajon(Ember obj)
        {
            this.lakok.Add(obj);
        }
        public void csenget()
        {
            int i;
            Random random = new Random();
            //Ha vannak a házban, akkor véletlenszerűen kijön valaki és beszél
            if (lakok.Count > 0)
            {
                i=random.Next(0,lakok.Count-1);
                Console.WriteLine(lakok[1].beszel());
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feladat:
            //Ház, vannak lakók: nők és férfiak, ha becsenget valaki nő vagy férfi nyit ajtót
            //polimorfizmus példa: mindegy hogy nő vagy férfi megy kinyitni ugyanazt a metódust használjuk

            //Felépítjük a házat
            Haz otthon = new Haz();

            //Példányosítjuk a szereplőket
            //Hölgyek
            No eva = new No("Éva", "zöld");
            No kati = new No("Kati", "barna");
            No sari = new No("Sári", "kék");
            No zsuzsi = new No("Zsuzsi", "piros");

            //Férfiak
            Ferfi adam = new Ferfi("Ádám", 26);
            Ferfi dani = new Ferfi("Dani", 29);
            Ferfi gergo = new Ferfi("Gergő", 33);
            Ferfi attila = new Ferfi("Attila", 19);

            //Beköltöztetjük a szereplőket a házba
            if (eva is Ember) otthon.hazajon(eva as Ember);
            otthon.hazajon((Ember)kati);
            otthon.hazajon((Ember)sari);
            otthon.hazajon((Ember)zsuzsi);
            otthon.hazajon((Ember)adam);
            otthon.hazajon((Ember)gergo);
            otthon.hazajon((Ember)attila);

            //Jönnek idegenek és csengetnek
            bool tovabb = true;
            do
            {
                otthon.csenget();
                tovabb=(Console.ReadLine()==String.Empty)?
                    false: true;
            } while (tovabb);
            Console.ReadKey();
        }
    }
}
