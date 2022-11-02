using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Yellow;

            string nombre;
        menu:
            Console.Clear();
            int opcion = 0;
            Console.WriteLine("Bienvenido quien entrara al sistema ");
            nombre = Console.ReadLine();
            Console.WriteLine("       Bienvenido al sistema " + nombre);
            Console.WriteLine("       Ingrese entre las opciones");
            Console.WriteLine("       1. Ventilacion");
            Console.WriteLine("       2. Calefaccion");
            Console.WriteLine("       3. Iluminacion");
            Console.WriteLine("       4. Panel de Control");
            Console.WriteLine("       5. Salir ");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    int temperatura;
                    int i = 0;
                    string hora;

                    Console.WriteLine("Bienvenido al sistema de ventilacion");
                    Console.WriteLine("Ingrese la hora");
                    hora = Console.ReadLine();
                    Console.WriteLine("Ingrese la temperatura exterior de la casa");
                    temperatura = Int32.Parse(Console.ReadLine());



                    for (i = 0; i < 1; i++)
                    {
                        if (temperatura == 70)
                        {
                            Console.WriteLine("la temperatura esta en su nivel optimo");

                        }
                        else
                        {
                            if (temperatura >= 70)
                            {
                                Console.WriteLine("La hora es " + hora);
                                Console.WriteLine("la temperatura esta muy alta de la desea");
                                Console.WriteLine("la temperatura se nivelara al 70%");
                            }
                            else
                            {
                                if (temperatura <= 70)
                                {
                                    Console.WriteLine("La hora es " + hora);
                                    Console.WriteLine("la temperatura esta muy baja de la desea");
                                    Console.WriteLine("la temperatura se nivelara al 70%");
                                }
                            }
                        }
                    }
                    Console.ReadKey();
                    goto menu;
                    break;

                case 2:
                    Console.WriteLine("Bienvenido al sistema de calefaccion");
                    int subir;
                    int bajar;
                    int grados;
                    int f = 0;
                    string habitacion;
                    Console.WriteLine("Ingrese la habitacion que se encuentra");
                    habitacion = Console.ReadLine();
                    Console.WriteLine("Ingrese la temperatura en grados");
                    grados = Int32.Parse(Console.ReadLine());

                    int menu;
                    Console.WriteLine("       Esta adentro de la " + habitacion);
                    Console.WriteLine("       1. Si");
                    Console.WriteLine("       2. No");

                    menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("El radiador de la " + habitacion + " esta encendida");
                            for (f = 0; f < 1; f++)
                            {
                                if (grados == 22)
                                {
                                    Console.WriteLine("Los grados de la habitacion son " + grados);
                                    Console.WriteLine("la temperatura es la deseada");
                                }
                                else
                                {
                                    if (grados >= 22)
                                    {
                                        Console.WriteLine("Los grados de la habitacion son " + grados);
                                        Console.WriteLine("la temperatura esta alta de la deseada");
                                        Console.WriteLine("La temperatura optima es 22");
                                        Console.WriteLine("Bajar la temperatura a la optima");
                                        bajar = Int32.Parse(Console.ReadLine());

                                        if (bajar == 22)
                                        {
                                            Console.WriteLine("la temperatura es la deseada");
                                        }
                                        else
                                        {
                                            if (grados <= 18)
                                            {
                                                Console.WriteLine("Los grados de la habitacion son " + grados);
                                                Console.WriteLine("la temperatura esta muy baja, no es la optima");
                                                Console.WriteLine("La temperatura optima es 22");
                                                Console.WriteLine("subir la temperatura a la optima");
                                                subir = Int32.Parse(Console.ReadLine());

                                                if (subir == 22)
                                                {
                                                    Console.WriteLine("la temperatura es la deseada");

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                                break;

                            case 2:
                            Console.WriteLine("el radiador de la " + habitacion + " esta apagada");

                            break;
                    }
    
                    Console.ReadKey();
                    goto menu;

                    break;

                case 3:
                    Console.WriteLine("Bienvenido al sistema de iluminacion");
                    break;

                case 4:
                    int control = 0;

                    Console.WriteLine("       Bienvenido al panel de control");
                    Console.WriteLine("       1. Sistema de ventilacion");
                    Console.WriteLine("       2. Configuracion de temperatura");

                    control = int.Parse(Console.ReadLine());

                    switch (control)
                    {
                        case 1:
                            Console.WriteLine("Bienvenido al sistema de ventilacion");
                            break;

                        case 2:
                            Console.WriteLine("Bienvenido a la configuracion de la temperatura");
                            break;
                    }
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ingrese una opción válida entre 1 a 5");
                    break;
            }

            Console.ReadKey();
        }
    }
}
