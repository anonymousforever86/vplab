using System;

class VowelCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        int count = 0;
        foreach (char ch in s.ToLower())
        {
            if ("aeiou".IndexOf(ch) >= 0)
                count++;
        }

        Console.WriteLine("Number of vowels = " + count);
    }
}
// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319