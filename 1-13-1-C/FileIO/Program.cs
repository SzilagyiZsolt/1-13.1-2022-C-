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
            FileInOut f2 = new FileInOut();

            using(StreamWriter sr2 = f2.getFile2())
            {
                sr2.Write("Sziasztok! Ez itt egy teszt! Ha müködik oké! <3");

            }
            f2.closerFile();

            //using (StreamReader sr = f2.getFile())
            //{


             //   string s = sr.ReadToEnd();
              //  Console.WriteLine(s);

            //}
            //f2.closerFile();
            Console.ReadKey();
        }
    }
}
