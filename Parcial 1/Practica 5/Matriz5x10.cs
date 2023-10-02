public class Matriz5x10
{
    int[,] arrayRandom;
    decimal[,] arrayAB = new decimal[5,2];
    decimal[,] arrayCD = new decimal[2,10];

    public Matriz5x10() {
        this.arrayRandom = new int[5,10];
    }

    public void Inicio() {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Random numero = new Random();
                arrayRandom[i,j] = numero.Next(1,10);
            }
        }

        SumFilas();
    }

    public void SumFilas() {
        for (int i = 0; i < 5; i++)
        {
            int suma = 0;

            for (int j =0; j < 10; j++)
            {
                suma += arrayRandom[i,j];
            }

            arrayAB[i,0] = suma;
            arrayAB[i,1] = (decimal)suma / 10;
        }

        SumColumnas();
    }

    public void SumColumnas() {
        for (int j = 0; j < 10; j++)
        {
            int suma = 0;

            for (int k = 0; k < 5; k++)
            {
                suma += arrayRandom[k,j];
            }

            arrayCD[0,j] = suma;
            arrayCD[1,j] = (decimal)suma / 5;
        }

        PrintArrays();
    }

    public void PrintArrays() {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                System.Console.Write($"{this.arrayRandom[i,j]}  |");
                Thread.Sleep(200);
            }

            System.Console.Write("  => ");

            for (int j = 0; j < 2; j++)
            {
                System.Console.Write($"{arrayAB[i,j]}  |");
                Thread.Sleep(150);
            }

            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        for (int i = 0; i < 12; i++)
        {
            System.Console.Write(" ↓ ");
        }

        System.Console.WriteLine();

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                System.Console.Write($"{arrayCD[i,j]} |");
                Thread.Sleep(150);
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }
}