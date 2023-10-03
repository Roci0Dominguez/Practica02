using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumatoria_de_8_digitos_enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h = 0;
            Console.WriteLine("ingrese un digito");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un digito");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un digito");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un digito");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un digito");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un digito");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un digito");
            g = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un digito");
            h = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("la suma es : " + c);
            Console.ReadKey();
        }
    }
}
