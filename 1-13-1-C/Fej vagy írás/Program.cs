using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Fej_vagy_írás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pénz, tét, dobás;
            string fvi, dobás2;

            int[]Tomb=new int[1];
            Random r = new Random();
            Console.WriteLine("### Fej vagy írás ###");
            Console.WriteLine("Mennyi pénzed van?");
            pénz=int.Parse(Console.ReadLine());
            while (pénz > 0)
            {
                for (int i = 0; i < Tomb.Length; i++)
                {
                    Tomb[i] = r.Next(2);
                    dobás = Tomb[i];
                    Console.WriteLine("Pénzed: {0}", pénz);

                    Console.WriteLine("Tipp?");
                    fvi = Console.ReadLine();
                    if (fvi == "Fej" || fvi=="fej")
                    {
                        fvi = "Fej";
                    }
                    else if (fvi == "Írás" || fvi=="írás")
                    {
                        fvi = "Írás";
                    }

                    Console.WriteLine("Tét?");
                    tét = int.Parse(Console.ReadLine());
                    if (dobás == 0)
                    {
                        dobás2 = "Fej";
                    }
                    else
                    {
                        dobás2 = "Írás";
                    }
                    if (dobás2 == fvi)
                    {
                        Console.WriteLine("A dobás: {0}", dobás2);
                        Console.WriteLine("Nyertél {0} forintot!", tét);
                        pénz = pénz + tét;
                        Console.WriteLine("Nyomj meg egy gombot a folytatáshoz!");
                    }
                    else
                    {
                        Console.WriteLine("A dobás: {0}", dobás2);
                        Console.WriteLine("Vesztettél {0} forintot!", tét);
                        pénz = pénz - tét;
                    }
                    Console.WriteLine(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
