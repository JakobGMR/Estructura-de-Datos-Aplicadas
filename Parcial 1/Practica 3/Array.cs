class Array
{
    decimal[,] matriz1 = new decimal[2,2];
    decimal[,] matriz2 = new decimal[2,2];
    public Array( decimal[,] m1, decimal[,] m2) {
        this.matriz1 = m1;
        this.matriz2 = m2;
    }

    public void PrintArray() {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.WriteLine($"Matriz 1({i+1}, {j+1}): " + matriz1[i,j]);
                System.Console.WriteLine($"Matriz 2({i+1}, {j+1}): " + matriz2[i,j] + "\n");
                Thread.Sleep(300);
            }
        }

        System.Console.WriteLine("Pulse una tecla");
        Console.ReadKey();
    }

    public void SumaArray() {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.WriteLine($"Matriz 1({i+1}, {j+1}): " + matriz1[i,j] + $" + Matriz 2({i+1}, {j+1}): " + matriz2[i,j] + $" = {matriz1[i,j] + matriz2[i,j]}\n");
                Thread.Sleep(300);
            }
        }

        System.Console.WriteLine("Pulsa una tecla");
        Console.ReadKey();
    }

    public void RestaArray() {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.WriteLine($"Matriz 1({i+1}, {j+1}): " + matriz1[i,j] + $" + Matriz 2({i+1}, {j+1}): " + matriz2[i,j] + $" = {matriz1[i,j] - matriz2[i,j]}\n");
                Thread.Sleep(300);
            }
        }

        System.Console.WriteLine("Pulsa una tecla");
        Console.ReadKey();
    }

    public void MultiplicaArray() {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.WriteLine($"Matriz 1({i+1}, {j+1}): " + matriz1[i,j] + $" + Matriz 2({i+1}, {j+1}): " + matriz2[i,j] + $" = {matriz1[i,j] * matriz2[i,j]}\n");
                Thread.Sleep(300);
            }
        }

        System.Console.WriteLine("Pulsa una tecla");
        Console.ReadKey();
    }

    public void DividirArray() {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                decimal res = matriz1[i,j] / matriz2[i,j];
                res = Math.Round(res, 2);
                System.Console.WriteLine($"Matriz 1({i+1}, {j+1}): " + matriz1[i,j] + $" + Matriz 2({i+1}, {j+1}): " + matriz2[i,j] + $" = {res}\n");
                Thread.Sleep(300);
            }
        }

        System.Console.WriteLine("Pulsa una tecla");
        Console.ReadKey();
    }

    public void ActualizarMatrices() {
        System.Console.WriteLine("Ingrese los nuevos datos \n");

        decimal valor;

        System.Console.WriteLine("              Matriz 1");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.Write($"Matriz 1({i+1}, {j+1}): "); valor = decimal.Parse(Console.ReadLine());
                this.matriz1[i,j] = valor;
            }
        }

        System.Console.WriteLine("\n              Matriz 2");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.Write($"Matriz 2({i+1}, {j+1}): "); valor = decimal.Parse(Console.ReadLine());
                this.matriz2[i,j] = valor;
            }
        }

        Console.Clear();
        System.Console.WriteLine("Almacenando datos...");
        Thread.Sleep(1300);
        Console.Clear();
    }
}