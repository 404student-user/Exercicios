using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data;

            Console.WriteLine("Qual e o dia de hoje?");
            data = Console.ReadLine();

            Console.WriteLine($"Dia: {data.Substring(0, 2)}");

            Console.WriteLine($"Mes: {data.Substring(3, 2)}");

            Console.WriteLine($"Ano: {data.Substring(6, 4)}");
        }
    }
}
