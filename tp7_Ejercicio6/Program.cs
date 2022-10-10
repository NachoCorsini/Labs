using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 6

            string[,] matriz = new string[2, 2] { { "FIAT", "PEUGEOT" }, { "RENAULT", "CHEVROLET" } };

            Console.WriteLine("Las marcas de los autos son: ");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"{matriz[i,j]}");
                }  

            }





            Console.ReadKey();
        }



        
    }
}
