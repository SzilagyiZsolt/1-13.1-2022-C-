using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Átlaghő
{
    internal class atlaghoszamitas
    {
        private int honapok;
        private double napok;
        private double[,] homerseklet;
        private int minho;
        private int maxho;
        Random random = new Random();
        public atlaghoszamitas() { }
        public atlaghoszamitas(int honapok, double napok, int minho, int maxho) 
        {
            this.honapok = honapok;
            this.napok = napok;
            this.minho = minho;
        }

        public void setHONAP(double honapok)
        {
            this.honapok = 12;
        }
        public void setNAPOK(double napok)
        {
            this.napok = 30;
        }
        public double getHONAP()
        {
            return this.honapok;
        }
        public double getNAPOK()
        {
            return this.napok;
        }
        public void setHO(double homerseklet)
        {
            this.homerseklet = new double[honapok, (int)napok];
        }
        public void setMINHO(double minho)
        {
            this.minho = int.MaxValue;
        }
        public double getMINHO()
        {
            return this.minho;
        }
        public void setMAXHO(double minho)
        {
            this.maxho = int.MinValue;
        }
        public double getMAXHO()
        {
            return this.maxho;
        }


        public void randombehozas()
        {
            for (int i = 0; i < honapok; i++)
            {
                for (int j = 0; j < napok; j++)
                {
                    homerseklet[i, j] = random.Next(-20, 40);
                }
            }
        }
        public void szamitas()
        {
            for (int i = 0; i < honapok; i++)
            {
                for (int j = 0; j < napok; j++)
                {
                    if (homerseklet[i, j] > maxho)
                    {
                        maxho = (int)homerseklet[i, j];
                    }
                    if (homerseklet[i, j] < minho)
                    {
                        minho = (int)homerseklet[i, j];
                    }
                }
            }
            Console.WriteLine("A legmelegebb fok:{0}", maxho);
            Console.WriteLine("A leghidegebb fok:{0}", minho);

        }
        public void honapszamitas()
        {
            int[,] homerseklet = new int[honapok, (int)napok];
            int[] honapho = new int[honapok];
            for (int i = 0; i < honapok; i++)
            {
                int sum = 0;
                for (int j = 0; j < napok; j++)
                {
                    sum += homerseklet[i, j];
                }
                honapho[i] = (int)(sum / napok);
            }
            int maxhonapho = int.MinValue;
            int minhonapho = int.MaxValue;
            int maxhonap = 0;
            int minhonap = 0;
            for (int i = 0; i < honapok; i++)
            {
                if (honapho[i] > maxhonapho)
                {
                    maxhonapho = honapho[i];
                    maxhonap = i + 1;
                }
                if (honapho[i] < minhonapho)
                {
                    minhonapho = honapho[i];
                    minhonap = i + 1;
                }
            }
            Console.WriteLine("A legmelegebb hónap:{0}-dik, az átlagoshőmérséklet:{1} fok", maxhonap, maxhonapho);
            Console.WriteLine("A leghidegebb hónap:{0}-dik, az átlagoshőmérséklet:{1} fok", minhonap, minhonapho);
        }

    }
}
