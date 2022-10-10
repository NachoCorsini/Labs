using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPUESTOS_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIOS PROPUESTOS 4.4

            double[,] Matriz = CargarMatrizDinamica();

            double[] Vector = Diagonal(Matriz);

            Console.Clear();
            Console.Write("Variable Desordenada: ");
            foreach (var item in Vector)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            Array.Sort(Vector);
            Console.Write("Varibles Ordenadas: ");
            foreach (var item in Vector)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();





        }
        static double[] Diagonal(double[,] M)
        {
            double[] vector = new double[M.GetLength(0)];

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        vector[i] = M[i, j];
                    }
                }
            }
            return vector;
        }


        static double[,] CargarMatrizDinamica()
        {
            Console.Clear();

            System.Console.WriteLine("Construir el tamaño de una Matriz:");
            System.Console.Write("Filas: ");
            int F = int.Parse(Console.ReadLine());
            System.Console.Write("\n");
            System.Console.Write("Columnas: ");
            int C = int.Parse(Console.ReadLine());
            Console.Clear();

            double[,] M = new double[F, C];
            System.Console.WriteLine("Ingrese los valores para cargar la matriz:");

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = ValidaValor(i, j);
                }
            }

            return M;
        }

        static double ValidaValor(int i, int j)
        {

            bool Condicion = true;
            double valor = 0;



            while (Condicion)
            {
                try
                {
                    Console.Write($"Valor[{i}{j}] : ");
                    valor = double.Parse(Console.ReadLine());
                    Condicion = false;
                }
                catch
                {
                    Console.WriteLine("****ERROR****, Ingrese un Numero.");
                }

            }

            return valor;
        }



    }









}



























}
