using System;
using System.Collections.Generic;

namespace MiAplicacionDeTareas
{
    public class MostrarTareas
    {
        private List<Tarea> tareas;

        public MostrarTareas(List<Tarea> tareas)
        {
            this.tareas = tareas;
        }

        public void Ejecutar()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas para mostrar.");
                return;
            }

            Console.WriteLine("Lista de Tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                Tarea tarea = tareas[i];
                string estado = tarea.Concluida ? "Completada" : "Pendiente";
                Console.WriteLine($"{i + 1}. Nombre: {tarea.Nombre}, Descripción: {tarea.Descripcion}, Fecha de Vencimiento: {tarea.FechaVencimiento.ToShortDateString()}, Estado: {estado}");
            }

            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Editar");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
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
            }
        }
    }
}
