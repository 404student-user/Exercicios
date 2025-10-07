using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int escolha;
            Console.WriteLine("Escolhe um numero entre 1 e 5");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha) {
                case 1:
                    Console.WriteLine("Um");
                    break;

                case 2:
                    Console.WriteLine("DOIS");
                    break;

                case 3:
                    Console.WriteLine("TRES");
                    break;

                case 4:
                    Console.WriteLine("QUATRO");
                    break;

                case 5:
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.WriteLine("Cara de cu");
                    break;

            }





            }
    }
}
