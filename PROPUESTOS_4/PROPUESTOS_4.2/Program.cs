using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPUESTOS_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIOS PROPUESTOS 4.2


            int[,] matriz1 = new int[3, 3]
            {{2,3,6 },
             {8,4,7},
             {9,3,5} };

            int[,] matriz2 = new int[3, 3]
            {{2,3,6 },
            {3,7,5 },
            { 9,1,5} };

            int[,] matriz3 = new int[3, 3];
            int suma = 0;

            for (int i = 0; i < matriz3.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3.GetLength(1); j++)
                {
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];

                    if (j == i)
                    {
                        suma += matriz3[i, j];
                    }
                }
            }
            Console.WriteLine($"La suma de la diagonal es {suma}");
            Console.WriteLine("Los valores de la matriz final son:");
            MostrarMatriz(matriz3);



        }


        static void MostrarMatriz(int[,] v)
        {
            for (int i = 0; i < v.GetLength(0); i++)
            {
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    Console.WriteLine("El nro en la posición ({0},{1}) es {2}", i, j, v[j, i]);
                }



            }



        }



    }




}
