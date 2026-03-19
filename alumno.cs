namespace TP0._5;

public class Alumno
{
private int dni;
private string nombre;
private double cantidadFaltas;

public Alumno(int dni, string nombre, double cantidadFaltas)
{
this.dni = dni;
this.nombre = nombre;
this.cantidadFaltas = cantidadFaltas;
}
public int GetDni()
{
    return dni;
}
public double GetCantidadFaltas()
{
    return cantidadFaltas;
}
public string getNombre(){
    return nombre;
}
}
