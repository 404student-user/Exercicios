using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Pedir ao utilizador para escrever uma frase. Apresentar essa frase no ecrã em
que de forma alternada apresenta um caractere a vermelho e outro a verde */

namespace Frase_a_cores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreve uma frase");
            string frase = Console.ReadLine();
            
            for (int i = 0; i < frase.Length; i++)
            {

                if(i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write($"{frase[i]}");
                Console.ResetColor();
            }
        }
    }
}
