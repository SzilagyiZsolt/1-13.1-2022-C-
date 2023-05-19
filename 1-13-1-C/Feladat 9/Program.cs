using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter forras = new StreamWriter("C:\\Users\\szilagyi.zsolt\\Downloads\\C#\\1-13-1-C\\Feladat 9\\bin\\Debug\\forras.txt"))
            {
                forras.WriteLine("<table>");
                for (int i = 0; i < 10; i++)
                {
                    forras.Write("<tr>");
                    for (int j = 0; j < 20; j++)
                    {
                        forras.Write("<td>");
                        forras.Write("/<td>");
                    }
                    forras.WriteLine("/<tr>");
                }
                forras.Write("</table>");
                forras.Close();
            }
            Console.ReadKey();
        }
    }
}
