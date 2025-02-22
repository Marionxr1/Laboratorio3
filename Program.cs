using System.Text.RegularExpressions;

class lab
{
    static List<string> estudiantes = new List<string>();
    static List<double> calificaciones = new List<double>();

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Mostrar lista de estudiantes");
            Console.WriteLine("3. Calcular promedio de calificaciones");
            Console.WriteLine("4. Mostrar estudinte con la calificacion mas alta ");
            Console.WriteLine("5. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    AgregarEstudiante();
                    break;
                case 2:
                    ListaEstudiantes();
                    break;
                case 3:
                    PromCal();
                    break;
                case 4:
                    MostrarCaliMax();
                    break;
                case 5
                    :
                    Console.WriteLine("Adios");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;


            }

        } while (opcion != 5);

    }

    static void AgregarEstudiante()
    {

        {
            string nombre;
            do
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine() ?? "";

                if (!Regex.IsMatch(nombre, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
                {
                    Console.WriteLine("Nombre inválido. Solo se permiten letras y espacios.");
                }

            } while (!Regex.IsMatch(nombre, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"));

            double calificacion;
            do
            {
                Console.Write("Ingrese la calificación del estudiante (0 - 100): ");
                string? calificacionInput = Console.ReadLine();

                if (!double.TryParse(calificacionInput, out calificacion) || calificacion < 0 || calificacion > 100)
                {
                    Console.WriteLine("Calificación no válida. Ingrese un número entre 0 y 100.");
                }

            } while (calificacion < 0 || calificacion > 100);

            estudiantes.Add(nombre);
            calificaciones.Add(calificacion);
            Console.WriteLine("Estudiante agregado correctamente.");
        }
    }


    static void ListaEstudiantes()
    {
        if (estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
        }
        else
        {
            Console.WriteLine("\nLista de estudiantes:");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
            }
        }
    }


    static void PromCal()
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No hay calificaciones registradas.");
        }
        else
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Count;
            Console.WriteLine($"El promedio de calificaciones es: {promedio}");
        }
    }
    static void MostrarCaliMax()
    {
        {
            if (calificaciones.Count == 0)
            {
                Console.WriteLine("No hay calificaciones registradas.");
            }
            else
            {
                double maxCalificacion = calificaciones[0];
                string estudianteMax = estudiantes[0];
                for (int i = 1; i < calificaciones.Count; i++)
                {
                    if (calificaciones[i] > maxCalificacion)
                    {
                        maxCalificacion = calificaciones[i];
                        estudianteMax = estudiantes[i];
                    }
                }
                Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");
            }
        }
    }
}
