using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 8

            int num = 0; int cantResto = 0;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            if (num > 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        cantResto++;
                    }

                }
                if (cantResto ==2)
                {
                    Console.WriteLine($"EL numero {num} es PRIMO");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"El numero {num} NO ES PRIMO");
                    Console.ReadLine();
                }


            }
            
            






        }
    }
}
