using System;

namespace ProyectoEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEstudiantes lista = new ListaEstudiantes();
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTIÓN DE ESTUDIANTES Y MATERIAS ===");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Listar estudiantes");
                Console.WriteLine("3. Buscar estudiante");
                Console.WriteLine("4. Eliminar estudiante");
                Console.WriteLine("5. Gestionar materias");
                Console.WriteLine("6. Salir");

                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                    Pausa();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n--- AGREGAR ESTUDIANTE ---");

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

                        Pausa();
                        break;

                    case 2:
                        Console.WriteLine("\n--- LISTA DE ESTUDIANTES ---");
                        lista.Listar();
                        Pausa();
                        break;

                    case 3:
                        Console.WriteLine("\n--- BUSCAR ESTUDIANTE ---");

                        Console.Write("Código: ");
                        if (int.TryParse(Console.ReadLine(), out int codBuscar))
                        {
                            Estudiante est = lista.Buscar(codBuscar);

                            if (est != null)
                            {
                                Console.WriteLine($"Nombre: {est.Nombre} {est.Apellido}");
                            }
                            else
                            {
                                Console.WriteLine("Estudiante no encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Código inválido.");
                        }

                        Pausa();
                        break;

                    case 4:
                        Console.WriteLine("\n--- ELIMINAR ESTUDIANTE ---");

                        Console.Write("Código: ");
                        if (int.TryParse(Console.ReadLine(), out int codEliminar))
                        {
                            lista.Eliminar(codEliminar);
                        }
                        else
                        {
                            Console.WriteLine("Código inválido.");
                        }

                        Pausa();
                        break;

                    case 5:
                        Console.WriteLine("\n--- GESTIONAR MATERIAS ---");

                        Console.Write("Código del estudiante: ");
                        if (int.TryParse(Console.ReadLine(), out int cod))
                        {
                            Estudiante estudiante = lista.Buscar(cod);

                            if (estudiante != null)
                            {
                                Console.WriteLine("Aquí se gestionan las materias (pendiente)");

                            }
                            else
                            {
                                Console.WriteLine("El estudiante no existe.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Código inválido.");
                        }

                        Pausa();
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Pausa();
                        break;
                }

            } while (opcion != 6);
        }
        static void Pausa()
        {
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}