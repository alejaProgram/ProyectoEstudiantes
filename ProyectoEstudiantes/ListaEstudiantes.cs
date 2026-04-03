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

            Console.WriteLine($"Estudiante agregado con código: {codigo}");
        }
    }
}