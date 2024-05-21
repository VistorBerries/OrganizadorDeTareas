Resolver problemas computacionales bajo cada paradigma. 
Proponer un programa para gestionar una lista de tareas, 
este debe permitir al usuario realizar:
• Agregar una nueva tarea a la lista, incluyendo información como título, descripción y fecha de vencimiento.
• Marcar una tarea como completada.
• Eliminar una tarea de la lista.
• Mostrar la lista de todas las tareas, indicando su estado (pendiente o completada) y la fecha de vencimiento.
• Salir del programa.

Explicación del Código:
Este código aplica la programación modular y sigue las indicaciones entregadas para trabajaren C# para consola de Windows.
•	Clase Tarea: Define una tarea con propiedades para el nombre, descripción, fecha de vencimiento y estado de conclusión.
•	Clase CrearTareas: Administra una lista de tareas, con métodos para crear nuevas tareas (CrearNuevaTarea), mostrar tareas (MostrarTareas) y editar tareas (EditarTarea).
•	Método CrearNuevaTarea: Permite al usuario ingresar detalles de una nueva tarea y preguntará si desea agregar otra tarea.
•	Método MostrarTareas: Muestra la lista de tareas y ofrece la opción de editar una tarea específica.
•	Método EditarTarea: Permite marcar una tarea como concluida o eliminarla.
•	Clase Programa y Método Main: Gestiona el flujo principal del programa, permitiendo al usuario navegar entre las opciones de crear, mostrar, y editar tareas, o salir del programa.
