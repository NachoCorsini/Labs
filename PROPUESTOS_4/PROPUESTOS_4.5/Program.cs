using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPUESTOS_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIOS PROPUESTOS 4.5

            int a, b;

            Console.WriteLine("Ingrese valores para asignar el tamaño de la matriz");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            string[,] matriz = new string[a, b];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese nombres a la matriz en la posiciones ({i},{j})");
                    matriz[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("Los nombres ingresados son:");
            MostrarMatriz(matriz, false);

            Console.WriteLine("Los nombres ya cambiados en filas por columnas son:");
            MostrarMatriz(matriz, true);
        }
        static void MostrarMatriz(string[,] v, bool cambio)
        {
            for (int i = 0; i < v.GetLength(0); i++)
            {
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    if (cambio == true)
                    {
                        Console.WriteLine("Los nombres en la posición ({0},{1}) son {2}  ", i, j, v[j, i]);
                    }
                    else
                    {
                        Console.WriteLine(v[i, j]);
                    }



                }




            }



        }



    }

}
