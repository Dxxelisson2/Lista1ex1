using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJLISTAex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int area;

            Console.WriteLine("DIGITE A ALTURA DO RENTANGULO");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE A BASE DO RETANGULO");
            h = int.Parse(Console.ReadLine());
            area = b * h;
            Console.WriteLine(" A AREA DO RETANGULO QUE TEM BASE DE {0}  E A ALTURA  DE {1} E: {2}",b,h,area);
            Console.WriteLine();
            Console.WriteLine(" PARABENS ");

           


        }
    }
}
