using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string usernamePattern = @"^[\w\d!@#$%^&*()\-_=+{};:,<.>]{3,16}$";

        Console.Write("Enter your Email ID: ");
        string email = Console.ReadLine();

        if (Regex.IsMatch(email, emailPattern))
            Console.WriteLine("Valid Email ID.");
        else
            Console.WriteLine("Invalid Email ID.");

        Console.Write("Enter your Username: ");
        string username = Console.ReadLine();

        if (Regex.IsMatch(username, usernamePattern))
            Console.WriteLine("Valid Username.");
        else
            Console.WriteLine("Invalid Username. Username must be 3 to 16 characters long and can include special characters.");

        Console.ReadKey();
    }
}



















//   notepad TaskA.cs





//   using System;
//   using System.Text.RegularExpressions;

//   class Program
//   {
//       static void Main(string[] args)
//       {
//           string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//           string usernamePattern = @"^[\w\d!@#$%^&*()\-_=+{};:,<.>]{3,16}$";

//           Console.Write("Enter your Email ID: ");
//           string email = Console.ReadLine();

//           if (Regex.IsMatch(email, emailPattern))
//               Console.WriteLine("Valid Email ID.");
//           else
//               Console.WriteLine("Invalid Email ID.");

//           Console.Write("Enter your Username: ");
//           string username = Console.ReadLine();

//           if (Regex.IsMatch(username, usernamePattern))
//               Console.WriteLine("Valid Username.");
//           else
//               Console.WriteLine("Invalid Username. Username must be 3 to 16 characters long and can include special
//   characters.");

//           Console.ReadKey();
//       }
//   }



// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

//  csc TaskA.cs



//  TaskA





















