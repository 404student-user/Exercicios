using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esq_e_direita_frase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreve uma fffrase");
            string frase = Console.ReadLine();

            for (int i = 1; i <= frase.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{frase.Substring(frase.Length - i, 1)}");
            }

            Console.WriteLine();    
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{frase}");
            Console.ResetColor();
        }
    }
}
