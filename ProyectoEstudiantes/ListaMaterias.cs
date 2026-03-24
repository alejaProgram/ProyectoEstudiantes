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

        public void ModificarNota(string nombre, double nuevaNota)
        {
            NodoMateria actual = cabeza;

            while (actual != null)
            {
                if (actual.dato.nombre == nombre)
                {
                    actual.dato.nota = nuevaNota;
                    Console.WriteLine("Nota actualizada");
                    return;
                }

                actual = actual.siguiente;
            }

            Console.WriteLine("Materia no encontrada");
        }

        public void EliminarMateria(string nombre)
        {
            if (cabeza == null)
            {
                Console.WriteLine("Lista vacia");
                return;
            }

            if (cabeza.dato.nombre == nombre)
            {
                cabeza = cabeza.siguiente;
                Console.WriteLine("Materia eliminada");
                return;
            }

            NodoMateria actual = cabeza;

            while (actual.siguiente != null)
            {
                if (actual.siguiente.dato.nombre == nombre)
                {
                    actual.siguiente = actual.siguiente.siguiente;

                    Console.WriteLine("Materia eliminada");
                    return;
                }

                actual = actual.siguiente;
            }

            Console.WriteLine("Materia no encontrada");
        }
    }
}

