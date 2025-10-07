using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//fazer um jogo tentar encontrar o numero gerado
namespace exercicio23
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int num_a_adivinhar, num_aposta_utilizador = 0, num_tentativas = 0;
            Random aleatorio = new Random();

            num_a_adivinhar = aleatorio.Next(1, 6000);

            Console.WriteLine(num_a_adivinhar);

            while (num_a_adivinhar != num_aposta_utilizador)
            {
                Console.Clear();

                Console.WriteLine("Faz a tua aposta");
                num_aposta_utilizador = int.Parse(Console.ReadLine());

                num_tentativas++;

                if (num_a_adivinhar > num_aposta_utilizador)
                {
                    Console.WriteLine("O numero que procuras e mais alto");
                }
                else if (num_a_adivinhar < num_aposta_utilizador)
                {
                    Console.WriteLine("O numero que procuras esta mais baixo");
                }


                Console.ReadKey();
            }
            Console.WriteLine($"Parabens oh palhaco acertas-te em {num_tentativas} vezes");
        }
    }
}