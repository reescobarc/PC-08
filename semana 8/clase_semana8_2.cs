public static class Actividad1Semana8
{
    public static void Main()
    {
        Console.WriteLine("Ingresa un número entero: ");
        int numIng = Convert.ToInt32(Console.ReadLine());
        if (numIng >0){
            CalcularFactorial(numIng);
            int resFact = CalcularFactorial(numIng);

            if (resFact >= 0) {
                Console.WriteLine($"El resultado de {numIng} es {resFact}");
            }
        }
        else {
            Console.WriteLine("Ingrese otro valor: ");
            Main();
        }
        
    }
    public static int CalcularFactorial(int numIng)
    {
        if (numIng == 0)
        {
            return 1;
        }
        else 
        {
            int factorial =1;
            for (int i =1; i <= numIng; i++)
            {
                factorial *=i;
            }
            return factorial;
        }
    }
}