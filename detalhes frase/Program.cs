using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detalhes_frase
{
    internal class Program
    {
            /*Exercício 3
            Pede ao utilizador para escrever uma frase.
            Apresenta o seguinte:
            -Nº total de caracteres da frase
            - A frase em maiúsculas
            - A frase em minúsculas
            - O primeiro e último caracteres a verde e os restantes a vermelho
            */
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma ffrase");
            string frase = Console.ReadLine();
            
            Console.WriteLine($"nr de caracteres :{frase.Length}");
            
            Console.WriteLine($"{frase.ToUpper()}");

            Console.WriteLine($"{frase.ToLower()}");


            for (int i = 0; i < frase.Length; i++)
            {
                if (i == 0 ||  i == frase.Length - 1)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{frase.Substring(i, 1)}");
                }
               else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{frase.Substring(i, 1)}");
                }
            }
            Console.ResetColor();
        }
    }
}

