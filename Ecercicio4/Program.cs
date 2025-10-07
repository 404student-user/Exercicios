using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("qual e o 1 numero?");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("qual e o 2 numero?");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"a soma de {num1} com {num2} e igual a {num1 + num2}");

        }
    }
}
