namespace ProyectoEstudiantes
{
    public class Estudiante
    {
        public int Codigo;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public string Celular;
        public string Email;

        // Referencia a materias 
        public ListaMaterias ListaMaterias;

        public Estudiante(int codigo, string nombre, string apellido,
                          string direccion, string celular, string email)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Celular = celular;
            Email = email;

            ListaMaterias = new ListaMaterias(); // conexión
        }
    }
}