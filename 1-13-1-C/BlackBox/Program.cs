using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = new string[100]; 
            int n; 
            FileStream fs = new FileStream("adat.csv", FileMode.Open, FileAccess.Read); 
            StreamReader sr = new StreamReader(fs); 
            Console.WriteLine("A file tartalma:"); 
            sr.BaseStream.Seek(0, SeekOrigin.Begin); 
            n = 1; 
            sorok[n] = sr.ReadLine(); 
            while (sorok[n] != null) 
            {
                Console.WriteLine(sorok[n]); 
                n++; 
                sorok[n] = sr.ReadLine();
            } 
            sr.Close(); 
            fs.Close(); 
            for (int i = 1; i < n; i++) 
            { 
                string[] words = sorok[i].Split(';');
                foreach (var word in words) 
                { 
                    System.Console.WriteLine(word); 
                } System.Console.WriteLine();
            } 
            if(File.Exists(adat.))
            Console.ReadLine();
        }
    }
}
