using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Desenvolver uma aplicacao que pergunta ao utilizador quantos n pretende gerar e entre
que valores(minimo e maximo)
Apresentar os n gerados no ecra qual o maior qual o menor e a media

 */
namespace Exercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int gerar, minimo, maximo;
            float media = 0;

            Random random = new Random();
            Console.WriteLine("Quantos numeros queres gerar");
            gerar = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual e o valor minimo");
            minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual e o valor maximo");
            maximo = int.Parse(Console.ReadLine());

            int teste_maximo = minimo;
            int teste_minimo = maximo;

            for (int i = 0; i < gerar; i += 1)
            {
                int teste;
                Console.WriteLine($"{teste = random.Next(minimo, maximo)}");

                media = media + teste;

                if (teste_maximo < teste)
                {
                    teste_maximo = teste;
                }
                else
                {

                }
                if (teste_minimo > teste)
                {
                    teste_minimo = teste;
                }
                else
                {

                }
            }
            Console.WriteLine("");
            Console.WriteLine($"A media e ={media / gerar}");
            Console.WriteLine($"Maximo = {teste_maximo}");
            Console.WriteLine($"Minimo = {teste_minimo}");


        }
    }
}