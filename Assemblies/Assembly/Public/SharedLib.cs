using System;
using System.Reflection;

[assembly: AssemblyVersion("1.0.0.0")]

namespace SharedLib
{
    public class Greeter
    {
        public void Print()
        {
            Console.WriteLine("Hi from Shared Assembly");
        }
    }
}







































//  Part B: Public (shared) assembly in the GAC


// set PATH=%PATH%;C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools



  


//   cd /d D:\Assemblies\Task6_Modified\Public


//   notepad SharedLib.cs

//   Type the SharedLib.cs code, save with Ctrl+S, and close Notepad.


//   sn -k SharedLib.snk



//   csc /t:library /keyfile:SharedLib.snk SharedLib.cs
  

 
//   sn -T SharedLib.dll


//   Stage 2: Put it in the GAC


//   gacutil -i SharedLib.dll


//   gacutil -l SharedLib

//   Stage 3: Build and run the app that uses it


//   cd ..\PublicApp

 
//   notepad App.cs
 

 
//   csc /r:..\Public\SharedLib.dll App.cs



//   App







//   SharedLib.cs (the assembly)

//   The version attribute is in this file, so no separate AssemblyInfo.cs is needed.
//   using System;
//   using System.Reflection;

//   [assembly: AssemblyVersion("1.0.0.0")]

//   namespace SharedLib
//   {
//       public class Greeter
//       {
//           public void Print()
//           {
//               Console.WriteLine("Hi from Shared Assembly");
//           }
//       }
//   }



//   PublicApp\App.cs (the app that uses it)

//   using System;
//   using SharedLib;

//   class App
//   {
//       static void Main()
//       {
//           Greeter g = new Greeter();
//           g.Print();
//           Console.WriteLine("From GAC? : " + typeof(Greeter).Assembly.GlobalAssemblyCache);
//       }
//   }


  