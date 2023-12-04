using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("   CONFECH");
        Console.WriteLine("------------------");
        Console.WriteLine("1. Cantidad");
        Console.WriteLine("2. Registrarse");
        Console.WriteLine("0. Salir");
        Console.WriteLine("------------------");
        int opcion = Convert.ToInt32(Console.ReadLine());
        bool activate = true;
        while (activate)
        {
            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese la cantidad de Universidades participantes: ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("\nIngrese el nombre de la universidad: ");
                    string universidad = Console.ReadLine().ToUpper();
                    Console.WriteLine("\n    Votación");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("A. Aceptar");
                    Console.WriteLine("R. Rechazar");
                    Console.WriteLine("N. Nulo");
                    Console.WriteLine("B. Blanco");
                    Console.WriteLine("-------------------");
                    string votar = Console.ReadLine();
                    foreach (var item in universidad)
                    {
                        Console.WriteLine($"Universidad: {universidad}");
                        Console.WriteLine($"Voto: {votar}");
                        Console.WriteLine($"{universidad}: {votar.Count()}");
                    }
                    break;
                case 0:
                    Console.WriteLine("GRACIAS");
                    activate = false;
                    break;
                default:
                    Console.WriteLine("\nIngrese un valor válido");
                    break;
            }
        }
    }
}