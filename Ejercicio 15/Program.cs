using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 15. Crea un programa que cumpla con las siguiente especificaciones: 
             * - Tenga una función que dada cantidad de segundos devuelva un tiempo dado en horas, minutos y segundos. 
             * - Tenga una función que dada cantidad de horas, minutos y segundos devuelva un tiempo dado en segundos. 
             * - En el programa principal habrá un menú donde se pueda elegir la opción de convertir a segundos, convertir a horas, minutos y segundos 
             * o salir del programa. 
             */

            string opcion = "";

            // Bucle que muestra el menú hasta que el usuario elija salir
            do
            {
                Console.WriteLine("Pulsa 1 para convertir segundos a horas, minutos y segundos");
                Console.WriteLine("Pulsa 2 para convertir horas, minutos y segundos a segundos");
                Console.WriteLine("Pulsa S para salir");

                // Lee la opción seleccionada por el usuario
                opcion = Console.ReadLine();

                // Evalúa la opción seleccionada
                switch (opcion)
                {
                    case "1":
                        opcion1(); // Llama al subprograma para convertir segundos a horas, minutos y segundos
                        break;

                    case "2":
                        opcion2(); // Llama al subprograma para convertir horas, minutos y segundos a segundos
                        break;

                    case "S":
                    case "s":
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    // Mensaje de error si la opción no es válida
                    default:
                        Console.WriteLine("Opción incorrecta, por favor elija una opción entre 1, 2 o S");
                        break;
                }
            } while (opcion != "S" && opcion != "s"); // El programa continúa hasta que el usuario elija salir

        }

        // Subprograma para convertir segundos a horas, minutos y segundos
        public static void opcion1()
        {
            Console.WriteLine("Escriba el número de segundos a transformar:");
            int segundos = int.Parse(Console.ReadLine()); // Lee el número de segundos ingresado por el usuario

            // Cálculos para convertir segundos a horas, minutos y segundos
            int horas = segundos / 3600; // Calcula el número de horas
            int aux_segundos = segundos % 3600; // Obtiene los segundos restantes después de calcular las horas
            int minutos = aux_segundos / 60; // Calcula el número de minutos
            aux_segundos = aux_segundos % 60; // Obtiene los segundos restantes después de calcular los minutos

            // Muestra el resultado al usuario
            Console.WriteLine("\n");
            Console.WriteLine("La cantidad de segundos es " + horas + " horas," + minutos + " minutos" + aux_segundos + " segundos.");
            Console.WriteLine("\n");
        }

        // Subprograma para convertir horas, minutos y segundos a segundos
        public static void opcion2()
        {
            // Solicita los datos al usuario
            Console.WriteLine("Introduce el número de horas");
            int horas = int.Parse(Console.ReadLine()); // Lee el número de horas

            Console.WriteLine("Introduce el número de minutos");
            int minutos = int.Parse(Console.ReadLine()); // Lee el número de minutos

            Console.WriteLine("Introduce el número de segundos");
            int segundos = int.Parse(Console.ReadLine()); // Lee el número de segundos

            // Calcula el total de segundos
            Console.WriteLine("\n");
            Console.WriteLine("La cantidad de segundos es: " + ((horas * 3600) + (minutos * 60) + segundos));
            Console.WriteLine("\n");
        }
    }
}
