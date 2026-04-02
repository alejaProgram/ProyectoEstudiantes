using System;

namespace SistemaGestionEstudiantes
{
    public class Materia
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Materia()
        {
            Nombre = "";
            Nota = 0.0;
        }

        public Materia(string nombreMateria, double notaMateria)
        {
            Nombre = nombreMateria;
            Nota = notaMateria;
        }

        public void MostrarMateria()
        {
            Console.WriteLine("Materia: " + Nombre + " | Nota: " + Nota);
        }
    }
}
