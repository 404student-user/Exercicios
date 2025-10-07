using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alt, Peso_ideal;
            string genero;


            Console.WriteLine("Qual e a tua altura?");
            alt = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual e o teu genero?");
            genero = Console.ReadLine();

            if (genero.ToLower() == "h")
            {
                Peso_ideal = 72.7 * alt - 58;
            }
            else
            {
                Peso_ideal = 62.1 * alt - 44.7;
            }
            Console.WriteLine($"O peso ideal para {alt}mt e {Peso_ideal} kgs");


        }
    }
}
