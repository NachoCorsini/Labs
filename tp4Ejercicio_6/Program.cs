using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 6

            int numero = 0; int sumaNumeros = 0; float promedio;
            int cantNUmeros = 15;

            for (int i = 0; i < cantNUmeros; i++)
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                sumaNumeros = sumaNumeros + numero;
            }

            promedio = (float)sumaNumeros / cantNUmeros;

            Console.WriteLine($"\nEl resultado de la suma de todos los numero ingresados es: {sumaNumeros}");
            Console.WriteLine($"\nEl promedio de la suma de todos los numeros es {promedio}");



            Console.ReadKey();



        }
    }
}
