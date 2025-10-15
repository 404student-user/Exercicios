using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Exercício 2
Ler um número entre 1 e 12 e escrever o mês correspondente, caso o
utilizador digite um número fora desse intervalo, deverá aparecer uma
mensagem informando que não existe o mês com este número.
 */


namespace detector_de_mes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("numero de 1-12");
            m = int.Parse(Console.ReadLine());
            
            switch (m)
            {
                
                case 1:
                    Console.WriteLine($"Estamos no mes de Janeiro");
                    break;

                case 2:
                    Console.WriteLine($"Estamos no mes de Fevereiro");
                    break;

                case 3:
                    Console.WriteLine($"Estamos no mes de Marco");
                    break;

                case 4:
                    Console.WriteLine($"Estamos no mes de Abril");
                    break;

                case 5:
                    Console.WriteLine($"Estamos no mes de maio");
                    break;

                case 6:
                    Console.WriteLine($"Estamos no mes de junho");
                    break;

                case 7:
                    Console.WriteLine($"Estamos no mes de julho");
                    break;

                case 8:
                    Console.WriteLine($"Estamos no mes de Agosto");
                    break;

                case 9:
                    Console.WriteLine($"Estamos no mes de setembro");
                    break;

                case 10:
                    Console.WriteLine($"Estamos no mes de outubro");
                    break;

                case 11:
                    Console.WriteLine($"Estamos no mes de novembro");
                    break;

                case 12:
                    Console.WriteLine($"Estamos no mes de Dezembro");
                    break;

                default: 
                    Console.WriteLine(" 1 a 12 estupido!");
                    break;
            }
        }
    }
}
