using System;

interface IShape
{
    void Area();
}

interface IShape3D : IShape 
{
    void Volume();
}

class Cube : IShape3D
{
    double s = 3;

    void IShape.Area()   { Console.WriteLine("Surface Area = " + 6 * s * s); }
    void IShape3D.Volume() { Console.WriteLine("Volume = " + s * s * s); }
}

class Program
{
    static void Main()
    {
        Cube c = new Cube();
        // c.Area(); 

        IShape s = c;      
        IShape3D v = c;    

        s.Area();
        v.Area();         
        v.Volume();
    }
}


































//  Task 3: Interface inheritance and explicit interface implementation


// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319


//  cd /d D:\Assemblies\Task3


// notepad Task3.cs


// using System;

//   interface IShape
//   {
//       void Area();
//   }

//   interface IShape3D : IShape  
//   {
//       void Volume();
//   }

//   class Cube : IShape3D
//   {
//       double s = 3;

//       void IShape.Area()   { Console.WriteLine("Surface Area = " + 6 * s * s); }
//       void IShape3D.Volume() { Console.WriteLine("Volume = " + s * s * s); }
//   }

//   class Program
//   {
//       static void Main()
//       {
//           Cube c = new Cube();
//           // c.Area();  

//           IShape s = c;      
//           IShape3D v = c;    

//           s.Area();
//           v.Area();         
//           v.Volume();
//       }
//   }




// csc Task3.cs
  



//   Task3