using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPUESTOS_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO PROPUESTO 1.2

            int opcion = 1, contfisica = 0, contmate = 0, aprobm = 0, aprobf = 0, reprobadosm = 0, reprobadosf = 0, nota1, nota2, nota3, materia, salida = 0;
            long legajo;
            float promedio, ptotalmate = 0, ptotalfisica = 0;

            while (salida == 0)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("\nIngrese el numero de legajo del alumno");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine(" \nIngrese el numero de la materia solicitada: \n 1-Matematicas\n 2-Fisica:");
                    materia = int.Parse(Console.ReadLine());
                    if (materia == 1)
                    {
                        contmate++;
                        Console.WriteLine("\nIngrese la nota 1 del alumno");
                        nota1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nota 2 del alumno");
                        nota2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nota 3 del alumno");
                        nota3 = int.Parse(Console.ReadLine());
                        promedio = (nota1 + nota2 + nota3) / 3;
                        if (promedio >= 7) { aprobm++; }
                        else { reprobadosm++; }
                        ptotalmate = ptotalmate + promedio;
                    }
                    else if (materia == 2)
                    {
                        contfisica++;
                        Console.WriteLine("\nIngrese la nota 1 del alumno");
                        nota1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nota 2 del alumno");
                        nota2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nota 3 del alumno");
                        nota3 = int.Parse(Console.ReadLine());
                        promedio = (nota1 + nota2 + nota3) / 3;
                        if (promedio >= 7) { aprobf++; }
                        else { reprobadosf++; }
                        ptotalfisica = ptotalfisica + promedio;
                    }
                    else
                    {
                        Console.WriteLine("El numero de materia no corresponde.");
                    }
                }
                Console.WriteLine("Si desea continuar presione 1 de lo contrario presione 0)");
                salida = int.Parse(Console.ReadLine());
                
            }
            

            ptotalmate = ptotalmate / contmate;
            ptotalfisica = ptotalfisica / contfisica;
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("     \nMATERIA:MATEMATICAS");
            Console.WriteLine($"\nCantidad de alumnos:{contmate}");
            Console.WriteLine($"Cantidad de alumnos aprobados:{aprobm}");
            Console.WriteLine($"Cantidad de alumnos reprobados:{reprobadosm}");
            Console.WriteLine($"Promedio general obtenido:{ptotalmate}");
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("       \nMATERIA:FISICA");
            Console.WriteLine($"\nCantidad de alumnos:{contfisica}");
            Console.WriteLine($"Cantidad de alumnos aprobados:{aprobf}");
            Console.WriteLine($"Cantidad de alumnos reprobados:{reprobadosf}");
            Console.WriteLine($"Promedio general obtenido:{ptotalfisica}");
            Console.WriteLine("\n------------------------------------------------------");

            Console.WriteLine("\nPresione una tecla para finalizar.");
            Console.ReadKey();

        }






    }



}
