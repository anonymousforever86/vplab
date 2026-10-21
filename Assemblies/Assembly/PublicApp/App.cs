using System;
using SharedLib;

class App
{
    static void Main()
    {
        Greeter g = new Greeter();
        g.Print();
        Console.WriteLine("From GAC? : " + typeof(Greeter).Assembly.GlobalAssemblyCache);
    }
}
