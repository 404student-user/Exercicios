using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miusculas_ninusculas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("escrebe uma ffrase?");
            string frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write($"{frase.ToUpper()[i]}");
                }
                else
                {
                    Console.Write($"{frase.ToLower()[i]}");
                }
                
            }
        }
    }
}
