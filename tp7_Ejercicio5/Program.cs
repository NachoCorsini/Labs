using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 5

            
            string[] nombres = new string[5];
            int[] notas = new int[5];


            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del alumno");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la nota final del alumno");
                notas[i] = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("\nLISTADO DE ALUMNOS CON SUS RESPECTIVAS NOTAS");
            

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"\n{nombres[i]} {notas[i]}");
            }
           




            Console.ReadKey();
        }






    }
}
