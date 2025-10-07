using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome, morada;
            int idade;

            Console.WriteLine("qual e o teu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Onde moras?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantos anos tens?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"O teu nome e {nome} moras em {morada} e tens {idade} anos");

        }
    }
}
