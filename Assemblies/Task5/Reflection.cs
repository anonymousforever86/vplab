using System;
using System.Reflection;

public class Sample
{
    public int Id;
    public string Name { get; set; }
    public void Show(int x) { }
}

class Program
{
    static void Main()
    {
        Type t = typeof(Sample);
        Console.WriteLine("Assembly: " + t.Assembly.FullName);
        Console.WriteLine("Type: " + t.FullName);

        foreach (FieldInfo f in t.GetFields())
            Console.WriteLine("  Field: " + f.Name + " : " + f.FieldType.Name);

        foreach (PropertyInfo p in t.GetProperties())
            Console.WriteLine("  Property: " + p.Name + " : " + p.PropertyType.Name);

        foreach (MethodInfo m in t.GetMethods())
            Console.WriteLine("  Method: " + m.Name + "() : " + m.ReturnType.Name);

        Console.ReadKey();
    }
}



























// Task 5: Reflection, reading a type's details at runtime





// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319



//  cd /d D:\Assemblies\Task5


//  notepad Reflection.cs

//  using System;
//   using System.Reflection;

//   public class Sample
//   {
//       public int Id;
//       public string Name { get; set; }
//       public void Show(int x) { }
//   }

//   class Program
//   {
//       static void Main()
//       {
//           Type t = typeof(Sample);
//           Console.WriteLine("Assembly: " + t.Assembly.FullName);
//           Console.WriteLine("Type: " + t.FullName);

//           foreach (FieldInfo f in t.GetFields())
//               Console.WriteLine("  Field: " + f.Name + " : " + f.FieldType.Name);

//           foreach (PropertyInfo p in t.GetProperties())
//               Console.WriteLine("  Property: " + p.Name + " : " + p.PropertyType.Name);

//           foreach (MethodInfo m in t.GetMethods())
//               Console.WriteLine("  Method: " + m.Name + "() : " + m.ReturnType.Name);

//           Console.ReadKey();
//       }
//   }


//  csc Reflection.cs


//   Reflection