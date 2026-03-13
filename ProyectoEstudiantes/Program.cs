using System;

namespace SistemaGestionEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEstudiantes listaEstudiantes = new ListaEstudiantes();
            int opcion;

            do
            {
                Console.WriteLine("=== SISTEMA DE GESTIÓN DE ESTUDIANTES Y MATERIAS ===");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Listar estudiantes");
                Console.WriteLine("3. Buscar estudiante");
                Console.WriteLine("4. Eliminar estudiante");
                Console.WriteLine("5. Gestionar materias");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // Agregar estudiante
                            break;
                        case 2:
                            // Listar estudiantes
                            break;
                        case 3:
                            // Buscar estudiante
                            break;
                        case 4:
                            // Eliminar estudiante
                            break;
                        case 5:
                            // Gestionar materias
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del sistema...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    opcion = 0;
                }

                Console.WriteLine();
            } while (opcion != 6);
        }
    }
}
