using System.Diagnostics.CodeAnalysis;

public class Programa 
{
    static void Main(string [] args){
        Console.Clear();
        Alumnos.LlenadoAlumnos(); //Llamado de metodos
        Alumnos.LlenadoNotas();
        Menu();
    }
    public static void Menu()
    {
        Console.WriteLine("¿Qué deseas visualizar?"); //Menu con llamado de metodos de solicitud
        Console.WriteLine("1. Nombre y notas aprobadas para cada alumno..");
        Console.WriteLine("2. Nombre y notas aprobadas para cada alumno.");
        Console.WriteLine("3. El promedio de notas del grupo.");
        Console.WriteLine("4. Salir.");
        int opcion = 0;
        bool seleccion = false;
        do //Validación del número para el menu
        {
            opcion = int.Parse(Console.ReadLine());
            if (opcion >= 1 && opcion <= 4)
            {
                seleccion = true;
            }
            else
            {
                Console.WriteLine("Dato inválido. Debe ser entre 1 y 4.");
            }
        }
        while (!seleccion);
        switch (opcion) //Casos a donde manda el menú.
        {
            case 1:
                Ganaron();
                break;
            case 2:
                NoGanaron();
                break;
            case 3:
                Promedio();
                break;
            default:
                Console.ReadKey();
                break;
        }
    }
    public static void Ganaron() //Metodo de alumnos con sus notas aprobadas
    {
        Console.WriteLine("\nAlumnos y sus notas aprobadas:");
        for (int fila = 0; fila < Alumnos.alumnos.Length; fila++)
        {
            Console.Write($"{Alumnos.alumnos[fila]}: ");
            bool tieneNotasAprobadas = false;

            for (int columna = 0; columna < 10; columna++) //Revisa cada columna para ver las notas del alumno y revisar cuales estan aprobadas.
            {
                if (Alumnos.notas[fila, columna] >= 65)
                {
                    Console.Write($"{Alumnos.notas[fila, columna]} "); //Imprime el alumno y sus notas aprobadas
                    tieneNotasAprobadas = true;
                }
            }
            if (!tieneNotasAprobadas)
            {
                Console.Write("Sin notas aprobadas");
            }
            Console.WriteLine();
        }
        Menu();
    }
    public static void NoGanaron()//Metodo de alumnos con sus notas no aprobadas
    {
        Console.WriteLine("\nAlumnos y sus notas no aprobadas:");
        for (int fila = 0; fila < Alumnos.alumnos.Length; fila++)
        {
            Console.Write($"{Alumnos.alumnos[fila]}: ");
            bool tieneNotasReprobadas = false;

            for (int columna = 0; columna < 10; columna++) //Revisa cada columna para ver las notas del alumno y revisar cuales no están aprobadas.
            {
                if (Alumnos.notas[fila, columna] < 65)
                {
                    Console.Write($"{Alumnos.notas[fila, columna]} "); //Imprime el alumno y sus notas no aprobadas.
                    tieneNotasReprobadas = true;
                }
            }
            if (!tieneNotasReprobadas)
            {
                Console.Write("Sin notas reprobadas");
            }
            Console.WriteLine();
        }
        Menu();
    }
    public static void Promedio(){ //Metodo con el promedio de la clase
        double suma = 0;
        for (int fila = 0; fila < 10; fila++) //Revisa cada una de las filas y columnas para ir sumando.
        {
            for (int columna = 0; columna < 10; columna++)
            {
                suma += Alumnos.notas[fila, columna];
            }
        }
        double promedio = suma /100; //La suma dividido la cantidad de notas.
        Console.WriteLine($"El promedio es de {promedio}");
        Menu();
    }
}
public class Alumnos 
{
    public static string [] alumnos;
    public static int [,] notas;
    public static void LlenadoAlumnos(){
        Console.WriteLine("Ingresa el nombre de los 10 estudiantes con sus 10 notas.");
        alumnos = new string[10];
        for (int i = 0; i < alumnos.Length; i++)
        {
            Console.WriteLine("Ingresa el nombre del estudiante: ");
            alumnos[i] = Console.ReadLine();
        }
    }
    public static void LlenadoNotas(){
        notas = new int [10,10];
        for (int fila = 0; fila < 10; fila++)
        {
            Console.WriteLine($"Ingrese las notas del Estudiante {alumnos[fila]}: ");
            for (int columna = 0; columna < 10; columna++)
            {
                bool entradaValida = false;
                do //Validación que las notas sean entre 0 y 100 y que sean de tipo int.
                {
                    string input = Console.ReadLine(); 
                    if(int.TryParse(input, out notas[fila,columna])) //Se lee lo del usuario y lo convierte en int.
                    {
                        if(notas[fila,columna] >= 0 && notas[fila,columna] <= 100)
                        {
                            entradaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido. Debe ser entre 0 y 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dato inválido. Debe ser un número.");
                    }
                } 
                while(!entradaValida);
            }
        }
    }
}