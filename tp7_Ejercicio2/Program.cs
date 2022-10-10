using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 2

            int[] vector = new int[5];
            float suma = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");
                vector[i] = int.Parse(Console.ReadLine());

                suma = suma + vector[i];
            }


            Console.WriteLine($"\nEl promedio de los numeros ingresados es: {suma/5}");


            Console.ReadKey();
        }




    }
}
