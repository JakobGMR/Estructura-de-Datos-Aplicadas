                //Ejemplo de una Pila en C# (Valores iniciados)

class Program 

{ 
    static void Main() { 
        // An example string array. 
        string[] values = { "Dot", "Net", "Perls" }; 

        // Copy an array into a Stack. 
        var stack = new Stack<string>(values); 
        
        // Display the Stack. 
        Console.WriteLine("--- Stack contents ---"); 

        foreach (string value in stack) { 
            Console.WriteLine(value); 
        }  

        // See if the stack contains "Perls" 
        Console.WriteLine("--- Stack Contains method result ---"); 

        bool contains = stack.Contains("Perls"); 
        Console.WriteLine(contains); 
    } 
}