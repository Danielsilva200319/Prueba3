using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("   CONFECH");
        Console.WriteLine("------------------");
        Console.WriteLine("1. Cantidad");
        Console.WriteLine("2. Registrarse");
        Console.WriteLine("3. Votación");
        Console.WriteLine("0. Salir");
        Console.WriteLine("------------------");
        int opcion = Convert.ToInt32(Console.ReadLine());
        bool activate = true;
        while (activate)
        {
            switch (opcion)
            {
                case 1:
                    Cantidad();
                    break;
                case 2:
                    Registrarse();
                    break;
                case 3:
                    Votos();
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
    public static void Cantidad()
    {
        Console.Clear();
        Console.Write("\nIngrese la cantidad de Universidades participantes: ");
        int Cantidad = Convert.ToInt32(Console.ReadLine());
        return;
    }
    public static void Registrarse()
    {
        Console.Clear();
        Console.Write("\nIngrese el nombre de la universidad: ");
        string universidad = Console.ReadLine();
        return;
    }
    public static void Votos()
    {
        Console.Clear();
        Console.WriteLine("VOTACIÓN");
        Console.WriteLine("A. Aceptar");
        Console.WriteLine("R. Rechazar");
        Console.WriteLine("N. Nulo");
        Console.WriteLine("B. Blanco");
        Console.WriteLine("X. Mostrar Votos");
        Console.WriteLine("I. Regresar al menu");
        Console.Write("Ingrese una Letra: ");
        string votar = Console.ReadLine().ToUpper();
        if (votar == "A" || votar == "R" || votar == "N" || votar == "B")
        {
            Console.WriteLine("Gracias por su votación");
        }
        else if (votar == "X")
        {
            return;
        }
        else
        {

        }
    }
}