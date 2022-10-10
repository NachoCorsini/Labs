using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPUESTOS_4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIOS PROPUESTOS 4.6

            int[,] matriz = new int[5, 5];
            int[] vector_1 = new int[5];
            int[] vector_2 = new int[5];
            int sumaInversa = 0, sumaDiagonal = 0, SumaTotal = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese valores enteros para las posiciones ({i},{j})");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (i == j)
                    {
                        vector_1[i] = matriz[i, j];
                        sumaDiagonal += vector_1[i];
                    }
                    if (i == matriz.GetLength(1) - 1)
                    {
                        vector_2[j] = matriz[i, j];
                        sumaInversa += vector_2[j];
                    }
                }
            }
            SumaTotal = sumaDiagonal + sumaInversa;
            Console.WriteLine($"La suma de la X en la matriz da como resultado: {SumaTotal}");


            Console.WriteLine("Los Numeros que conformaron la suma son:");
            MostrarVectores(vector_1, vector_2);
        }
        static void MostrarVectores(int[] v, int[] b)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }





        }



    }



}
