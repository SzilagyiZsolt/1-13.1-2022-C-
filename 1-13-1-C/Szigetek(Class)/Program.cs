using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek_Class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Példa
            if (true)
            {
                string s = "0011111100111000011111100011110";
                Sziget_számolás sz1= new Sziget_számolás();
                sz1.setData(s);
                sz1.Szamol();
                Console.WriteLine("A szigetek száma: {0}. A leghosszabb sziget hossza: {1}", sz1.getIslandCount(), sz1.getMaxIslandLenght());
            }


            //2.Példa
            if (true) 
            {
                string s2 = "10100011100011011000011100111010101110110101101110100101111101010101110110000";
                Sziget_számolás sz2 = new Sziget_számolás();
                sz2.setData(s2);
                sz2.Szamol();
                Console.WriteLine("A szigetek száma: {0}. A leghosszabb sziget hossza: {1}", sz2.getIslandCount(), sz2.getMaxIslandLenght());
            }
            
            Console.ReadKey();
        }
    }
}
