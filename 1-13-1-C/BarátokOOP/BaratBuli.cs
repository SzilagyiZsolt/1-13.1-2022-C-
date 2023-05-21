using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarátokOOP
{
    internal class BaratBuli : Barátok
    {
        #region Kontruktor
        public BaratBuli() { }
        #endregion Kontruktor
        #region Buli
        public void bulizas()
        {
            Console.WriteLine("Kérem adja meg az életkorán: ");
            int E= int.Parse(Console.ReadLine());
            int a = 0;
            DateTime d = DateTime.Now;   

            Console.ReadKey();
        }
        #endregion Buli
    }
}
