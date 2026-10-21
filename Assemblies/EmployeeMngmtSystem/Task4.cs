using System;
 
namespace EmployeeManagementSystem
{
    // Base class
    class Person
    {
        public string FirstName, LastName, Gender;
        public DateTime DOB;
    }
 
    // Child 1
    class Employee : Person
    {
        public string Department, Location;
        public int EmpSequence, YearsOfExperience;
 
        public Employee(string fn, string ln, string dept, string loc, int seq, int exp)
        {
            if (seq < 1 || seq > 9999)
                throw new ArgumentException("Employee sequence must be 1-9999");
            FirstName = fn; LastName = ln;
            Department = dept; Location = loc;
            EmpSequence = seq; YearsOfExperience = exp;
        }
 
        public string GenerateEmailID()
        {
            return Registration.UserID + "@Tokyo.com";
        }
 
        public double CalculateSalary()
        {
            double net = YearsOfExperience * 100000.0;   
            return net + (net * 0.10);                   
        }
    }
 
    // Child 2
    class Registration : Employee
    {
        public static int EmployeeID;
        public static string UserID;
 
        public Registration(string fn, string ln, string dept, string loc, int seq, int exp)
            : base(fn, ln, dept, loc, seq, exp)
        {
            GenerateEmployeeID();
            GenerateUserID();
        }
 
        public void GenerateEmployeeID()
        {
            EmployeeID = 10000 + EmpSequence;
        }
 
        public void GenerateUserID()
        {
            UserID = FirstName.Substring(0, 2).ToUpper() + EmployeeID;
        }
    }
 
    class Program
    {
        static void Main()
        {
            Registration emp = new Registration("Rajesh", "Sharma", "IT", "Tokyo", 101, 5);
 
            Console.WriteLine("Employee ID : " + Registration.EmployeeID);
            Console.WriteLine("User ID     : " + Registration.UserID);
            Console.WriteLine("Email ID    : " + emp.GenerateEmailID());
            Console.WriteLine("Salary      : " + emp.CalculateSalary());
        }
    }
}
























// Task 4: Employee management system using inheritance




// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319



// cd /d D:\Assemblies\Task4

// notepad Task4.cs

//  using System;

//   namespace EmployeeManagementSystem
//   {
     
//       class Person
//       {
//           public string FirstName, LastName, Gender;
//           public DateTime DOB;
//       }

     
//       class Employee : Person
//       {
//           public string Department, Location;
//           public int EmpSequence, YearsOfExperience;

//           public Employee(string fn, string ln, string dept, string loc, int seq, int exp)
//           {
//               if (seq < 1 || seq > 9999)
//                   throw new ArgumentException("Employee sequence must be 1-9999");
//               FirstName = fn; LastName = ln;
//               Department = dept; Location = loc;
//               EmpSequence = seq; YearsOfExperience = exp;
//           }

//           public string GenerateEmailID()
//           {
//               return Registration.UserID + "@Tokyo.com";
//           }

//           public double CalculateSalary()
//           {
//               double net = YearsOfExperience * 100000.0;   
//               return net + (net * 0.10);                   
//           }
//       }

      
//       class Registration : Employee
//       {
//           public static int EmployeeID;
//           public static string UserID;

//           public Registration(string fn, string ln, string dept, string loc, int seq, int exp)
//               : base(fn, ln, dept, loc, seq, exp)
//           {
//               GenerateEmployeeID();
//               GenerateUserID();
//           }

//           public void GenerateEmployeeID()
//           {
//               EmployeeID = 10000 + EmpSequence;
//           }

//           public void GenerateUserID()
//           {
//               UserID = FirstName.Substring(0, 2).ToUpper() + EmployeeID;
//           }
//       }

//       class Program
//       {
//           static void Main()
//           {
//               Registration emp = new Registration("Rajesh", "Sharma", "IT", "Tokyo", 101, 5);

//               Console.WriteLine("Employee ID : " + Registration.EmployeeID);
//               Console.WriteLine("User ID     : " + Registration.UserID);
//               Console.WriteLine("Email ID    : " + emp.GenerateEmailID());
//               Console.WriteLine("Salary      : " + emp.CalculateSalary());
//           }
//       }
//   }


//  csc Task4.cs


//   Task4

