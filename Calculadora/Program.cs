using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("qual e o primeiro Nr do calculo?");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual e o tipo de operacao?");
                char operacao = char.Parse(Console.ReadLine());

                Console.WriteLine("qual e o segundo numero a calcular");
                int y = int.Parse(Console.ReadLine());


                switch (operacao)
                {

                    case '+':
                        Console.WriteLine($"Resultado {x}+{y}= {x + y}");
                        break;

                    case '-':
                        Console.WriteLine($"Resultado {x}-{y}= {x - y}");
                        break;

                    case 'x':
                        Console.WriteLine($"Resultado {x}x{y}= {x * y}");
                        break;

                    case '/':
                        Console.WriteLine($"Resultado {x}/{y}= {x / y}");
                        break;

                    default:

                        Console.WriteLine("Nabo");
                        break;
                }
                Console.WriteLine("queres fazer outra operacao?");
                if (Console.ReadLine().ToLower() != "sim")
                {
                    break;
                }
                Console.Clear();

            }
        }
    }        
}
