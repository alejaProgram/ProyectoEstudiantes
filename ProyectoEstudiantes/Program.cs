using System;

namespace ProyectoEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                                    MenuMaterias(estudiante);
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
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error inesperado: {ex.Message}");
                Console.WriteLine("El sistema se cerrará para evitar daños en los datos.");
                Pausa();
            }
        }

        static void Pausa()
        {
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void MenuMaterias(Estudiante estudiante)
        {
            int opcionMateria = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"=== GESTIÓN DE MATERIAS - {estudiante.Nombre} {estudiante.Apellido} (Código: {estudiante.Codigo}) ===");
                Console.WriteLine("1. Agregar materia");
                Console.WriteLine("2. Listar materias");
                Console.WriteLine("3. Modificar nota");
                Console.WriteLine("4. Eliminar materia");
                Console.WriteLine("5. Volver al menú principal");

                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcionMateria))
                {
                    Console.WriteLine("Opción inválida.");
                    Pausa();
                    continue;
                }

                switch (opcionMateria)
                {
                    case 1:
                        Console.WriteLine("\n--- AGREGAR MATERIA ---");
                        Console.Write("Nombre de la materia: ");
                        string nombreMateria = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nombreMateria))
                        {
                            Console.Write("Nota (0-10): ");
                            if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 10)
                            {
                                estudiante.ListaMaterias.AgregarMateria(nombreMateria, nota);
                            }
                            else
                            {
                                Console.WriteLine("Nota inválida. Debe ser un número entre 0 y 10.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El nombre de la materia es obligatorio.");
                        }
                        Pausa();
                        break;

                    case 2:
                        Console.WriteLine("\n--- LISTA DE MATERIAS ---");
                        estudiante.ListaMaterias.ListarMaterias();
                        Pausa();
                        break;

                    case 3:
                        Console.WriteLine("\n--- MODIFICAR NOTA ---");
                        Console.Write("Nombre de la materia: ");
                        string materiaModificar = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(materiaModificar))
                        {
                            Console.Write("Nueva nota (0-10): ");
                            if (double.TryParse(Console.ReadLine(), out double nuevaNota) && nuevaNota >= 0 && nuevaNota <= 10)
                            {
                                estudiante.ListaMaterias.ModificarNota(materiaModificar, nuevaNota);
                            }
                            else
                            {
                                Console.WriteLine("Nota inválida. Debe ser un número entre 0 y 10.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El nombre de la materia es obligatorio.");
                        }
                        Pausa();
                        break;

                    case 4:
                        Console.WriteLine("\n--- ELIMINAR MATERIA ---");
                        Console.Write("Nombre de la materia: ");
                        string materiaEliminar = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(materiaEliminar))
                        {
                            estudiante.ListaMaterias.EliminarMateria(materiaEliminar);
                        }
                        else
                        {
                            Console.WriteLine("El nombre de la materia es obligatorio.");
                        }
                        Pausa();
                        break;

                    case 5:
                        Console.WriteLine("Volviendo al menú principal...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Pausa();
                        break;
                }

            } while (opcionMateria != 5);
        }
    }
}