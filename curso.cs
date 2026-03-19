        namespace TP0._5;

        public class Curso
        {

        private List<Alumno> alumnos;
         private List<Alumno> alumnosLibres;

        public Curso()
        {

        alumnos = new List<Alumno>();
         alumnosLibres = new List<Alumno>();

        }

        public void agregarAlumno(int dni, string nombre, double cantidadFaltas)
        {
                
                string resultado = buscarAlumnoxDni(dni);
                if(resultado == "No se ha encontrado."){
                Alumno a = new Alumno (dni, nombre, cantidadFaltas);
                alumnos.Add(a);    
                resultado = "No se ha podido agregar porque ya existe.";
                } 
                
        }
        public string buscarAlumnoxDni(int dni){
        string resultado = "";
        bool encontrado = false;
        int i = 0;
        while(!encontrado && i< alumnos.Count)
        {
                if(alumnos[i].GetDni() == dni)
                {
                        encontrado = true;
                        resultado = "Se ha encontrado, el alumno es: " + alumnos[i] + ".";
                } else{
                        resultado = "No se ha encontrado.";
                }
                i++;

        }
        return resultado; 
        }

        public double AgregarFaltas(int dni, int resultado)
        {       
        bool encontrado = false;
        int i = 0;
        while(!encontrado && i< alumnos.Count)
        {
                 if(alumnos[i].GetDni() == dni)
                {
                        encontrado = true;
                        if(resultado = 1){
                                alumnos[i].GetCantidadFaltas() += 1
                        }
                        else{
                                alumnos[i].GetCantidadFaltas() += 0.5
                        }
                }
          i++
        }


        public List<string> mostrarAlumnos()
        {
                return alumnos;
        }

        public List <string> mostrarLibres()
        {
                
                if(alumnos[i].GetCantidadFaltas() > 15)
                {
                        alumnosLibres.Add(alumnos[i])
                }

                return mostrar;
        }

        }

        }
