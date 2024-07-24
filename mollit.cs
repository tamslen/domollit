using System;
using System.Resources;

class Program {
    static void Main() {
        ResourceManager rm = new ResourceManager("Namespace.Resources", typeof(Program).Assembly);

        Console.WriteLine(rm.GetString("greeting"));
        Console.WriteLine(rm.GetString("farewell"));
    }
}
