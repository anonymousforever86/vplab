using System;

class AddTwo
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }
}

// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319