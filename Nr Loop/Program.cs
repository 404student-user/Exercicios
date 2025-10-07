using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, resultado = 0;

            while (true)
            {

                Console.WriteLine("cospe um nr primo");
                x = int.Parse(Console.ReadLine());

                if (x < 0)
                {
                    Console.WriteLine($"Resultado {resultado}");
                    break;
                }
                else
                {
                    resultado = resultado + x;
                }
            }  
        }
    }
}
