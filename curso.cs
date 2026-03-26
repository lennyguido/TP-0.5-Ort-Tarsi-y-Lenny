namespace TP0._5
{
    public class Curso
    {
        Dictionary<int, Alumno> dicAlumnos;

        public Curso()
        {
            dicAlumnos = new Dictionary<int, Alumno>();
        }

        public void agregarAlumno(int dni, string nombre, double cantidadFaltas)
        {
            string resultado = buscarAlumnoxDni(dni);

            if (resultado == "No se ha encontrado.")
            {
                Alumno a = new Alumno(dni, nombre, cantidadFaltas);
                dicAlumnos.Add(dni, a);
            }
            else
            {
                Console.WriteLine("No se puede agregar, el alumno ya existe.");
            }
        }

        public string buscarAlumnoxDni(int dni)
        {
           if(dicAlumnos.ContainsKey(dni)){
                return "Se ha encontrado, el alumno es: " +dicAlumnos[dni].getNombre();                                     

           }
           return "No se ha encontrado.";
                             
        }

            
        

        public string AgregarFaltas(int dni, int faltas)
        {
          if(dicAlumnos.ContainsKey(dni)){
              if (faltas == 1){
                  dicAlumnos[dni].SumarFaltas(1);
                  return "se a sumado una falta";
                }
                    else
                    {
                  dicAlumnos[dni].SumarFaltas(0.5);
                  return "se a sumado media falta";
                    }                          
               
                }
                 return "no existe un alumno con ese dni";
            }

          
        

        public List<string> mostrarAlumnos()
        {
            
           
       

            List<string> lista = new List<string>();

            foreach (int clave in dicAlumnos.Keys)
            {
                lista.Add(dicAlumnos[clave].getNombre());
            }
            return lista;
        }

        public List<string> mostrarLibres()
        {
            List<string> lista = new List<string>();
              foreach (int clave in dicAlumnos.Keys)
            {
               if (dicAlumnos[clave].GetCantidadFaltas() > 15){
                lista.Add(dicAlumnos[clave].getNombre());
               }
            }
            return lista;
        }
    }
}