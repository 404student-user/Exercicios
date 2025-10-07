using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random mlems = new Random();

            int num_gerado = mlems.Next(1, 100);

            Console.WriteLine(num_gerado);
            Console.WriteLine("\n");

            //   && significa -> E
            //   || (pipe) significa -> OU

            if (num_gerado <= 25)
            {
                Console.WriteLine("O numero gerado esta entre 0 e 25");
            }
            else if (num_gerado > 25 && num_gerado <= 50)
            {
                Console.WriteLine("O numero gerado esta entre 26 e 50");
            }
            else if (num_gerado > 50 && num_gerado <= 75)
            {
                Console.WriteLine("O numero gerado esta entre 51 e 75");
            }
            else
            {
                Console.WriteLine("O numero gerado esta entre 76 e 100");
            }


        }
    }
}
