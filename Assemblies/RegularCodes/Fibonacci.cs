using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;
        Console.Write("First " + n + " Fibonacci terms: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
        Console.WriteLine();
    }
}
// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319