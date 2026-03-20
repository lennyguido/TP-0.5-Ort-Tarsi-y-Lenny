namespace TP0._5
{
    public class Curso
    {
        private List<Alumno> alumnos;

        public Curso()
        {
            alumnos = new List<Alumno>();
        }

        public void agregarAlumno(int dni, string nombre, double cantidadFaltas)
        {
            string resultado = buscarAlumnoxDni(dni);

            if (resultado == "No se ha encontrado.")
            {
                Alumno a = new Alumno(dni, nombre, cantidadFaltas);
                alumnos.Add(a);
            }
            else
            {
                Console.WriteLine("No se puede agregar, el alumno ya existe.");
            }
        }

        public string buscarAlumnoxDni(int dni)
        {
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].GetDni() == dni)
                {
                    return "Se ha encontrado, el alumno es: " + alumnos[i].getNombre();
                }
            }

            return "No se ha encontrado.";
        }

        public void AgregarFaltas(int dni, int faltas)
        {
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].GetDni() == dni)
                {
                    if (faltas == 1)
                        alumnos[i].SumarFaltas(1);
                    else
                        alumnos[i].SumarFaltas(0.5);

                    return;
                }
            }

            Console.WriteLine("Alumno no encontrado.");
        }

        public List<string> mostrarAlumnos()
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < alumnos.Count; i++)
            {
                lista.Add(alumnos[i].getNombre());
            }

            return lista;
        }

        public List<string> mostrarLibres()
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].GetCantidadFaltas() > 15)
                {
                    lista.Add(alumnos[i].getNombre());
                }
            }

            return lista;
        }
    }
}