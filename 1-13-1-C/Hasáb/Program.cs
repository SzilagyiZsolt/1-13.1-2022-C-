using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Négyszög
{
    class Hasáb
    {
        private double a;
        private double m;
        private double V;

        public Hasáb() { }
        public Hasáb(double a, double m)
        {
            this.a = a;
            this.m = m;
        }
        public void setA(double a)
        {
            this.a = a;
        }
        public void setM(double m)
        {
            this.m = m;
        }
        public double getA()
        {
            return this.a;
        }
        public double getM()
        {
            return this.m;
        }
        public void setV()
        {
            this.V = Math.Pow(this.a, 2) * m;
        }
        public double getV()
        {
            return this.V;
        }

    }
    class Negyszog
    {
        //Osztályváltozók
        private int a;
        private int b;
        private int T;
        private int K;

        //Konstruktorok
        public Negyszog() { }
        public Negyszog(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Negyszog(int a)
        {
            this.a = a;
            this.b = a;
        }

        //Metódusok
        public void setA(int a)
        {
            if (a > 1000)
            {
                Console.WriteLine("Az oldal nem lehet nagyobb mint 1000");
            }
            else
            {
                this.a = a;
            }
        }
        public void setB(int b)
        {
            this.b = b;
        }

        public int getA()
        {
            return this.a;
        }
        public int getB()
        {
            return this.b;
        }

        public void setT()
        {
            this.T = this.a * this.b;
        }
        public int getT()
        {
            return this.T;
        }

        public void setK()
        {
            this.K = 2 * (this.a + this.b);
        }
        public int getK()
        {
            return this.K;
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
            Negyszog n1 = new Negyszog();
            n1.setA(5);
            n1.setB(6);
            n1.setT();
            n1.setK();

            //2. példa
            Negyszog n2 = new Negyszog(6, 2);
            n2.setT();
            n2.setK();

            //3. Példa (Négyzet)
            Negyszog n3 = new Negyszog(6);
            n3.setT();
            n3.setK();

            //Hasáb Térfogata
            Hasáb h1 = new Hasáb();
            h1.setA(5);
            h1.setM(6);
            h1.setV();
            Kiir(h1);

            Hasáb h2 = new Hasáb(7, 9);
            h2.setV();
            Kiir(h2);
            Console.ReadKey();
        }
        static private void Kiir(Hasáb ter)
        {
            Console.WriteLine($"A hasáb térfogata: {ter.getV()}");
        }
    }
}