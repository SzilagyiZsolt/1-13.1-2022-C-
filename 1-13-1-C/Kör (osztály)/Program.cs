using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Kor
    {
        //Osztályváltozók
        private double r;
        private double T;
        private double K;

        //Konstruktorok
        public Kor() { }
        public Kor(double r)
        {
            this.r = r;
        }
        //Metódusok
        public void setR(double r)
        {
            this.r = r;
        }
        public double getR()
        {
            return this.r;
        }

        public void setT()
        {
            this.T = Math.Pow(this.r, 2) * Math.PI;
        }
        public double getT()
        {
            return Math.Round(this.T,2);
        }

        public void setK()
        {
            this.K = 2 * Math.PI * this.r;
        }
        public double getK()
        {
            return Math.Round(this.K, 2);
        }
    }
    class Henger : Kor
    {
        //Osztályváltozók
        private double m;
        private double V;
        private double A;

        //Konstruktorok
        public Henger() : base() { }

        public Henger(double r, double m) : base(r) 
        {
            this.m = m;
        }
        public void setM(double m)
        {
            this.m = m;
        }
        public void setKor()
        {
            base.setK();
            base.setT();
        }
        public void setV()
        {
            this.V= base.getT()*this.m;
        }
        public void setA()
        {
            this.A = 2 * (base.getT()) +(base.getK() * this.m);

        }
        public double getV()
        {
            return this.V;
        }
        public double getA()
        {
            return this.A;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Henger Térfogata
            Henger h2 = new Henger(7, 9);
            h2.setKor();
            h2.setV();
            h2.setA();
            Console.WriteLine($"Felszín:{Math.Round(h2.getA(),2)} , Térfogat: {Math.Round(h2.getV(),2)}");
            Console.ReadKey();
        }


    }
}
