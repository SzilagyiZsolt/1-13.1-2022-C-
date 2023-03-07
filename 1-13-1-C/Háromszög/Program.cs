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
        private double s;
        private double T;
        private double K;

        //Konstruktorok
        public Háromszög() { }
        public Háromszög(double a, double b, double c, double s)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.s = s;
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
        public void setS(double s)
        {
            this.s = (a+b+c)/2;
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
        public double getS()
        {
            return this.s;
        }
        public void setT()
        {
            this.T = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
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
        public double m;
        private double V;
        private double F;

        public Hasáb() : base() { }
        public Hasáb(double m, double s, double a, double b, double c) : base(a,b,c,s)
        {
            this.m = m;
        }
        public void setHátomszög()
        {
            base.setK();
            base.setT();
        }
        public void setV()
        {
            this.V = base.getT()* m;
        }
        public double getV()
        {
            return this.V;
        }
        public void setF()
        {
            this.F = 2 * base.getT() + base.getK() * 2;
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