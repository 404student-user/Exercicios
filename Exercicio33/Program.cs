using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pede ao utilizador para inserir um número e verificar se este é palindrome. Um nº é
//palindrome quando o primeiro digito é igual ao último, o segundo igual ao penúltimo e
//por adiante, por exemplo:
//168861->É palindrome
//16861 -> É palindrome
//168561 -> Não é palindrome

namespace Exercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma frase");
            string frase = Console.ReadLine();
            bool flag_frase = true;

            for (int i = 0; i <= frase.Length / 2; i++)
            {
                if (frase.Substring(i, 1) != frase.Substring(frase.Length - i - 1, 1))
                {

                    flag_frase = false;
                    Console.WriteLine($"A palavra {frase} nao e um palindrome");
                    break;
                }

            }
            if (flag_frase == true)
            {
                Console.WriteLine($"A palavra {frase} e um palindrome");
            }

        }
    }
}
