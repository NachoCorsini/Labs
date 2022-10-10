using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Consola_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1 c

            int numero1 = 0;
            int numero2 = 0;
            int suma = 0;


            Console.WriteLine("Ingrese el 1° numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el 2° numero");
            numero2 = int.Parse(Console.ReadLine());

            suma = numero1 + numero2;


            if (suma % 2 == 0)
            {
                Console.WriteLine("El resultado es un numero par");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El resultado es un numero impar");
                Console.ReadLine();
            }


        }
    }
}
