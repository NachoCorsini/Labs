using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            int cant = texto.Length;
            int opcion = 1;

            
            while (opcion != 0)
            {

                Console.WriteLine("\nIngrese un texto");
                texto = Console.ReadLine();
                   
                if (texto.Length >= 5)
                {
                    Console.WriteLine($"Ha ingresado el texto {texto} que es igual o superior a 5 caracteres ");
                    
                }
                else
                {
                    Console.WriteLine($"Ha ingresado el texto {texto} que es inferior a 5 caracteres");
                   
                }
                cant++;
                
                

                Console.WriteLine("\nPresione 1 para seguir cargando - presione 0 para dejar de cargar");
                opcion = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"Cantidad de veces que ejecutó el programa: {cant}");
            Console.ReadLine(); 



        }
    }
}
