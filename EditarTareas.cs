using System;
using System.Collections.Generic;

namespace MiAplicacionDeTareas
{
    public class EditarTareas
    {
        private List<Tarea> tareas;

        public EditarTareas(List<Tarea> tareas)
        {
            this.tareas = tareas;
        }

        public void Ejecutar(int indice)
        {
            Tarea tarea = tareas[indice];

            Console.WriteLine("Opciones de Edición:");
            Console.WriteLine("1. Marcar como concluida");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    tarea.Concluida = true;
                    Console.WriteLine("La tarea ha sido marcada como concluida.");
                    break;
                case "2":
                    tareas.RemoveAt(indice);
                    Console.WriteLine("La tarea ha sido eliminada.");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
