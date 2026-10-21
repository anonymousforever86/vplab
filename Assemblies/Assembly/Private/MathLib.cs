namespace MyMathLib
{
    public class Calculator
    {
        public int Add(int a, int b) { return a + b; }
        public int Mul(int a, int b) { return a * b; }
    }
}
































































// Task 6 (short version): Private and public assemblies

// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

//  cd /d D:\Assemblies\Task6_Modified\Private


//   notepad MathLib.cs

//   MathLib.cs (the assembly)

//   namespace MyMathLib
//   {
//       public class Calculator
//       {
//           public int Add(int a, int b) { return a + b; }
//           public int Mul(int a, int b) { return a * b; }
//       }
//   }



//   csc /t:library MathLib.cs

//   notepad App.cs

// App.cs (the app that uses it)

//   using System;
//   using MyMathLib;

//   class App
//   {
//       static void Main()
//       {
//           Calculator c = new Calculator();
//           Console.WriteLine("Sum     = " + c.Add(10, 5));
//           Console.WriteLine("Product = " + c.Mul(10, 5));
//       }
//   }




//   csc /r:MathLib.dll App.cs


//   App

