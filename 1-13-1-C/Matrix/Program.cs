using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,n;
            Console.WriteLine("Add meg hogy Mátrix méretét: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a 4 számot: ");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());
            d=int.Parse(Console.ReadLine());
            Matrix m1=new Matrix(a,b,c,d,n);
            m1.setOSSZEG();
            Console.WriteLine("A determináns összege: {0}", m1.getOSSZEG());
            Console.ReadKey();
        }
    }
}
