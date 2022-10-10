using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 7

            int fact=1; int numero; int cont=0;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                cont++;
                fact = fact * cont;
            }

            
            Console.WriteLine($"EL factorial del numero {numero} es {fact}");
            Console.ReadLine();
            


        }
    }
}
