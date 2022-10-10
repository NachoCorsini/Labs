using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 10 Y EJERCICIO PROPUESTO N°1


            int mozos = 0;
            int cantPlatos1 = 0; int cantPlatos2 = 0;
            int cantMilanesas = 0; int cantPizza = 0; int cantEspecial = 0;
            int cantMilanesas2 = 0; int cantPizza2 = 0; int cantEspecial2 = 0;
            int salir = 1; int menu = 0;


            do
            {
                Console.WriteLine("Ingrese 1 o 2 para seleccionar mozo");
                mozos = int.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione 1) MILANESAS C/ FRITAS  2) PIZZA   3) PLATO ESPECIAL");
                menu = int.Parse(Console.ReadLine());

                switch (mozos)
                {
                    case 1:
                        switch (menu)
                        {
                            case 1:
                                cantMilanesas++;
                                break;
                            case 2:
                                cantPizza++;
                                break;
                            case 3:
                                cantEspecial++;
                                break;

                        }
                        break;

                    case 2:
                        switch (menu)
                        {
                            case 1:
                                cantMilanesas2++;
                                break;
                            case 2:
                                cantPizza2++;
                                break;
                            case 3:
                                cantEspecial2++;
                                break;

                        }
                        break;
 
                }


                Console.WriteLine("¿Desea continuar cargando menues? seleccione 1 PARA SEGUIR ó 2 PARA SALIR");
                salir = int.Parse(Console.ReadLine());  

            } while (salir == 1);

            cantPlatos1 = cantMilanesas + cantPizza + cantEspecial;
            cantPlatos2 = cantMilanesas2 + cantPizza2 + cantEspecial2;

            if (cantPlatos1 > cantPlatos2) 
            {
                Console.WriteLine($"\nEl mozo que mas sirvió platos fue el MOZO 1");
                Console.WriteLine($"\nCantidad de platos servidos: {cantPlatos1}");
                Console.WriteLine($"Cantidad de platos: MILANESAS CON PAPAS FRITAS {cantMilanesas}");
                Console.WriteLine($"Cantidad de platos: PIZZA {cantPizza}");
                Console.WriteLine($"Cantidad de platos: PLATO ESPECIAL {cantEspecial}");
            }
            else
            {
                Console.WriteLine($"\nEl mozo que mas sirvió platos fue el MOZO 2");
                Console.WriteLine($"\nCantidad de platos servidos: {cantPlatos2}");
                Console.WriteLine($"Cantidad de platos: MILANESAS CON PAPAS FRITAS {cantMilanesas2}");
                Console.WriteLine($"Cantidad de platos: PIZZA {cantPizza2}");
                Console.WriteLine($"Cantidad de platos: PLATO ESPECIAL {cantEspecial2}");
            }
            Console.ReadKey();


        }
    }
}
