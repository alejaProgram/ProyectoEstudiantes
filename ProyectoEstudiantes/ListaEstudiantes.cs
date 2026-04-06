using System;
using System.Text.RegularExpressions;

namespace ProyectoEstudiantes
{
    public class ListaEstudiantes
    {
        public NodoEstudiante cabeza;

        public ListaEstudiantes()
        {
            cabeza = null;
        }

        private bool EmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }


        private bool CelularValido(string celular)
        {
            if (string.IsNullOrWhiteSpace(celular))
                return false;

            string soloNumeros = Regex.Replace(celular, @"\s", "");
            return Regex.IsMatch(soloNumeros, @"^\d{10,}$");
        }

        public void Agregar(string nombre, string apellido, string direccion, string celular, string email)
        {

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                Console.WriteLine(" El nombre y apellido son obligatorios.");
                return;
            }

            if (!CelularValido(celular))
            {
                Console.WriteLine(" El celular debe contener al menos 10 dígitos numéricos.");
                return;
            }

            if (!EmailValido(email))
            {
                Console.WriteLine(" El email no tiene un formato válido (ej: usuario@dominio.com).");
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
            Console.WriteLine($"{"Código",-6} {"Nombre",-20} {"Celular",-15} {"Email",-25}");
            Console.WriteLine(new string('-', 70));
            
            while (actual != null)
            {
                Console.WriteLine($"{actual.Datos.Codigo,-6} {actual.Datos.Nombre + " " + actual.Datos.Apellido,-20} {actual.Datos.Celular,-15} {actual.Datos.Email,-25}");
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
                Console.WriteLine($"Estudiante con código {codigo} eliminado correctamente.");
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
                Console.WriteLine($"Estudiante con código {codigo} no encontrado.");
                return;
            }

            anterior.Siguiente = actual.Siguiente;
            Console.WriteLine($"Estudiante con código {codigo} eliminado correctamente.");
        }
    }
}