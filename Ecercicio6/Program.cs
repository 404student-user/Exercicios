using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;

            Console.WriteLine("Escreve uma frase");
            frase = Console.ReadLine();

            Console.WriteLine($"A frase escrita tem {frase.Length} caracteres");
            Console.WriteLine($"maiusculas {frase.ToUpper()}");
            Console.WriteLine($"maiusculas {frase.ToLower()}");
            Console.WriteLine($"Os Tres Primeiros Caracteres: {frase.Substring(0, 3)}");
            Console.WriteLine($"Posicao do espaco: {frase.IndexOf(' ')}");
            


        }
    }
}
