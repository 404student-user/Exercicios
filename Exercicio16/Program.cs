using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Pedir ao utilizador para inserir a temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius.
 
A fórmula de conversão é: C= ((F - 32) * 5) / 9, na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius.
 */

namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double temperaturaF, conversao;

            Console.WriteLine("Qual e temperatura?");
            temperaturaF = double.Parse(Console.ReadLine());

            conversao = ((temperaturaF - 32) * 5) / 9;

            Console.WriteLine($"A conversao de Fahrenheit para Celsius e {Math.Round(conversao,2)}");





        }
    }
}
