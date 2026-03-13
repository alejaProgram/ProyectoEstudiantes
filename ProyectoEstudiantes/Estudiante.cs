namespace SistemaGestionEstudiantes
{
    public class Estudiante
    {
        public int codigo;
        public string nombre;
        public string apellido;
        public string direccion;
        public string celular;
        public string email;
        public ListaMaterias listaMaterias;

        public Estudiante()
        {
            listaMaterias = new ListaMaterias();
        }
    }
}
