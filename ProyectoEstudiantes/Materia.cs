namespace ProyectoEstudiantes
{
    public class Materia
    {
        public string nombre;
        public double nota;

        public Materia()
        {
            nombre = "";
            nota = 0.0;
        }

        public Materia(string nombreMateria, double notaMateria)
        {
            nombre = nombreMateria;
            nota = notaMateria;
        }
    }
}
