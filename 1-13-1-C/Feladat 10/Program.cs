using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Add meg a neved: ");
            a = Console.ReadLine();
            using (StreamWriter forras = new StreamWriter("C:\\Users\\szilagyi.zsolt\\Downloads\\C#\\1-13-1-C\\Feladat 10\\bin\\Debug\\forras.txt"))
            {
                forras.WriteLine("<Html>");
                forras.WriteLine("<Head>");
                forras.WriteLine("<Body>");
                forras.WriteLine("<h1>Hello: "+a+"</h1>");
                forras.WriteLine("/<Body>");
                forras.WriteLine("/<Head>");
                forras.WriteLine("</Html>");
                forras.Close();
            }
            Console.ReadKey();
        }
    }
}
