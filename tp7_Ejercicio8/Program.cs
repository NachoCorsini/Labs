using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 8
            int sumaDiag = 0;
            int[] vector = new int[3];
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese un numero para la posición {i}, {j}");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (i == j)
                    {
                        vector[i] = matriz[i, j];
                        sumaDiag = sumaDiag + matriz[i, j];
                    }



                }
            }


            Console.WriteLine($"\nLa suma de la diagonal es: {sumaDiag}");
            Console.ReadKey();
        }



    }
}
