using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Random aleatorio = new Random();

            num1 = aleatorio.Next(1,200);
            num2 = aleatorio.Next(1, 200);

            Console.WriteLine($"{num1} - {num2}");

            if (num1 > 100 && num2 > 100)
            {
                Console.WriteLine("Ambos os n sao superiores a 100");
            }
            else if (num1 > 100 || num2 > 100)
            {
                Console.WriteLine("pelo menos um dos neumeros e superior a 100");
            }
            else if (num1 == 100 || num2 == 100)
            {
                Console.WriteLine("pelo menos um dos numerros e igual a 100");
            }
            else
            {
                Console.WriteLine("ambos os numeros sao inferiores a 100");
            }
        }
    }
}
