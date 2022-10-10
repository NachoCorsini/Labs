using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 3

            int num1 = 0;
            int num2 = 0;
            int operacion=0;
            float resultado = 0;


          
            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Elija una opción del 1 al 4 para SUMAR/RESTAR/DIVIDIR O MULTIPLICAR");
            operacion = int.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 1: resultado = num1 + num2;
                    break;
                case 2: resultado = num1 - num2;
                    break;
                case 3: resultado = num1 / (float)num2;
                    break;
                case 4: resultado = num1 * num2;
                    break;
                default: Console.WriteLine("No ha ingresado una opción correcta");
                    break;

            }


            Console.WriteLine($"EL resultado es {resultado}");
            Console.ReadLine();


        }
    }
}
