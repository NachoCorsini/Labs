using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 5


            int numero = 0; int menorNumero = int.MaxValue;int sumaExceptoMenor = 0;
            float promedio; int opcion = 0; int suma = 0; int cantidad = 0; int cantNumeros = 0;

            Console.WriteLine("Indique cuantos numeror desea ingresar");
            cantNumeros = int.Parse(Console.ReadLine());


            while (cantidad < cantNumeros)
            {

                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());


                

                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }

                suma = suma + numero;

                cantidad++;



            }
            

            sumaExceptoMenor = suma - menorNumero;
            promedio = (float)sumaExceptoMenor / (cantidad - 1);


            
            Console.WriteLine($"El numero menor es {menorNumero}");
            Console.ReadLine();
            Console.WriteLine($"EL promedio de los numeros excepto el menor es: {promedio} ");
            Console.ReadLine();


            Console.WriteLine("Presione 0 para abandonar la aplicacion");
            opcion = int.Parse(Console.ReadLine());

        }
    }
}
