class Recursividad
{
    
    public Recursividad() {

    }

    public void TorreHanoi(int n, char origen, char destino, char auxiliar)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 desde {origen} a {destino}");
            return;
        }

        TorreHanoi(n - 1, origen, auxiliar, destino);
        Console.WriteLine($"Mover disco {n} desde {origen} a {destino}");
        TorreHanoi(n - 1, auxiliar, destino, origen);
    }

    public void CalcularCambio(decimal cambio)
    {
        decimal[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5M, 0.2M, 0.01M };

        // Llamada a la función recursiva
        CalcularCambioRecursivo(cambio, denominaciones, 0);
    }

    public void CalcularCambioRecursivo(decimal cambio, decimal[] denominaciones, int i)
    {
        if (cambio >= denominaciones[i])
        {
            int cantidad = (int)(cambio / denominaciones[i]);
            Console.WriteLine($"{cantidad} moneda(s) de {denominaciones[i]}");
            cambio -= cantidad * denominaciones[i];
        }

        if (cambio > 0 && i < denominaciones.Length - 1)
        {
            // Llamada recursiva con el siguiente valor de denominación
            CalcularCambioRecursivo(cambio, denominaciones, i + 1);
        }
        else if (cambio > 0)
        {
            Console.WriteLine($"Quedan {cambio} unidades que no se pueden cambiar.");
        }
    }

    public Int128 Factorial(Int128 n) {
        if (n == 0 || n == 1)  return 1;

        return n * Factorial(n - 1);
    }

    public Int128 Fibonacci(Int128 n) {
        if (n == 0)  return 0;

        else if (n == 1)  return 1;

        else  return Fibonacci(n-1) + Fibonacci(n-2);
    }

    public int Hanoi(int n) {
        if (n == 0)  return 0;

        else if (n == 1)  return 1;

        else  return 2 * Hanoi(n-1) + 1;
    }

    public int MCD(int n, int m) {
        int res;

        if (m==0)  return n;

        if (n > m) {
            res = n % m;
        }

        else if(n < m) {
            res = m % n;
        }

        else {
            res = 0;
        }
    
        return MCD(m,res);
    }
}