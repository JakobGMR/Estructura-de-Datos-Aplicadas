public class Ventas
{
    decimal[,] venta = new decimal[12,5];
    string[] dias = {"  ","Lunes","Martes","Miercoles","Jueves","Viernes"};
    string[] meses = {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
    public Ventas() {
        
    }

    public void Inicio() {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Random numero = new Random();
                venta[i,j] = numero.Next(10,100);
            }
        }

        Interfaz();
    }

    public void Interfaz() {
        while (true)
        {
            Console.WriteLine(" Ventas \n");

            Console.WriteLine("1.- Mostrar venta");
            Console.WriteLine("2.- Menor venta");
            Console.WriteLine("3.- Mayor venta");
            Console.WriteLine("4.- Venta Total");
            Console.WriteLine("5.- Venta por día");
            Console.WriteLine("6.- Cerrar");

            Console.Write("\n Opción: "); string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                PrintArrays();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                MenorVenta();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                MayorVenta();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                VentaTotal();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                VentaDia();
                Console.Clear();
                break;

                case "6":
                    Console.Clear(); Console.WriteLine("Volviendo"); Thread.Sleep(1000); Console.Clear();
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

    public void PrintArrays() {
        for (int i = 0; i < 12; i++)
        {
            if (i == 0) // dias
            {
                    for (int j = 0; j < 6; j++)
                {
                    System.Console.Write($"    {this.dias[j]} |");
                }
            }

            System.Console.WriteLine();

            System.Console.Write(meses[i] + "  |");

            for (int j = 0; j < 5; j++)
            {
                System.Console.Write($"   {venta[i,j]}      |");
                Thread.Sleep(150);
            }

            System.Console.WriteLine();
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void MenorVenta() {
        decimal menorVenta = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 0 && j == 0)  menorVenta = venta[i,j];

                else if(menorVenta <= venta[i,j])  continue;

                else  menorVenta = venta[i,j];
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (venta[i,j] == menorVenta)
                {
                    System.Console.Write("         |");
                    System.Console.WriteLine($"    {this.dias[j+1]} |");
                    System.Console.Write(meses[i] + "  |");
                    System.Console.WriteLine($"   {venta[i,j]}      |");
                }
            }
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void MayorVenta() {
        decimal mayorVenta = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 0 && j == 0)  mayorVenta = venta[i,j];

                else if(mayorVenta >= venta[i,j])  continue;

                else  mayorVenta = venta[i,j];
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (venta[i,j] == mayorVenta)
                {
                    System.Console.Write("         |");
                    System.Console.WriteLine($"    {this.dias[j+1]} |");
                    System.Console.Write(meses[i] + "  |");
                    System.Console.WriteLine($"   {venta[i,j]}      |");
                }
            }
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void VentaTotal() {
        decimal total = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                total += venta[i,j];
            }
        }

        System.Console.WriteLine("El total de la venta de este año es de: " + total);
        System.Console.WriteLine("\n Pulse una tecla para continuar"); Console.ReadKey();
    }

    public void VentaDia() {
        decimal[] ventaDias = new decimal[5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                ventaDias[i] += venta[j,i];
            }
        }

        for (int i = 0; i < 5; i++)
        {
            System.Console.Write($"    {this.dias[i+1]} |");
        }

        System.Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            System.Console.Write($"   {ventaDias[i]}      |");
        }

        System.Console.WriteLine("\n\n Pulse una tecla");
        Console.ReadKey();
    }
}