using System;

class LeastDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int least = 9;
        do
        {
            int digit = n % 10;
            if (digit < least)
                least = digit;
            n = n / 10;
        } while (n > 0);

        Console.WriteLine("Least digit = " + least);
    }
}
// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319