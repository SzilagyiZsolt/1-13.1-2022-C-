using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztály
{
    class Kutya
    {
        //properties/osztályváltozók/osztály tagjai
        private string nev;
        private int gender;
        public string Fajta 
        { 
            get; set; 
        }
        public void setGender(string gender)
        {
            switch (gender)
            {
                case "Kan":
                    this.gender = 1;
                    break;
                case "Szuka":
                    this.gender = 2;
                    break;
                default: 
                    this.gender = 3;
                    break;
            }
        }
        public string getGender()
        {
            switch (this.gender)
            {
                case 1:
                    return "Kan";
                case 2:
                    return "Szuka";
                default:
                    return "Semleges";
            }
        }


        //Konstruktor
        public Kutya(string nev)
        {
            this.nev = nev;
        }
        public Kutya()
        {

        }
        public string getNEV() => this.nev; //Lambda operátor felírás
        public void setNEV(string nev) 
        {
            this.nev = nev; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya kutya1 = new Kutya();
            kutya1.setNEV("Bodri");
            Console.WriteLine("A kutya1 neve: {0}", kutya1.getNEV());
            Kutya zeusz=new Kutya("Zeusz");
            Console.WriteLine("A második kutya neve: {0}", zeusz.getNEV());
            zeusz.Fajta="Németjuhász";
            Console.WriteLine("A Zeusz fajtája: {0}", zeusz.Fajta);
            Console.ReadKey();
        }
    }
}
