internal class Program
{
    private static void Main(string[] args)
    {
        Program ejecuta = new Program();
        Console.Clear();
        ejecuta.Run();
    }

    public void Run() {
        while (true)
        {
            Console.WriteLine("Matrices \n");

            Console.WriteLine("Elija su opcion \n");

            Console.WriteLine("1.- Comprobar Matriz");
            Console.WriteLine("2.- Matriz Identidad");
            Console.WriteLine("3.- Matriz Gauss");
            Console.WriteLine("4.- Cerrar \n");

            System.Console.Write("Elija un número: "); string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                Matrix m1 = new Matrix();
                m1.Calculo();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                Matrix m2 = new Matrix();
                m2.Identidad();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                Matrix m3 = new Matrix();
                m3.Gauss();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                System.Console.WriteLine("Cerrando programa");
                Thread.Sleep(1000);
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Solo numeros del 1 al 3");
                break;
            }        
        }
    }
}