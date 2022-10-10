using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 4

            string[] nombre = new string[] { "Nacho", "Fito", "Floky", "Pocho", "Cuca" };

            Console.WriteLine("Los nombres cargados son: ");
            MostrarNombres(nombre);
            Console.ReadKey();

            Array.Sort(nombre);
            Console.WriteLine("\nLos nombres ordenados alfabeticamente son: ");
            MostrarNombres(nombre);
            Console.ReadKey();
        }

        static void MostrarNombres(string[] nombre) 
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }
            
        }



    }
}
