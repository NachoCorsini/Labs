using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPUESTOS_4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vector = new string[4];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingrese los nombres para guardar en el vector");
                vector[i] = Console.ReadLine();
            }
            Console.WriteLine("\nLos nombres ingresados son:");
            foreach (string item in vector)
            {
                Console.WriteLine(item);
            }


        }



    }



}
