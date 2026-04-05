using System;

namespace ProyectoEstudiantes
{
    public class ListaEstudiantes
    {
        public NodoEstudiante cabeza;

        public ListaEstudiantes()
        {
            cabeza = null;
        }
        public void Agregar(string nombre, string apellido, string direccion, string celular, string email)
        {

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                Console.WriteLine(" El nombre y apellido son obligatorios.");
                return;
            }

            int codigo = 1;

            if (cabeza != null)
            {
                NodoEstudiante temp = cabeza;

                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }

                codigo = temp.Datos.Codigo + 1;
            }

            Estudiante nuevoEstudiante = new Estudiante(codigo, nombre, apellido, direccion, celular, email);

            NodoEstudiante nuevoNodo = new NodoEstudiante(nuevoEstudiante);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoEstudiante actual = cabeza;

                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevoNodo;
            }

            Console.WriteLine($" Estudiante '{nombre} {apellido}' agregado con éxito con código: {codigo}");
        }

        public void Listar()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }

            NodoEstudiante actual = cabeza;
            Console.WriteLine("\n=== LISTA DE ESTUDIANTES ===");
            
            while (actual != null)
            {
                Console.WriteLine($"Código: {actual.Datos.Codigo}");
                Console.WriteLine($"Nombre: {actual.Datos.Nombre} {actual.Datos.Apellido}");
                Console.WriteLine($"Dirección: {actual.Datos.Direccion}");
                Console.WriteLine($"Celular: {actual.Datos.Celular}");
                Console.WriteLine($"Email: {actual.Datos.Email}");
                Console.WriteLine("----------------------------------------");
                actual = actual.Siguiente;
            }
        }

        public Estudiante Buscar(int codigo)
        {
            NodoEstudiante actual = cabeza;
            
            while (actual != null)
            {
                if (actual.Datos.Codigo == codigo)
                {
                    return actual.Datos;
                }
                actual = actual.Siguiente;
            }
            
            return null;
        }

        public void Eliminar(int codigo)
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }

            if (cabeza.Datos.Codigo == codigo)
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine($"Estudiante con código {codigo} eliminado.");
                return;
            }

            NodoEstudiante actual = cabeza;
            NodoEstudiante anterior = null;

            while (actual != null && actual.Datos.Codigo != codigo)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual == null)
            {
                Console.WriteLine("Estudiante no encontrado.");
                return;
            }

            anterior.Siguiente = actual.Siguiente;
            Console.WriteLine($"Estudiante con código {codigo} eliminado.");
        }
    }
}