using System;

namespace MiAplicacionDeTareas
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Concluida { get; set; }

        public Tarea(string nombre, string descripcion, DateTime fechaVencimiento)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
            Concluida = false;
        }
    }
}
