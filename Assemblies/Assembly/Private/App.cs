using System;
using MyMathLib;

class App
{
    static void Main()
    {
        Calculator c = new Calculator();
        Console.WriteLine("Sum     = " + c.Add(10, 5));
        Console.WriteLine("Product = " + c.Mul(10, 5));
    }
}
