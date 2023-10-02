public class Matrix{
    int[,] matriz = {
        {0,2,5,7,6},
        {0,0,0,3,8},
        {2,9,6,3,4},
        {1,5,6,1,4},
        {0,9,2,5,0},
    };
    
    public Matrix(){
        
    }

    public void Calculo(){
        Console.Clear();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                System.Console.Write(matriz[i,j] + " ");
            }

            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        int contadorCeros = 0;
        for(int i = 0; i < matriz.GetLength(0); i++ ){
            for(int j = 0; j < matriz.GetLength(1); j++){ // POSIBLE ERRROR
                if(matriz[i,j]==0) contadorCeros++;
            }
            Console.WriteLine("Fila #" + (i+1) + " contiene: " + contadorCeros+ " ceros");
            contadorCeros = 0;
        }

        Console.ReadKey();
    }

    public void Identidad(){
        Console.Clear();

        System.Console.WriteLine("Ingresa el tamaño CUADRADO de la matriz");
        System.Console.Write("\nTamaño: "); int eleccion = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine();

        int[,] matrizIdentidad = new int[eleccion,eleccion];
        for(int i = 0; i < matrizIdentidad.GetLength(0); i++ ){
            for(int j = 0; j < matrizIdentidad.GetLength(1); j++){ // POSIBLE ERRROR
                if ( i == j ) {
                    matrizIdentidad[i,j] = 1;
                    Console.Write("1 ");
                } else {
                    matrizIdentidad[i,j] = 0;
                    Console.Write("0 ");
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey();
    }

    public void Gauss() {
        Console.Clear();

        // System.Console.WriteLine("Ingresa el tamaño CUADRADO de la matriz");
        // System.Console.Write("\nTamaño: "); int eleccion = Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine();

        int[,] matrizIdentidad = new int[3,3]; // CAMBIAR  a eleccion si es matriz 
        int[,] matrizUsuario = new int[3,3];

        System.Console.WriteLine("Ingrese los valores del array (NUMEROS ENTEROS) \n");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.Write($"Matriz ({i+1}, {j+1}): "); int valor = int.Parse(Console.ReadLine());
                matrizUsuario[i,j] = valor;
            }
        }

        System.Console.WriteLine();
        PasosGauss(matrizUsuario);

        
        System.Console.WriteLine();


        Console.ReadKey();
    }

    public void PasosGauss(int[,] matrizUsuario) {
        for (int i = 0; i < 3; i++)
        {
            int pivote = matrizUsuario[i,i];

            if (matrizUsuario[i,i] == 0)
            {
                System.Console.WriteLine("La matriz no puede convertirse a identidad");
                return;
            }

            for (int j = 0; j < 3; j++)
            {
                if (pivote < matrizUsuario[i,j]) {
                    pivote = matrizUsuario[i,j] + 1;
                }
                matrizUsuario[i,j] = matrizUsuario[i,j] / pivote;
            }

            for (int j = i+1; j < 3; j++)
            {
                int factor = -matrizUsuario[j,i];
                
                for (int k = 0; k < 3; k++)
                {
                    matrizUsuario[j,k] += factor * matrizUsuario[i,k];
                }
            }
        }

        System.Console.WriteLine();

        for (int i = 0; i < matrizUsuario.GetLength(0); i++)
        {
            for (int j = 0; j < matrizUsuario.GetLength(1); j++)
            {
                System.Console.Write(matrizUsuario[i,j] + " ");
            }

            System.Console.WriteLine();
        }
    }
}