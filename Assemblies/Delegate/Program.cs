using System;
using System.Threading;

class Program
{
    delegate int Calc(int a, int b);        // delegate
    delegate void Callback(string msg);     // callback delegate

    static int Add(int a, int b)
    {
        Thread.Sleep(2000);                 // simulate long work
        return a + b;
    }

    static void Show(string msg)
    {
        Console.WriteLine(msg + " (thread " + Thread.CurrentThread.ManagedThreadId + ")");
    }

    static void Main()
    {
        Calc c = Add;
        Callback cb = Show;

        // --- Synchronous invocation (blocks) ---
        Console.WriteLine("Sync call started...");
        Console.WriteLine("Sync result: " + c(10, 20));

        // --- Asynchronous invocation with callback ---
        Console.WriteLine("Async call started...");
        c.BeginInvoke(30, 40, ar => cb("Async result: " + c.EndInvoke(ar)), null);

        Console.WriteLine("Main thread free to do other work...");
        Console.ReadLine();                 // keep app alive for the callback
    }
}
































// Task 2: Delegates, synchronous vs asynchronous calls, and callbacks


// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

//  cd /d D:\Assemblies\Task2

// notepad Program.cs


// using System;
//   using System.Threading;

//   class Program
//   {
//       delegate int Calc(int a, int b);        
//       delegate void Callback(string msg);    

//       static int Add(int a, int b)
//       {
//           Thread.Sleep(2000);               
//           return a + b;
//       }

//       static void Show(string msg)
//       {
//           Console.WriteLine(msg + " (thread " + Thread.CurrentThread.ManagedThreadId + ")");
//       }

//       static void Main()
//       {
//           Calc c = Add;
//           Callback cb = Show;

          
//           Console.WriteLine("Sync call started...");
//           Console.WriteLine("Sync result: " + c(10, 20));

          
//           Console.WriteLine("Async call started...");
//           c.BeginInvoke(30, 40, ar => cb("Async result: " + c.EndInvoke(ar)), null);

//           Console.WriteLine("Main thread free to do other work...");
//           Console.ReadLine();                 
//       }
//   }



//  csc Program.cs


//  Program