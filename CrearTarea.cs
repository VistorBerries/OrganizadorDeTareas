using System;
using System.Collections.Generic;

namespace MiAplicacionDeTareas
{
    public class CrearTareas
    {
        private List<Tarea> tareas;

        public CrearTareas(List<Tarea> tareas)
        {
            this.tareas = tareas;
        }

        public void Ejecutar()
        {
            bool agregarOtraTarea = true;

            while (agregarOtraTarea)
            {
                Console.Write("Ingrese Nombre de la tarea: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese una descripción: ");
                string descripcion = Console.ReadLine();
                Console.Write("Indique fecha de vencimiento (yyyy-MM-dd): ");
                DateTime fechaVencimiento = DateTime.Parse(Console.ReadLine());

                Tarea nuevaTarea = new Tarea(nombre, descripcion, fechaVencimiento);
                tareas.Add(nuevaTarea);

                Console.WriteLine($"Tarea \"{nombre}\" ingresada con éxito.");

                Console.WriteLine("Desea ingresar otra tarea? 1. SI 2. NO");
                string respuesta = Console.ReadLine();
                if (respuesta != "1")
                {
                    agregarOtraTarea = false;
                }
            }
        }
    }
}
