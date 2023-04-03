using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivételOOP
{
    internal class Kivétel
    {
        public Kivétel() { }
        #region Nincs kivétel kezelés
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivételkezelés\nAdjon meg egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám: {0}", szam);
            Console.ReadKey();
        }
        #endregion Nincs kivétel kezelés
        #region Általános hibakezelés
        public void KivKezAlt()
        {
            Console.WriteLine("\nNincs objektum nélküli kivitelkezelés\nAdjon meg egy számot!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch
            {
                throw;
            }
            Console.ReadKey();
        }
        #endregion Általános hibakezelés
        #region Őshiba objektommal
        public void KivKezOs()
        {
            Console.WriteLine("\nŐs Hiba objektummal kivételkezelés\nAdj meg egy számot!");
            try
            {
                int szam=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
        #endregion Őshiba objektommal
        #region Hiba objektummal
        public void KivKezObj()
        {
            Console.WriteLine("\nSaját Hiba objektummal kivételezés\nAdjon meg egy számot!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch
            {
                Console.WriteLine("Karakter adtál meg szám helyett\nAdj meg egy számot!");
            }
            Console.ReadKey();
        }
        #endregion Hiba objektummal
    }
}
