
namespace SistemaGestionEstudiantes
{
    public class NodoMateria
    {
        public Materia dato;
        public NodoMateria siguiente;

        public NodoMateria()
        {
            dato = null;
            siguiente = null;
        }

        public NodoMateria(Materia materia)
        {
            dato = materia;
            siguiente = null;
        }
    }
}
