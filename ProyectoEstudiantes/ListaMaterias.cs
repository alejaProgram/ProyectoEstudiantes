using System;

namespace ProyectoEstudiantes
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
            if (ExisteMateria(nombre))
            {
                Console.WriteLine("La materia ya existe");
                return;
            }

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

            Console.WriteLine("Materia agregada");
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
                if (actual.dato.Nombre == nombre)
                {
                    actual.dato.Nota = nuevaNota;
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

            if (cabeza.dato.Nombre == nombre)
            {
                cabeza = cabeza.siguiente;
                Console.WriteLine("Materia eliminada");
                return;
            }

            NodoMateria actual = cabeza;

            while (actual.siguiente != null)
            {
                if (actual.siguiente.dato.Nombre == nombre)
                {
                    actual.siguiente = actual.siguiente.siguiente;
                    
                    Console.WriteLine("Materia eliminada");
                    return;
                }

                actual = actual.siguiente;
            }

            Console.WriteLine("Materia no encontrada");
        }

        public bool ExisteMateria(string nombre)
        {
            NodoMateria actual = cabeza;

            while (actual != null)
            {
                if(actual.dato.Nombre == nombre)
                {
                    return true;
                }

                actual = actual.siguiente;
            }

            return false;
        }
    }
}

