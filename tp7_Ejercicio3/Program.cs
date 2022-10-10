using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 3
            //int VectorSize = 0;

            //Console.WriteLine("Ingrese el tamaño del vector");
            //VectorSize = int.Parse(Console.ReadLine());

            //int[] vector = new int[VectorSize];

            //for (int i = 0; i < VectorSize; i++)
            //{
            //    vector[i] = i;
            //}


            //for (int i = 0; i < VectorSize; i++)
            //{

            //    Console.WriteLine($"\n{vector[i]}");
            //}



            int VectorSize = 0;

            Console.WriteLine("Ingrese el tamaño del vector");
            VectorSize = int.Parse(Console.ReadLine());

            int[] vector = new int[VectorSize];

            for (int i = 0; i < VectorSize; i++)
            {
                Console.WriteLine("Ingrese un numero para completar el vector");
                vector[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < vector.Length; i++)
            {

                Console.WriteLine($"\nEl vector desordenado es: {vector[i]}");
            }

            for (int i = 0; i < vector.Length; i++)
            {
                Array.Sort(vector);
                Console.WriteLine($"\nEl vector ordenado es: {vector[i]}");
            }




            Console.ReadKey();
        }






    }
}
