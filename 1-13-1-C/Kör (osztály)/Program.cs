using System;
using System.Collections.Generic;
using System.Linq;
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Kor k1 = new Kor();
            k1.setR(5);
            k1.setT();
            k1.setK();
            Korki(k1);

            Kor k2 = new Kor(6);
            k2.setT();
            k2.setK();
            Korki(k2);

            Console.ReadKey();
        }
        static private void Korki(Kor obj)
        {
            Console.WriteLine($"A négyszög kerülete: {obj.getK()}, területe: {obj.getT()}");
        }
    }
}
