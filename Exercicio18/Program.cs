using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Gerar 3 nºs aleatórios entre 1 e 100. Apresentar os nºs gerados no ecrã.
Dizer qual é o maior e o menor.
*/

namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int num1, num2, num3;
            Random aleatorio = new Random();
            
            num1 = aleatorio.Next(1, 100);
            num2 = aleatorio.Next(1, 100);            
            num3 = aleatorio.Next(1, 100);
            

            Console.WriteLine($"{num1}, {num2}, {num3}");

                
            if (num1 > num2)    //se o numero 1 for maior que o numero 2
            {
                if(num1 > num3)     // se o numero 1 for maior que 3
                {
                    Console.WriteLine("O maior e o n1"); 
                }
                else    //caso que nem o 1 nem o 2 e maior
                {
                    Console.WriteLine("O maior e o n3"); 
                }
            }
            else    // se o numero 2 for maior que o numero 1
            {
                if (num2 > num3)
                {
                    Console.WriteLine("O maior e o n2");    //caso em que o numero 2 e maior que numero 3 
                }
                else
                {
                    Console.WriteLine("O maior e o n3");    // caso em que o numero 2 e menor que o numero 3
                }
            }


            if (num1 < num2)    // caso em que o numero 1 e menor que o numero 2 
            {
                if (num1 < num3)    // caso em que o numero 1 e menor que o numero 3
                {
                    Console.WriteLine("O menor e o n1");
                }
                else    // caso em que o numero 1 nao e menor que o 3
                {
                    Console.WriteLine("O menor e o n3");
                }
            }
            else    // caso em que o numero 2 e menor que o numero 1
            {
                if (num2 < num3)    //caso em que o numero 2 e menor que o numero 3
                {
                    Console.WriteLine("O menor e o n2");
                }
                else    //caso em que o numero 3 e menor que o numero 2
                {
                    Console.WriteLine("O menor e o n3");
                }
            }





        }
    }
}
