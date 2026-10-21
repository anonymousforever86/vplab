using System;

class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        string result = "";
        foreach (char ch in s)
        {
            if (char.IsUpper(ch))
                result += char.ToLower(ch);
            else if (char.IsLower(ch))
                result += char.ToUpper(ch);
            else
                result += ch;
        }

        Console.WriteLine("Toggled string: " + result);
    }
}
// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319