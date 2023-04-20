using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInOut f= new FileInOut();
            using (StreamWriter sr2 = f.getFile2())
            {

                Console.ReadLine();

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
