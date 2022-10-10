using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 2

            int numero = 0;
            Console.WriteLine("Ingrese un numero del 1 al 12");
            numero = int.Parse(Console.ReadLine());

            switch (numero)    
            {
                case 1: 
                    Console.WriteLine("Usted ha ingresado el mes ENERO");
                     break;
                case 2:
                    Console.WriteLine("Usted ha ingresado el mes FEBRERO");
                    break ;
                case 3:
                    Console.WriteLine("Usted ha ingresado el mes MARZO");
                    break;
                case 4:
                    Console.WriteLine("Usted ha ingresado el mes ABRIL");
                    break;
                case 5:
                    Console.WriteLine("Usted ha ingresado el mes MAYO");
                    break;
                case 6:
                    Console.WriteLine("Usted ha ingresado el mes JUNIO");
                    break;
                case 7:
                    Console.WriteLine("Usted ha ingresado el mes JULIO");
                    break;
                case 8:
                    Console.WriteLine("Usted ha ingresado el mes AGOSTO");
                    break;
                case 9:
                    Console.WriteLine("Usted ha ingresado el mes SEPTIEMBRE");
                    break;
                case 10:
                    Console.WriteLine("Usted ha ingresado el mes OCTUBRE");
                    break;
                case 11:
                    Console.WriteLine("Usted ha ingresado el mes NOVIEMBRE");
                    break;
                case 12:
                    Console.WriteLine("Usted ha ingresado el mes DICIEMBRE");
                    break;
                default:
                    Console.WriteLine("Usted ha ingresado un numero incorrecto");
                    break;
            }


            Console.WriteLine("\nPresiones una tecla para continuar...");
            Console.ReadKey();








        }
    }
}
