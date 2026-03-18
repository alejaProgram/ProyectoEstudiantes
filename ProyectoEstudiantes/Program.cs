using System;

namespace ProyectoEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEstudiantes lista = new ListaEstudiantes();
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Listar estudiantes");
                Console.WriteLine("3. Buscar estudiante");
                Console.WriteLine("4. Eliminar estudiante");
                Console.WriteLine("5. Gestionar materias");
                Console.WriteLine("6. Salir");

                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Apellido: ");
                        string apellido = Console.ReadLine();

                        Console.Write("Dirección: ");
                        string direccion = Console.ReadLine();

                        Console.Write("Celular: ");
                        string celular = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        lista.Agregar(nombre, apellido, direccion, celular, email);
                        break;

                    case 2:
                        lista.Listar();
                        break;

                    case 3:
                        Console.Write("Código: ");
                        int codBuscar = int.Parse(Console.ReadLine());

                        Estudiante est = lista.Buscar(codBuscar);

                        if (est != null)
                        {
                            Console.WriteLine($"Nombre: {est.Nombre} {est.Apellido}");
                        }
                        else
                        {
                            Console.WriteLine("Estudiante no encontrado.");
                        }
                        break;

                    case 4:
                        Console.Write("Código: ");
                        int codEliminar = int.Parse(Console.ReadLine());

                        lista.Eliminar(codEliminar);
                        break;

                    case 5:
                        Console.Write("Código del estudiante: ");
                        int cod = int.Parse(Console.ReadLine());

                        Estudiante estudiante = lista.Buscar(cod);

                        if (estudiante != null)
                        {
                            // estudiante.ListaMaterias.MenuMaterias();

                            Console.WriteLine("Aquí se gestionan las materias");
                        }
                        else
                        {
                            Console.WriteLine("El estudiante no existe.");
                        }
                        break;

                }

            } while (opcion != 6);
        }
    }
}