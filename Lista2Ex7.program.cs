using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Formação de triângulos:");
            Console.Write("Digite o valor da primeira aresta:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da segunda aresta:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da terceira aresta:");
            c = double.Parse(Console.ReadLine());

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                Console.WriteLine("Estes valores não formam um triângulo.");
            }
            else
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Este triângulo é equilátero");
                }
                if (a != b && b != c && c != a)
                {
                    Console.WriteLine("Este triângulo é escaleno");
                }
                if (a == b && b != c || b == c && c != a || c == a && a != b)
                {
                    Console.WriteLine("Este triângulo é isósceles");
                }
            }
        }
    }
}
