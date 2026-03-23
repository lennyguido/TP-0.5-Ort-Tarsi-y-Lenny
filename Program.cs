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
            "Salir"
        };

        menu = PedirOpcion(opciones, opciones.Count);

        while (menu != opciones.Count)
        {
            accionar(curso, opciones, menu);
            menu = PedirOpcion(opciones, opciones.Count);
        }
    }

    private static void accionar(Curso curso, List<string> opciones, int menu)
    {
        string resultado = "";
        int faltas = 0;
        int dni = 0;
        string nombre = "";
        double cantidadFaltas = 0;

        switch (menu)
        {
            case 1:
                dni = pedirInt("Ingrese el DNI del alumno sin espacios ni puntos: ");
                nombre = pedirString("Ingrese el nombre del alumno: ");
                cantidadFaltas = 0;
                curso.agregarAlumno(dni, nombre, cantidadFaltas);
                break;

            case 2:
                dni = pedirInt("Ingrese el DNI del alumno sin espacios ni puntos: ");
                resultado = curso.buscarAlumnoxDni(dni);
                Console.WriteLine(resultado);
                break;

            case 3:
                dni = pedirInt("Ingrese el DNI del alumno sin espacios ni puntos: ");
                faltas = pedirInt("1 falta [1] / 0.5 falta [otro número]: ");
                curso.AgregarFaltas(dni, faltas);
                break;

            case 4:
                List<string> alumnosNombre = curso.mostrarAlumnos();
                for (int i = 0; i < alumnosNombre.Count; i++)
                {
                    Console.WriteLine(alumnosNombre[i]);
                }
                break;

            case 5:
                List<string> alumnosLibreNombre = curso.mostrarLibres();
                for (int i = 0; i < alumnosLibreNombre.Count; i++)
                {
                    Console.WriteLine(alumnosLibreNombre[i]);
                }
                break;
        }
    }

    private static int PedirOpcion(List<string> opciones, int cantidadOpciones)
    {
        int x;
        do
        {
            Console.WriteLine("Ingrese la opcion del menú que desee: ");
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + opciones[i]);
            }

            x = int.Parse(Console.ReadLine() ?? "0");

        } while (x < 1 || x > cantidadOpciones);

        return x;
    }

    private static int pedirInt(string xe)
    {
        Console.WriteLine(xe);
        return int.Parse(Console.ReadLine() ?? "0");
    }

    private static string pedirString(string xe)
    {
        Console.WriteLine(xe);
        return Console.ReadLine() ?? "";
    }
}