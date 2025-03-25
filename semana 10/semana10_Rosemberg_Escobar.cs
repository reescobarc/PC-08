class Semana10REEC
{
    static void Main(string [] args)
    {
        Console.WriteLine("Ingrese 8 números: ");
        int [] arrayNuevo = new int [8];

        for(int i = 0; i < 8; i++)
        {
            Console.WriteLine($"Número {i+1}: ");
            arrayNuevo[i]= int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Los números que ingreso son: ");
        foreach(int num in arrayNuevo)
        {
            Console.WriteLine(num);
        }

        int suma = 0;
        for (int i = 0; i <arrayNuevo.Length; i++)
        {
            suma += arrayNuevo[i];
        }
        Console.WriteLine($"La suma de los números es: {suma}.");

        double promedio = suma / arrayNuevo.Length;
        Console.WriteLine($"El promedio de los números es: {promedio}.");
    }
}