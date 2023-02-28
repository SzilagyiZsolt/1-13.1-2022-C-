using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Négyszög
{
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
    class Hasáb : Negyszog
    {
        //Osztályváltozók
        private int m;
        private double V;
        private double F;

        //Konstruktorok
        public Hasáb(): base() { }
        public Hasáb(int a, int b, int m) : base(a,b)
        {
            this.m = m;
        }

        //Egyéb metódusok
        public void setM(int m)
        {
            this.m = m;
        }

        //Kiszámíttatom a szülő osztályban az adatokat
        public void setNegyszog()
        {
            base.setK();
            base.setT();
        }

        //A hasáb adatainak kiszámítása
        public void setV()
        {
            this.V = base.getT() * this.m;
        }
        public void setF()
        {
            this.F = base.getK() * this.m+2* base.getT();
        }

        //A hasáb adatainak lekérdezése
        public double getV()
        {
            return this.V;
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
            oldal, KT, osszes
        }
        static void Main(string[] args)
        {
            //1. példa
            Negyszog n1 = new Negyszog();

            Kiir(n1, nyom.oldal);

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
            Hasáb h2 = new Hasáb(7, 7, 9);
            h2.setNegyszog();
            h2.setV();
            h2.setF();
            Console.WriteLine($"Felszín:{h2.getF()}, Térfogat: {h2.getV()}");

            Console.ReadKey();
        }
        static private void Kiir(Negyszog obj, nyom v)
        {
            if (v == nyom.oldal)
            {
                Console.WriteLine($"Az n1 négyszög oldalai: a={obj.getA()}, b={obj.getB()}");
            }
            else
            {
                Console.WriteLine($"A négyszög kerülete: {obj.getK()}, területe: {obj.getT()}");
            }
        }
    }
}