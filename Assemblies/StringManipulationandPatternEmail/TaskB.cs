using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("String Class Manipulation:");

        string str = "Hello, World!";
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("After Concatenation: " + (str + " Welcome to string manipulation."));
        Console.WriteLine("Substring (7, 5): " + str.Substring(7, 5));
        Console.WriteLine("After Replace: " + str.Replace("World", "C#"));
        Console.WriteLine("ToUpper: " + str.ToUpper());
        Console.WriteLine("ToLower: " + str.ToLower());
        Console.WriteLine("Trimmed String: '" + "   Hello, World!   ".Trim() + "'");
        Console.WriteLine("Length of String: " + str.Length);

        Console.WriteLine("\nStringBuilder Class Manipulation:");

        StringBuilder sb = new StringBuilder("Hello, World!");

        sb.Append(" Welcome to string manipulation.");
        Console.WriteLine("After Append: " + sb.ToString());

        sb.Insert(7, "beautiful ");
        Console.WriteLine("After Insert: " + sb.ToString());

        sb.Remove(7, 10);
        Console.WriteLine("After Remove: " + sb.ToString());

        sb.Replace("World", "C#");
        Console.WriteLine("After Replace: " + sb.ToString());

        Console.WriteLine("Length of StringBuilder: " + sb.Length);

        sb.Clear();
        Console.WriteLine("After Clear: " + sb.ToString());

        Console.ReadKey();
    }
}





























//  cd /d D:\Assemblies\Task1

//   notepad TaskB.cs


// using System;
//   using System.Text;

//   class Program
//   {
//       static void Main(string[] args)
//       {
//           Console.WriteLine("String Class Manipulation:");

//           string str = "Hello, World!";
//           Console.WriteLine("Original String: " + str);
//           Console.WriteLine("After Concatenation: " + (str + " Welcome to string manipulation."));
//           Console.WriteLine("Substring (7, 5): " + str.Substring(7, 5));
//           Console.WriteLine("After Replace: " + str.Replace("World", "C#"));
//           Console.WriteLine("ToUpper: " + str.ToUpper());
//           Console.WriteLine("ToLower: " + str.ToLower());
//           Console.WriteLine("Trimmed String: '" + "   Hello, World!   ".Trim() + "'");
//           Console.WriteLine("Length of String: " + str.Length);

//           Console.WriteLine("\nStringBuilder Class Manipulation:");

//           StringBuilder sb = new StringBuilder("Hello, World!");

//           sb.Append(" Welcome to string manipulation.");
//           Console.WriteLine("After Append: " + sb.ToString());

//           sb.Insert(7, "beautiful ");
//           Console.WriteLine("After Insert: " + sb.ToString());

//           sb.Remove(7, 10);
//           Console.WriteLine("After Remove: " + sb.ToString());

//           sb.Replace("World", "C#");
//           Console.WriteLine("After Replace: " + sb.ToString());

//           Console.WriteLine("Length of StringBuilder: " + sb.Length);

//           sb.Clear();
//           Console.WriteLine("After Clear: " + sb.ToString());

//           Console.ReadKey();
//       }
//   }







//   csc TaskB.cs

//   TaskB
