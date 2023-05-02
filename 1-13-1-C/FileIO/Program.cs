using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FileIO
{
    internal class Program
    {
        private string[] s = new string[20];
        static void Main(string[] args)
        {
            FileInOut f = new FileInOut();

            fileReadLine(f.getFile());
            string[] s = {};
            fileWrite(f.getFile(), s);

            fileReadLine(f.getFile());
            fileWrite(new FileStream("f.txt", FileMode.CreateNew, FileAccess.Write), s);
            f.closerFile();
            Console.ReadKey();
        }
        //private static void fileReadFull(FileStream fileStream)
        //{
        //    using(StreamReader sr=new StreamReader(fileStream))
        //    {

        //        Console.WriteLine("Egyszerre olvassa a fájlt");
        //        string s = sr.ReadToEnd();
        //        Console.WriteLine(s);

        //        Console.WriteLine();
        //    }
        //}

        public static void fileReadLine(FileStream fileStream)
        {
            using(StreamReader sr=new StreamReader(fileStream)) 
            {
                Console.WriteLine("Soronként olvassa a fájlt");
                for (int i = 0; i < 20; i++)
                {
                        string s = sr.ReadLine();
                        Console.WriteLine(s);
                }
                
            }
        }

        private static void fileWrite(FileStream fileStream, string[] s)
        {
            using(StreamWriter sr=new StreamWriter(fileStream))
            {
                Console.WriteLine("írja a fájlt");
                for (int i = 0; i < s.Length; i++)
                {
                    sr.WriteLine(s[i]);
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}

