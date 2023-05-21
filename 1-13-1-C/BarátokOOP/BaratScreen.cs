using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarátokOOP
{
    internal class BaratScreen : Barátok
    {
        #region Konstruktorok
        public BaratScreen() { }

        #endregion Konstruktorok
        #region Képernyőre listázás
        public void listazas()
        {
            foreach (var item in this.list)
            {
                Console.WriteLine($"{item.nev,-20}; " +
                    $"{item.szido.ToShortDateString(),10}; " +
                    $"{item.hajlam,1};  " +
                    $"{item.neme,1}");
            }
        }
        #endregion Képernyőre listázás
    }
}
