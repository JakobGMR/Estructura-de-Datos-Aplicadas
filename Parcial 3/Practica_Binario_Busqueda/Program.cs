internal class Program
{
    private static void Main(string[] args)
    {
        ArbolBinario arbol = new ArbolBinario();
            
        while(true)
        {
            Console.Clear();
            Console.WriteLine("       ARBOLES BINARIOS DE BUSQUEDA");
            Console.WriteLine("1.- Insertar");
            System.Console.WriteLine("2.- Buscar número");
            System.Console.WriteLine("3.- Eliminar número");
            System.Console.WriteLine("4.- Listar números");
            Console.WriteLine("5.- Salir\n");
            string resp = Console.ReadLine()!;
            switch (resp)
            {
                case "1":
                    Console.WriteLine("Escribe un valor entero");
                    arbol.Inserta(int.Parse(Console.ReadLine()!));
                    break;

                case "2":
                    Console.WriteLine("Escribe un valor entero a buscar dentro del árbol");
                    arbol.Busqueda(int.Parse(Console.ReadLine()!));
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("Escribe el número a eliminar dentro árbol");
                    arbol.BorrarElemento(int.Parse(Console.ReadLine()!));
                    Console.ReadKey();
                    break;

                case "4":
                    Program runSub = new Program();
                    runSub.SubMenuListar(arbol);
                    break;

                case "6":
                    Console.Clear();
                    arbol.ImprimirEnConsola();
                    Console.ReadKey();
                    break;
                
                case "5":
                    System.Console.WriteLine("Cerrando el programa..."); Thread.Sleep(1000);
                    return;

                default: System.Console.WriteLine("Elija una opción correcta");
                    break;
            }
        }
    }

    private void SubMenuListar(ArbolBinario arbol) {
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("Elija entre los tipos de listado \n");

            System.Console.WriteLine("1.- Preproceso");
            System.Console.WriteLine("2.- Inproceso");
            System.Console.WriteLine("3.- Postproceso");
            System.Console.WriteLine("4.- Volver\n");

            System.Console.Write("Opcion: "); string opc = Console.ReadLine()!;

            switch (opc)
            {
                case "1":
                    ArbolBinario.ListaNumeros.Clear();
                    arbol.ListarPreproceso();
                    Console.ReadKey();
                    break;

                case "2":
                    ArbolBinario.ListaNumeros.Clear();
                    arbol.ListarInproceso();
                    Console.ReadKey();
                    break;

                case "3":
                    ArbolBinario.ListaNumeros.Clear();
                    arbol.ListarPostproceso();
                    Console.ReadKey();
                    break;

                case "4":
                    return;

                default:
                    System.Console.WriteLine("Pulse la tecla correcta");
                    Console.ReadKey();
                    break;
            }
        }
    }
}