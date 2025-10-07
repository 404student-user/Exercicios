using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, localidade;

            Console.WriteLine("Como te chamas?");
            nome = Console.ReadLine();

            Console.WriteLine("qual e a tua localidade?");
            localidade = Console.ReadLine();

            //3 formas de concatenar

            Console.WriteLine("O teu nome e " + nome);
            
            Console.WriteLine("O teu nome e {0}", nome);

            Console.WriteLine($"O teu nome e {nome}");


        }
    }
}
