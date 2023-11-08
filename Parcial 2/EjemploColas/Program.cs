//Aqui iria mi menu, si tuviera uno!!!

using EjemploColas;

internal class Program
{
    private static void Main(string[] args)
    {
        Run();
    }

    static void Run(){
        Cola cola = new();
        System.Console.WriteLine("*********Codigo de colas*********");
        System.Console.WriteLine("\nElija su opción: \n");

        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("1) Agregar\n2) Sacar\n3) Ver el elemento de encima\n4) Imprimir la cola\n5) Buscar\n6) Salir\n");
            System.Console.Write("Opción: "); string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                Console.Clear();
                cola.Enqueue();
                break;

                case "2":
                Console.Clear();
                System.Console.WriteLine("Elemento eliminado: " + cola.Dequeue());
                Console.ReadKey();
                break;

                case "3":
                Console.Clear();
                cola.ElemEncima();
                Console.ReadKey();
                break;

                case "4":
                Console.Clear();
                cola.Imprime();
                Console.ReadKey();
                break;

                case "5":
                Console.Clear();
                System.Console.Write("Ingrese el elemento a buscar: ");
                if (cola.Buscar(Console.ReadLine()))    System.Console.WriteLine("\n El elemento existe en la cola");
                else    System.Console.WriteLine("\n El elemento no existe en la cola");
                Console.ReadKey();
                break;

                case "6":
                Console.Clear();
                System.Console.WriteLine("Saliendo..."); Thread.Sleep(1000);
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Elija una opción correcta"); Console.ReadKey();
                break;
            }
        }
    }
}