using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 9

            int num = 0; int cant = 0; int cantResto = 0;
            int cantNumeros = 0; int cantPrimos = 0; int cantNoprimos = 0;

            Console.WriteLine("Ingrese la cantidad de numeros a ingresar");
            cantNumeros = int.Parse(Console.ReadLine());

            while (cant < cantNumeros)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());

                cant++;


                if (num > 1)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            cantResto++;
                        }

                    }
                    if (cantResto != 2)
                    {

                        cantPrimos++;
                    }
                    else
                    {
                        cantNoprimos++;
                    }

                }


            }

            Console.WriteLine($"La cantidad de numeros primos existentes son: {cantPrimos}");
            Console.ReadLine();
            Console.WriteLine($"\nLa cantidad de numeros NO primos son: {cantNoprimos}");
            Console.ReadLine();






        }
    }
}