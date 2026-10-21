using System;

class Palindrome
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        string rev = "";
        for (int i = s.Length - 1; i >= 0; i--)
            rev += s[i];

        if (s.ToLower() == rev.ToLower())
            Console.WriteLine(s + " is a Palindrome");
        else
            Console.WriteLine(s + " is not a Palindrome");
    }
}
// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319