using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Web.UI.WebControls;

namespace EmpApp
{
    [Table(Name = "Employees")]
    public class Employee
    {
        [Column(IsPrimaryKey = true)] public int EmpNo { get; set; }
        [Column] public string EmpName { get; set; }
        [Column] public decimal EmpSal { get; set; }
        [Column] public string EmpJob { get; set; }
        [Column] public int EmpDeptNo { get; set; }
    }

    public class Employees : System.Web.UI.Page
    {
        protected GridView GridView1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmpDB;Integrated Security=True";

                using (DataContext db = new DataContext(conStr))
                {
                    var employees = from emp in db.GetTable<Employee>()
                                    select emp;

                    GridView1.DataSource = employees;
                    GridView1.DataBind();
                }
            }
        }
    }
}


























// Task 10: Showing employee data in a GridView with LINQ to SQL




// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319



// Commands, in order

//     cd /d D:\Assemblies\Task10
//     notepad Employees.sql
//     sqlcmd -S "(localdb)\MSSQLLocalDB" -i Employees.sql
//     mkdir bin
//     notepad Employees.aspx
//     notepad Employees.aspx.cs
//     notepad Web.config
//     csc /t:library /r:System.Web.dll /r:System.Data.Linq.dll /out:bin\Employees.dll Employees.aspx.cs
//     "C:\Program Files\IIS Express\iisexpress.exe" /path:D:\Assemblies\Task10 /port:8080
//    Open a browser and go to:  http://localhost:8080/
//    Press Q in the command prompt to stop the server
  

//   ---

//    Employees.sql 

//   CREATE DATABASE EmpDB;
//   GO
//   USE EmpDB;
//   GO
//   CREATE TABLE Employees (
//       EmpNo     INT PRIMARY KEY,
//       EmpName   VARCHAR(50),
//       EmpSal    DECIMAL(10, 2),
//       EmpJob    VARCHAR(50),
//       EmpDeptNo INT
//   );
//   GO
//   INSERT INTO Employees VALUES
//   (101, 'Rajesh', 55000, 'Manager',   10),
//   (102, 'Priya',  42000, 'Developer', 20),
//   (103, 'Arjun',  38000, 'Tester',    20),
//   (104, 'Sneha',  47000, 'Analyst',   30),
//   (105, 'Kiran',  30000, 'Clerk',     10);
//   GO
//   SELECT * FROM Employees;
//   GO




//  Employees.aspx 

//   aspx
//   <%@ Page Language="C#" AutoEventWireup="true" Inherits="EmpApp.Employees" %>
//   <!DOCTYPE html>
//   <html>
//   <head runat="server">
//       <title>Employees Information</title>
//   </head>
//   <body>
//       <form id="form1" runat="server">
//           <h2>Employee Details</h2>
//           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
//       </form>
//   </body>
//   </html>

//   Employees.aspx.cs 

//   using System;
//   using System.Linq;
//   using System.Data.Linq;
//   using System.Data.Linq.Mapping;
//   using System.Web.UI.WebControls;

//   namespace EmpApp
//   {
//       [Table(Name = "Employees")]
//       public class Employee
//       {
//           [Column(IsPrimaryKey = true)] public int EmpNo { get; set; }
//           [Column] public string EmpName { get; set; }
//           [Column] public decimal EmpSal { get; set; }
//           [Column] public string EmpJob { get; set; }
//           [Column] public int EmpDeptNo { get; set; }
//       }

//       public class Employees : System.Web.UI.Page
//       {
//           protected GridView GridView1;

//           protected void Page_Load(object sender, EventArgs e)
//           {
//               if (!IsPostBack)
//               {
//                   string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmpDB;Integrated Security=True";

//                   using (DataContext db = new DataContext(conStr))
//                   {
//                       var employees = from emp in db.GetTable<Employee>()
//                                       select emp;

//                       GridView1.DataSource = employees;
//                       GridView1.DataBind();
//                   }
//               }
//           }
//       }
//   }

//    Web.config

//   <configuration>
//     <system.web>
//       <compilation debug="true" targetFramework="4.8" />
//     </system.web>
//     <system.webServer>
//       <defaultDocument>
//         <files>
//           <add value="Employees.aspx" />
//         </files>
//       </defaultDocument>
//     </system.webServer>
//   </configuration>


