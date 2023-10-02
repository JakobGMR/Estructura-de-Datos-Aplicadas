public class CuadroMagico
{
    int filas;
    int columnas;
    int[,] cuadro;
    public CuadroMagico() {
        System.Console.Write("Inserte el número de filas: "); this.filas = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        System.Console.Write("Inserte el número de columnas: "); this.columnas = Convert.ToInt32(Console.ReadLine());
        Console.Clear();    System.Console.WriteLine("Cargando..."); Thread.Sleep(500); Console.Clear();
        this.filas += 1; this.columnas += 1;
        this.cuadro = new int[filas,columnas];
    }

    public void CuadroCuadrado() {
        if (filas == columnas)
        {
            RellenarValores();
            SumaValores();
            PrintArray();
        }

        else {
            Console.Clear();
            System.Console.WriteLine("Este cuadro, no es un cuadro mágico");
            System.Console.WriteLine("Volviendo..."); Thread.Sleep(1500);
        }
    }

    public void RellenarValores() {
        System.Console.WriteLine("Ingrese los valores del cuadro \n");
        for (int i = 0; i < this.filas-1; i++)
        {
            for (int j = 0; j < this.filas-1; j++)
            {
                System.Console.Write($"Casilla({i+1}, {j+1}): "); int valor = int.Parse(Console.ReadLine());
                this.cuadro[i,j] = valor;
            }
        }

        System.Console.WriteLine("\n Almacenando los datos..."); Thread.Sleep(1000);
        Console.Clear();
    }

    public void SumaValores() {
        for (int i = 0; i < this.filas; i++)
        {   
            if (i != this.filas - 1)
            {
                for (int j =0; j < this.filas-1; j++)
                {
                    this.cuadro[i,this.filas-1] += this.cuadro[i,j];
                }
            }
            else {
                for (int j = 0; j < this.filas-1; j++)
                {
                    for (int k = 0; k < this.filas-1; k++)
                    {
                        this.cuadro[i,j] += this.cuadro[k,j];
                    }
                }
            }
        }

        for (int i = 0; i < this.filas-1; i++)
        {
            for (int j = 0; j < filas-1; j++)
            {
                if (i == j)
                {
                    this.cuadro[this.filas-1,this.filas-1] += this.cuadro[i,j];
                }
            }
        }
    }

    public void PrintArray() {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < filas; j++)
            {
                System.Console.Write($"{this.cuadro[i,j]}  |");
                Thread.Sleep(300);
            }
            System.Console.WriteLine();
        }

        if (EsCuadroMagico())  System.Console.WriteLine("\n ¡FELICIDADES! Creaste un cuadro mágico");
        
        else  System.Console.WriteLine("\n Este, no es un cuadro mágico");

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public bool EsCuadroMagico() {
        for (int i = 0; i < filas; i++)
        {
            if (i != this.filas-1)
            {
                if (this.cuadro[i,filas-1] == this.cuadro[i+1,filas-1])
                {
                    continue;
                }
                
                else  return false;
            }

            else {
                for (int j = 0; j < this.filas-1; j++)
                {
                    if (this.cuadro[i,j] == this.cuadro[i,j+1])
                    {
                        continue;
                    }
                    
                    else  return false;
                }
            }
        }

        return true;
    }
}