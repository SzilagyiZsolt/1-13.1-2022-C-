using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarátokOOP
{
    internal class BaratPage : Barátok
    {
        #region Konstruktorok
        public BaratPage() { }

        #endregion Konstruktorok
        #region Page
        public void Page()
        {
            int lapmeret = 15;
            int i=0;
            int p;
            bool kilep=false;
            for (i = 0; i < lapmeret; i++)
            {
                Console.WriteLine(this.list[i].nev, -20 + ";" + this.list[i].szido.ToShortDateString(), 10 + ";" + this.list[i].hajlam, 1 + ";" + this.list[i].neme, 1);
            }
            p = Convert.ToInt32(Console.Read());
            do
            {
                switch (p)
                {
                    case 33:
                        if (i < lapmeret)
                        {
                            i = 0;
                        }
                        else
                        {
                            i = i - lapmeret;
                        }
                        break;
                    case 34:
                        break;
                    case 35:
                        i= this.list.Count-lapmeret;
                        break;
                    case 36:
                        i = 0;
                        break;
                    case 27:
                        kilep = true;
                        break;
                    default:
                        Console.WriteLine("Csak a következő billentyűket használhatod: PageUp, PageDown, Home, End, Esc");
                        break;
                }
            } while (!kilep);
            
            
        }
        #endregion Page
    }
}
