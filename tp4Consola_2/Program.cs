using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Consola_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO 1 b

            int numero = 0;
            int suma = 0;


            for (int contador = 1; contador <= 5; contador++)
            {

                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                if (numero < 5)
                {
                    numero = numero * 3;

                }
                else
                {
                    numero = numero + 10;

                }

                suma = suma + numero;

            }


            Console.WriteLine($"El total del numero ingresado es: {suma}");
            Console.ReadLine();





        }
    }
}
