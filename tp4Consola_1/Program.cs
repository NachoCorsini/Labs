using System;

namespace tp4Consola_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TRABAJO PRACTICO N° 4 
            //EJERCICIO  1 a


            int numero = 0;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es PAR");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El numero es IMPAR");
                Console.ReadLine();
            }



        }
    }
    } 
