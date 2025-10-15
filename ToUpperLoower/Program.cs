using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpperLoower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual e a frase?");
            string f = Console.ReadLine();

            Console.Clear();

            for (int i = 0; i < f.Length; i++) {

                if (i <= 5)
                {
                    Console.Write($"{f.ToUpper()[i]}");
                }
                else {
                    Console.Write($"{f.ToLower()[i]}");

                }
            }
        }
    }
}
