using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsempeOOP
{
    internal class Csempe
    {
        private int cs, TT, a, b, T;
        public Csempe() { }
        public void setA(int a)
        {
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setT()
        {
            this.T = this.a * this.b;
        }
        public void setCS()
        {
            this.cs = (int)(this.T / (0.2 * 0.2));
        }
        public void setTT()
        {
            this.TT = (int)Math.Round(this.cs * 1.1);
        }
        public int getTT() { return this.TT; }
    }
}
