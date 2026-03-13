namespace SistemaGestionEstudiantes
{
    public class NodoEstudiante
    {
        public Estudiante dato;
        public NodoEstudiante siguiente;

        public NodoEstudiante()
        {
            dato = null;
            siguiente = null;
        }

        public NodoEstudiante(Estudiante estudiante)
        {
            dato = estudiante;
            siguiente = null;
        }
    }
}
