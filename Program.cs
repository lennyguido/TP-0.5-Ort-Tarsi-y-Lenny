namespace TP0._5;

class Program
{
    static void Main(string[] args)
    {
        int menu;
        Curso curso = new Curso();
        List<string> opciones = new List<string>()
        {
            "Agregar nuevos alumnos",
            "Buscar un alumno por su dni",
            "Agregar una falta o media falta a un alumno.",
            "Mostrar todos los alumnos",
            "Mostrar los alumnos con mas de 15 faltas (Libres)",
        };


        menu = PedirOpcion(opciones, opciones.Count);


        while (menu != opciones.Count)
        {
            accionar(opciones, menu);
            menu = PedirOpcion(opciones, opciones.Count);
        }
    }


    private static void accionar(List<string> opciones, int menu)
    {
        
        int dni = 0;
        string nombre = "";
        double cantidadFaltas = 0;
        switch (menu)
        {
            case 1:
              dni = pedirInt("Ingrese el DNI del alumno sin espacios ni puntos: ");
              nombre = pedirString("Ingrese el nombre del alumno: ");
              cantidadFaltas = 0;
              Curso.agregarAlumno(dni, nombre, cantidadFaltas);
                break;

            case 2:
                
                break;


            case 3:
               
                break;


            case 4:
              
                break;
            
            case 5:

            break; 
        }
    }


    private static int PedirOpcion(List<string> opciones, int cantidadOpciones)
    {
        int x;
        do
        {
            Console.WriteLine("Ingrese la opcion del menú que desee: ");
            int i = 0;
            while (i < opciones.Count)
            {
                Console.WriteLine((i + 1) + ". " + opciones[i]);
                i++;
            }
            x = int.Parse(Console.ReadLine());
        } while (x < 1 || x > cantidadOpciones);
        return x;
    }
    private int pedirInt(string xe){
        Console.WriteLine(xe);
        int x = int.Parse(Console.ReadLine());
        return x;
    }
    private string pedirString(string xe){
        Console.WriteLine(xe);
        string x = Console.ReadLine();
        return x;
    }
}

