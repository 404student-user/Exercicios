using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1, Nota2, Nota3 ;
            double media_final = 0; // nao sei porque mas tive de inicializar a variavel a 0
            
            string Tipo_media;

            Console.WriteLine("Qual e a nota 1 ?");
            Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual e a nota 2 ?");
            Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual e a nota 3 ?");
            Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual e a media que pretende? A (arritemetica) ou P (Ponderada)");
            Tipo_media = Console.ReadLine();

            if (Tipo_media.ToLower() == "a") 
            {
                media_final = (Nota1 + Nota2 + Nota3) / 3;
            }
            else if (Tipo_media.ToLower() == "p")          
            {
                media_final = (Nota1 * 0.5) + (Nota2 * 0.3) + (Nota3 * 0.2);
            }
            Console.WriteLine($"A media final e {media_final}");

         

        }

    }
}
