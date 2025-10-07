using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double R ;
            //double pi = 3.14;

            Console.WriteLine("Qual e o Raio da esfera?");
            R = double.Parse(Console.ReadLine());

            //Console.WriteLine($" O volume e igual a {4 / 3 * pi * (R * R * R)}");
            Console.WriteLine($"Uma esfera do raio {R} e igual a {4 / 3 * Math.PI * Math.Pow(R, 3)}");

        }
    }
}
