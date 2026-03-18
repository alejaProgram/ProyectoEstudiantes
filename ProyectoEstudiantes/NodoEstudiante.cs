namespace ProyectoEstudiantes
{
    public class NodoEstudiante
    {
        public Estudiante Datos;
        public NodoEstudiante Siguiente;

        public NodoEstudiante(Estudiante datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }
}