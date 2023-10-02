/*User cases
user stories
sin buena documentacion no se hace nada */

internal class Program
{
    private static void Main(string[] args)
    {
        Run();
    }

    static void Run() {
        while (true)
        {
            Console.WriteLine("Programa para calcular formulas \n");

            Console.WriteLine("Elija su opcion \n");

            Console.WriteLine("1.- Factorial");
            Console.WriteLine("2.- Fibonacci");
            Console.WriteLine("3.- Hanoi");
            Console.WriteLine("4.- MCD de 2 números");
            Console.WriteLine("5.- Calcular cambio");
            Console.WriteLine("6.- Cerrar");

            Console.Write("\n Opción: "); string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                MenuFactorial();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                MenuFibonacci();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                MenuHanoi();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                MenuMCD();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                MenuCambio();
                Console.Clear();
                break;

                case "6":
                    Console.Clear(); Console.WriteLine("Adiós"); Thread.Sleep(1500); Console.Clear();
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Error, intentelo de nuevo \n Pulse una tecla");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }

    static void MenuFactorial() {
        System.Console.WriteLine("Inserte el número factorial");
        Int128 numUsuario = Int128.Parse(Console.ReadLine()!);

        Console.Clear();
        Recursividad r1 = new Recursividad();
        Int128 valorFactorial = r1.Factorial(numUsuario);
        System.Console.WriteLine($"\nEl factorial del número {numUsuario} es: {valorFactorial} \n Pulse una tecla para cerrar");

        Console.ReadKey();
    }

    static void MenuFibonacci() {
        System.Console.WriteLine("Inserte el número a calcular");
        Int128 numUsuario = Int128.Parse(Console.ReadLine()!);

        Console.Clear();
        Recursividad r1 = new Recursividad();
        Int128 valorFibonacci = r1.Fibonacci(numUsuario);
        System.Console.WriteLine($"\nEl resultado es: {valorFibonacci} \n Pulse una tecla para cerrar");

        Console.ReadKey();
    }

    static void MenuHanoi() {
        Recursividad h1 = new Recursividad();
        System.Console.WriteLine("Inserte el número de discos");
        int numUsuario = int.Parse(Console.ReadLine()!);

        Console.Clear();
        h1.TorreHanoi(numUsuario, 'A','B', 'C');
        System.Console.WriteLine("\n Pulse una tecla para continuar");

        Console.ReadKey();
    }

    static void MenuMCD() {
        System.Console.WriteLine("Inserte el primer número a calcular");
        int numUsuario1 = int.Parse(Console.ReadLine()!);

        System.Console.WriteLine("Inserte el segundo número a calcular");
        int numUsuario2 = int.Parse(Console.ReadLine()!);

        Console.Clear();
        Recursividad r1 = new Recursividad();
        int valorMCD = r1.MCD(numUsuario1,numUsuario2);
        System.Console.WriteLine($"\nEl resultado es: {valorMCD} \n Pulse una tecla para cerrar");

        Console.ReadKey();
    }

    static void MenuCambio() {
        Console.WriteLine("Ingrese el monto total de la compra:");
        decimal totalCompra = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese la cantidad pagada:");
        decimal cantidadPagada = decimal.Parse(Console.ReadLine()!);

        decimal cambio = cantidadPagada - totalCompra;

        if (cambio < 0)
        {
            Console.WriteLine("La cantidad pagada es insuficiente.");
            System.Console.WriteLine("\n Pulse una tecla para continuar");
            Console.ReadKey();
        }
        else if (cambio == 0)
        {
            Console.WriteLine("No hay cambio.");
            System.Console.WriteLine("\n Pulse una tecla para continuar");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("El cambio es:");
            Recursividad c1 = new Recursividad();
            c1.CalcularCambio(cambio);

            System.Console.WriteLine("\n Pulse una tecla para continuar");
            Console.ReadKey(); Console.Clear();
        }
    }
}