using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0; float nota2 = 0; float nota3 = 0; float sumaNota = 0; int salir = 0;
            float promedio = 0; int legajo = 0; int cantAlumnos = 0; int i = 1;
            float promMayor = 0; float promMenor = 0; int legajoMayor = 0; int legajoMenor = 0;
            float sumaGralNotas = 0; float promGeneral = 0;


            do
            {
                Console.WriteLine("\nIngrese numero de legajo del alumno");
                legajo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese primer nota");
                nota1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segunda nota");
                nota2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercera nota");
                nota3 = float.Parse(Console.ReadLine());

                sumaNota = nota1 + nota2 + nota3;
                promedio = sumaNota / 3;

                if (i == 1)
                {
                    promMayor = promedio;
                    promMenor = promedio;
                    legajoMayor = legajo;
                    legajoMenor = legajo;
                }
                else 
                {
                    if (promedio > promMayor)
                    {
                        promMayor = promedio;
                        legajoMayor = legajo;
                    }
                    if (promedio < promMenor)
                    {
                        promMenor = promedio;
                        legajoMenor = legajo;
                    }
                
                
                
                }
                i++;

                cantAlumnos++;
                sumaGralNotas = sumaGralNotas + sumaNota;





                Console.WriteLine("presione 1- CONTINUAR ****** 0- SALIR");
                salir = int.Parse(Console.ReadLine());  

            } while (salir != 0);

            promGeneral = sumaGralNotas / (cantAlumnos * 3); //promGeneral = sumaGralNotas / 9

            Console.WriteLine($"Numero legajo mayor promedio {legajoMayor}, promedio obtenido {promMayor}");
            Console.WriteLine("*******************************");
            Console.WriteLine($"Numero de legajo menor promedio {legajoMenor}, promedio obtenido {promMenor}");
            Console.WriteLine("*******************************");
            Console.WriteLine($"Cantidad de alumnos cargados {cantAlumnos}");
            Console.WriteLine("*******************************");
            Console.WriteLine($"promedio general {promGeneral}");




            Console.ReadKey();
        }
    }
}
