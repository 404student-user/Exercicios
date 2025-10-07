using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor;

                Console.WriteLine("insere um valor entre 0 e 100");
            valor = int.Parse(Console.ReadLine());

            if (valor > 50) 
            {
                Console.WriteLine("O valor e maior que 50");
            }
            else if(valor == 50)
            {
                Console.WriteLine("O valor e 50");
            }
            else
            {
                Console.WriteLine("O valor e menor ou igual a 50");
            }
             


        }
    }
}
