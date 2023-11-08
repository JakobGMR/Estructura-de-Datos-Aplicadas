class Program{
    static void Main(){
        Console.WriteLine("*********************************************************************************************");
        Console.WriteLine("************************************* PRACTICA DE PILAS *************************************");
        Console.WriteLine("*********************************************************************************************");

        PilaLigada pilaNueva = new();
        int n;
        do{
            Console.Write("\nQué desea hacer:\n1) Agregar\n2) Sacar\n3) Ver el elemento de encima\n4) Imprimir la pila\n5) Buscar\n6) Salir\n\nSu opcion:");
            n = Convert.ToInt16(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("\nIngresa el elemento: ");
                    pilaNueva.Agrega(Console.ReadLine()!);
                    Console.ReadKey();
                break;
                case 2:
                    Console.WriteLine("\nEl elemento extraido es: "+pilaNueva.Retira()+"\n");
                    Console.ReadKey();
                break;
                case 3:
                    Console.WriteLine("\nEl superior es: "+pilaNueva.Tope()+"\n");
                    Console.ReadKey();
                break;
                case 4:
                    pilaNueva.Imprime();
                    Console.ReadKey();
                break;
                case 5:
                    object dato;
                    Console.Write("\nIngresa el dato que deseas buscar: ");
                    dato = Console.ReadLine()!;
                    if ( pilaNueva.busqueda(dato) ){
                        Console.WriteLine("El elemento está en la pila");
                    }
                    else {
                        Console.WriteLine("El elemento no está en la pila");
                    }
                    Console.ReadKey();
                break;
                case 6:                    
                break;
                default:
                break;
            }
        } while ( n != 6 );
    }
}