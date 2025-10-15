using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pede ao utilizador para inserir 3 números.
//Apresenta esses nºs no ecrã por ordem crescente.
//NOTA: Tentar otimizar ao máximo o nº de comparações

namespace Exercicio35
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n1, n2, n3, temp;

            while (true)
            {
                Console.Write("Digite o 1º número: ");
                while (!int.TryParse(Console.ReadLine(), out n1)) ;

                Console.Write("Digite o 2º número: ");
                while (!int.TryParse(Console.ReadLine(), out n2)) ;

                Console.Write("Digite o 3º número: ");
                while (!int.TryParse(Console.ReadLine(), out n3)) ;

                if (n1 > n3) { temp = n1; n1 = n3; n3 = temp; } // Program.troca(ref n1, ref n3);
                if (n1 > n2) { temp = n1; n1 = n2; n2 = temp; } // Program.troca(ref n1, ref n2);
                if (n2 > n3) { temp = n2; n2 = n3; n3 = temp; } // Program.troca(ref n2, ref n3);

                Console.WriteLine($"\t{n1}\t{n2}\t{n3}");
                Console.WriteLine("Prima Ctrl + C para terminar o programa!...");
                Console.ReadLine();
            } // end while

        } // end Main()

        static void troca(ref int a, ref int b) { int temp = a; a = b; b = temp; return; } // end troca()

    } // end class Program
}
