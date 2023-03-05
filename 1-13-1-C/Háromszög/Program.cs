using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Háromszög
{
    class Háromszög
    {
        //Osztályváltozók
        private double a;
        private double b;
        private double c;
        private double m;
        private double T;
        private double K;

        //Konstruktorok
        public Háromszög() { }
        public Háromszög(double a, double b, double c, double m)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.m = m;
        }

        //Metódusok
        public void setA(double a)
        {
            this.a = a;
        }
        public void setB(double b)
        {
            this.b = b;
        }
        public void setC(double c)
        {
            this.c = c;
        }
        public void setM(double m)
        {
            this.m = m;
        }

        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return this.b;
        }
        public double getC()
        {
            return this.c;
        }
        public double getM()
        {
            return this.m;
        }
        public void setT()
        {
            this.T = (this.a * this.m) / 2;
        }
        public double getT()
        {
            return this.T;
        }

        public void setK()
        {
            this.K = this.a + this.b + this.c;
        }
        public double getK()
        {
            return this.K;
        }
    }
    class Hasáb: Háromszög
    {
        private double a;
        private double m;
        private double V;
        private double F;

        public Hasáb() { }
        public Hasáb(double m)
        {
            this.m = m;
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public void setM(double m)
        {
            this.m = m;
        }
        public double getA()
        {
            return a;
        }
        public double getM()
        {
            return this.m;
        }
        public void setV()
        {
            this.V = (Math.Sqrt(3) / 4) * Math.Pow(this.a,2) * this.m;
        }
        public double getV()
        {
            return this.V;
        }
        public void setF()
        {
            this.F =2 * (Math.Sqrt(3) / 4) * Math.Pow(this.a,2)+ 3 * this.a * this.m;
        }
        public double getF()
        {
            return this.F;
        }

    }
    internal class Program
    {
        enum nyom
        {
            oldal, KT
        }
        static void Main(string[] args)
        {
            //1. példa
            Háromszög h1 = new Háromszög();
            h1.setA(6);
            h1.setB(5);
            h1.setC(9);
            h1.setM(4);
            h1.setT();
            h1.setK();
            Kiir(h1);

            //2. példa
            Háromszög h2 = new Háromszög(6, 5, 9, 4);
            h2.setT();
            h2.setK();
            Kiir(h2);

            //3. Példa
            Hasáb h3 = new Hasáb();
            h3.setA(6);
            h3.setM(5);
            h3.setF();
            h3.setV();
            Console.WriteLine("A hasáb felszíne: {0}, térfogata: {1}", h3.getF(), h3.getV());
            Console.ReadKey();
        }
        static private void Kiir(Háromszög ter)
        {
            Console.WriteLine("A háromszög kerülete: {0}, területe: {1}", ter.getK(), ter.getT());
        }
    }
}