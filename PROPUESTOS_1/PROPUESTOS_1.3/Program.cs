using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPUESTOS_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO PROPUESTO 1.3

            int lunes = 0, martes = 0, miercoles = 0, jueves = 0, viernes = 0, sabado = 0, domingo = 0;

            int NumeroEmpleado = 1;
            int NumeroSemana = 1;

            double mejorVenta1 = 0;
            double mejorVenta2 = 0;
            string mejorVendedor = "";
            double mejorDia1 = 0;
            double mejorDia2 = 0;
            int cant1 = 0;
            int cant2 = 0;

            double venta = 0;

            

            while (NumeroEmpleado != 0)
            {
                Console.WriteLine("Ingrese el Numero de Vendedor. 1 o 2. En su defecto presione 0 para salir:");

                NumeroEmpleado = int.Parse(Console.ReadLine());

                if (NumeroEmpleado != 0)
                {
                    
                    Console.WriteLine("Ingrese el Numero del dia de la Semana");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("0- Salir.");
                    Console.WriteLine("1- Lunes.");
                    Console.WriteLine("2- Martes.");
                    Console.WriteLine("3- Miercoles.");
                    Console.WriteLine("4- Jueves.");
                    Console.WriteLine("5- Viernes.");
                    Console.WriteLine("6- Sabado.");
                    Console.WriteLine("7- Domingo.");
                    Console.WriteLine("-------------------------------");

                    NumeroSemana = int.Parse(Console.ReadLine());
                    
                    if (NumeroSemana != 0)
                    {
                        Console.WriteLine("Ingrese el Valor de la Venta:");
                        Console.WriteLine("-------------------------------");

                        venta = double.Parse(Console.ReadLine());
                        
                    }


                    if (NumeroEmpleado == 1)
                    {

                        if (mejorVenta1 < venta)
                        {
                            mejorVenta1 = venta;

                            cant1++;
                            mejorDia1 = NumeroSemana;
                        }
                    }
                    if (NumeroEmpleado == 2)
                    {
                        if (mejorVenta2 < venta)
                        {
                            mejorVenta2 = venta;

                            cant2++;
                            mejorDia2 = NumeroSemana;
                        }


                    }

                    switch (NumeroSemana)
                    {
                        case 0:
                            break;
                        case 1:
                            lunes++;
                            break;
                        case 2:
                            martes++;
                            break;
                        case 3:
                            miercoles++;
                            break;
                        case 4:
                            jueves++;
                            break;
                        case 5:
                            viernes++;
                            break;
                        case 6:
                            sabado++;
                            break;
                        case 7:
                            domingo++;
                            break;
                        default:
                            Console.WriteLine("Ingrese un Numero del 0 al 7.");
                            Console.ReadKey();
                            break;
                    }


                }
            }

            int valorsemana = 0;
            String diaSemana = "";
            for (int i = 0; i < 7; i++)
            {

                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        if (lunes > valorsemana) { valorsemana = lunes; diaSemana = "LUNES"; }
                        break;
                    case 2:
                        if (martes > valorsemana) { valorsemana = martes; diaSemana = "MARTES"; }
                        break;
                    case 3:
                        if (miercoles > valorsemana) { valorsemana = miercoles; diaSemana = "MIERCOLES"; }
                        break;
                    case 4:
                        if (jueves > valorsemana) { valorsemana = jueves; diaSemana = "JUEVES"; }
                        break;
                    case 5:
                        if (viernes > valorsemana) { valorsemana = viernes; diaSemana = "VIERNES"; }
                        break;
                    case 6:
                        if (sabado > valorsemana) { valorsemana = sabado; diaSemana = "SABADO"; }
                        break;
                    case 7:
                        if (domingo > valorsemana) { valorsemana = domingo; diaSemana = "DOMINGO"; }
                        break;
                    default:
                        break;
                }
            }
            if (cant1 > cant2)
            {
                mejorVendedor = "1";
            }
            if (cant1 < cant2)
            {
                mejorVendedor = "2";
            }


            
            Console.WriteLine($"\nVendedor con mayor cantidad de Ventas: {mejorVendedor}");
            Console.WriteLine("\n------------------------------------------------\n");

            Console.WriteLine("Numero de vendedor: 1 ");
            Console.WriteLine($"Cantidad de Ventas: {cant1}");
            Console.WriteLine("\n------------------------------------------------\n");
            Console.WriteLine("Numero de vendedor: 2 ");
            Console.WriteLine($"Dia de la venta con mayor Importe: {mejorDia2}");
            Console.WriteLine($"Importe de la Mayor venta: {mejorVenta2}.");
            Console.WriteLine($"Dias de mayor Ventas: {diaSemana}.");
            Console.WriteLine("\n------------------------------------------------\n");
            Console.WriteLine("\nPresione una tecla para finalizar.");
            Console.ReadKey();









        }



    }
}
