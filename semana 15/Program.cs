//Rosemberg Escobar 1046925
using System;
class Estudiante
{
    public string Nombre;
    public int Edad;
    public string Carrera; 
    public string Carnet;
    public int NotaAdmision;

    public void MostrarResumen()
    {
        Console.WriteLine("Datos del estudiante: ");
        Console.WriteLine($"Nombre: {this.Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Carnet: {Carnet}");
        Console.WriteLine($"Nota de Admisión: {NotaAdmision}");
    }
    public string PuedeMatricular()
    {
    if (NotaAdmision>=75)
    {
        if (Carnet.EndsWith("2025"))
        {
            return "El estudiante SÍ se puede matricular."; 
        }
        else 
        {
            return "El estudiante NO se puede matricular, el carnet debe de terminar en 2025."; 
        }
    }
    else 
    {
        return "El estudiante NO se puede matricular, su nota de admisión no fue más o igual que 75 pts."; 
    }
    }
}
    
class Program
{
    public static void Main(string [] args)
    {
        Console.Clear();
        Console.WriteLine("¡Bienvenido Estudiante! Ingresa tus siguientes datos:");
        Estudiante estudiante = new Estudiante();

        Console.Write("Ingrese su nombre: ");
        estudiante.Nombre = Console.ReadLine();
        Console.Write("Ingrese su edad: ");
        estudiante.Edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese su carrera: ");
        estudiante.Carrera = Console.ReadLine();
        Console.Write("Ingrese su carnet: ");
        estudiante.Carnet = Console.ReadLine();
        Console.Write("Ingrese su nota de admisión: ");
        estudiante.NotaAdmision = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--------------------------------");
        estudiante.MostrarResumen();
        Console.WriteLine("\n" + estudiante.PuedeMatricular());
    }
}