using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Seg
{
    internal class Program
    {

        /* Faça um programa que recebe o tempo de duração de uma fábrica expressa
            em segundos e retorna esse tempo em horas, minutos e segundos.
            Por exemplo: 7300 seg => 2 horas, 1 minuto e 40 segundos  */

        static void Main(string[] args)
        {
            int s;

            Console.WriteLine("Quantos segundos dura o programa?");
            s = int.Parse(Console.ReadLine());

            int horas = 0;
            int minutos = 0;
            int segundos = 0;

            while (s > 0) 
            {
                
                if(segundos > 59)
                {
                    segundos = 0;
                    minutos++;
                    
                }
                if(minutos > 59)
                {
                    minutos = 0;
                    horas++;
                }
                segundos++;
                s--;
            }
            Console.WriteLine($"{horas}h:{minutos}m:{segundos}s");
        }
    }
}
