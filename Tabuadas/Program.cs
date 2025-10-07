using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuadas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {   
                Console.WriteLine($"Tabuada do {i}");

                for (int k = 1; k <= 10; k++)
                {
                    Console.WriteLine($" {i} * {k} = {i * k}");

                }
                Console.WriteLine();
            }
        }
    }
}
