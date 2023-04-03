using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOOP
{
    internal class Matrix
    {
        //Osztályváltozók
        private int a, b, c, d, osszeg,n;
        private int[,] Tomb=null;

        //Konstruktorok
        public Matrix(int a, int b, int c, int d, int n, int[,] Tomb) //Az a,b,c,d a 2-es mátrix mérethez való
        {
            this.a = a; 
            this.b = b;
            this.c = c;
            this.d = d;
            this.n = n;  //Mátrix mérete
            this.Tomb= Tomb;
        }
        public void setOSSZEG()
        {
            if (n == 2)
            {
                
                this.osszeg = this.a * this.d - this.b * this.c;
            }
            else if (n == 3)
            {

            }
            else if(n <2)
            {
                
            }
            
        }
        public int getOSSZEG()
        {
            return this.osszeg;
        }

    }
}
