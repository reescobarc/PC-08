class PrimerParcial
{
    static void Main(string [] args)
    {
        Console.WriteLine("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 %2 == 0)
        {
            Console.WriteLine("El número "+ num1 + " es par.");
        }
        else {
            Console.WriteLine("El número "+ num1 + " es impar.");
        }

        if (num2 %2 == 0)
        {
            Console.WriteLine("El número "+ num2 + " es par.");
        }
        else {
            Console.WriteLine("El número "+ num2 + " es impar.");
        }

        if (num3 %2 == 0)
        {
            Console.WriteLine("El número "+ num3 + " es par.");
        }
        else {
            Console.WriteLine("El número "+ num3 + " es impar.");
        }
    }
}
