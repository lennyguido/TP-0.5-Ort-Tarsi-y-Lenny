namespace TP0._5;

public class Curso
{

private List<Alumno> Alumno;

public Curso()
{

alumno = new List<alumno>();

}

public void agregarAlumno(dni, nombre, cantidadFaltas)
{
        Alumno a = new Alumno (dni, nombre, cantidadFaltas);       
}
public void buscarAlumnoxDni(){
     bool encontrado = false
     int i = 0;
     while(!encontrado && i<Alumno.count){
        if(alumno[i].getDni == dni)
        {encontrado = true}
        i++

     }
}
}
