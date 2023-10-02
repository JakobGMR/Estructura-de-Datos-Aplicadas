internal class Program
{
    private static void Main(string[] args)
    {
        Run();
    }

    static void Run() {
        while (true)
        {
            Console.WriteLine("         INICIO DEL PROGRAMA \n");

            Console.WriteLine("1.- Cuadro Magico");
            Console.WriteLine("2.- Matriz 5x10");
            Console.WriteLine("3.- Resumen de ventas");
            Console.WriteLine("4.- Calificaciones");
            Console.WriteLine("5.- Cerrar");

            Console.Write("\n Opción: "); string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                CuadroMagico cuadro1 = new CuadroMagico();
                cuadro1.CuadroCuadrado();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                Matriz5x10 m1 = new Matriz5x10();
                m1.Inicio();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                Ventas venta = new Ventas();
                System.Console.WriteLine("Cargando..."); Thread.Sleep(500); Console.Clear();
                venta.Inicio();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                Calificaciones calif = new Calificaciones();
                System.Console.WriteLine("Cargando..."); Thread.Sleep(500); Console.Clear();
                calif.GenerarCalificaciones();
                Console.Clear();
                break;

                case "5":
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
}