using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sor = 10;
            int oszlop = 10;
            int alsoHatar = 10,
                felsoHatar = 1000;
            int[,] tomb = new int[sor, oszlop];
            Random r = new Random();
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++) 
                {
                    tomb[i,j] = r.Next(alsoHatar, felsoHatar); 
                }
            }
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write(tomb[i, j] + ", ");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("Kiíratás foreach-csel");
            foreach (int i in tomb)
                Console.Write(i + ", ");

            Console.ReadLine();
        }
    }
}