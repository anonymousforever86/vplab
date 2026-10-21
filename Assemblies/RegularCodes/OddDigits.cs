using System;

class OddDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int count = 0;
        while (n > 0)
        {
            int digit = n % 10;
            if (digit % 2 != 0)
                count++;
            n = n / 10;
        }

        Console.WriteLine("Number of odd digits = " + count);
    }
}
// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319