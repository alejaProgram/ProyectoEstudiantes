using System;

namespace SistemaGestionEstudiantes
{
    public class ListaMaterias
    {
        public NodoMateria cabeza;

        public ListaMaterias()
        {
            cabeza = null;
        }

        public void AgregarMateria(string nombre, double nota)
        {
            Materia nuevaMateria = new Materia(nombre, nota);
            NodoMateria nuevoNodo = new NodoMateria(nuevaMateria);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoMateria actual = cabeza;

                 while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = nuevoNodo;
            }
        }
        public void ListarMaterias()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay materias");
                return;
            }

            NodoMateria actual = cabeza;

            while (actual != null)
            {

                actual.dato.MostrarMateria();
                actual = actual.siguiente;    
            }
        }
    }
}

