using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random mlems = new Random();

            int num_gerado = mlems.Next(1,100);

            Console.WriteLine(num_gerado);

            if (num_gerado % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Num par de mlems");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Num impar de mlems");

            }
            Console.ResetColor();




        }
    }
}
