    internal class Program
{
    decimal valor1;
    decimal valor2;
    decimal valor3;
    decimal valor4;
    decimal valor5;
    decimal valor6;
    decimal valor7;
    decimal valor8;
    private static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        /*
        Elabora un programa en C# en modo consola para crear una aplicacion que lea dos arreglos de tamaño
        2 * 2, llena ambas matrices y calcule lo siguiente:

        1. La suma de las matrices
        2. La resta de los elementos
        */
    }

    public void Run() {
        decimal[,] m1 = new decimal[2,2];
        decimal[,] m2 = new decimal[2,2];
        decimal valor;

        System.Console.WriteLine("Primero ingrese los valores en cada array \n");

        System.Console.WriteLine("              Matriz 1");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.Write($"Matriz 1({i+1}, {j+1}): "); valor = decimal.Parse(Console.ReadLine());
                m1[i,j] = valor;
            }
        }

        System.Console.WriteLine("\n              Matriz 2");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.Write($"Matriz 2({i+1}, {j+1}): "); valor = decimal.Parse(Console.ReadLine());
                m2[i,j] = valor;
            }
        }

        Console.Clear();
        System.Console.WriteLine("Almacenando datos...");
        Thread.Sleep(1300);
        Array arrayBase = new Array(m1,m2);
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Matrices \n");

            Console.WriteLine("Elija su opcion \n");

            Console.WriteLine("1.- Comprobar Matriz");
            Console.WriteLine("2.- Sumar Matrices");
            Console.WriteLine("3.- Restar Matrices");
            Console.WriteLine("4.- Multiplicar Matrices");
            Console.WriteLine("5.- Dividir Matrices");
            Console.WriteLine("6.- Actualizar Valores");
            Console.WriteLine("7.- Cerrar \n");

            System.Console.Write("Elija un número: "); string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                arrayBase.PrintArray();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                arrayBase.SumaArray();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                arrayBase.RestaArray();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                arrayBase.MultiplicaArray();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                arrayBase.DividirArray();
                Console.Clear();
                break;

                case "6":
                Console.Clear();
                arrayBase.ActualizarMatrices();
                Console.Clear();
                break;

                case "7":
                Console.Clear();
                System.Console.WriteLine("Cerrando programa");
                Thread.Sleep(1000);
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Solo numeros del 1 al 6");
                break;
            }        
        }
    }
}