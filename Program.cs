using System;
using System.Collections.Generic;

namespace MiAplicacionDeTareas
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            List<Tarea> tareas = new List<Tarea>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Crear Tarea");
                Console.WriteLine("2. Mostrar Tareas");
                Console.WriteLine("3. Editar Tareas");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearTareas creador = new CrearTareas(tareas);
                        creador.Ejecutar();
                        break;
                    case "2":
                        MostrarTareas mostrador = new MostrarTareas(tareas);
                        mostrador.Ejecutar();
                        break;
                    case "3":
                        Console.Write("Ingrese el número de la tarea que desea editar: ");
                        int indice = int.Parse(Console.ReadLine()) - 1;
                        if (indice >= 0 && indice < tareas.Count)
                        {
                            EditarTareas editor = new EditarTareas(tareas);
                            editor.Ejecutar(indice);
                        }
                        else
                        {
                            Console.WriteLine("Número de tarea no válido.");
                        }
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
