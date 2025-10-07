using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;

            Console.WriteLine("Qual o valor do lado 1?");
            lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do lado 2?");
            lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do lado 3?");
            lado3 = int.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("o triangulo e equilatero");
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                Console.WriteLine("o triangulo e escaleno");
            }
            else
            {
                Console.WriteLine("o triangulo e isosceles");
            }

                



        }
    }
}
