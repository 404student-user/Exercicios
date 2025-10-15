using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a program that  asks the user to enter a positive interger 'n' and calculates the sum of numbers from 1 to 'n'.
 */
namespace For_loop_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            Console.WriteLine("Coloca um numero positivo");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                r = r + i;

                Console.WriteLine($"{r}");
            }
        }
    }
}
