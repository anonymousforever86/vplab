using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public class Students : System.Web.UI.Page
    {
        protected TextBox txtName, txtAge, txtEmail, txtDepartment, txtDeleteID;
        protected Label lblMessage;
        protected GridView GridView1;

        string connectionString = ConfigurationManager.ConnectionStrings["StudentDBConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (Name, Age, Email, Department) VALUES (@Name, @Age, @Email, @Department)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            lblMessage.Text = "Student added successfully!";
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtDeleteID.Text));

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                lblMessage.Text = rows > 0 ? "Student deleted successfully!" : "No student with that ID.";
            }
            BindGrid();
        }

        void BindGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}



























// Task 13: Storing and changing student data with ADO.NET

// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319


//   cd /d D:\Assemblies\Task13

//     notepad StudentDB.sql

//     sqlcmd -S "(localdb)\MSSQLLocalDB" -i StudentDB.sql

//     mkdir bin

//     notepad Web.config

//     notepad Students.aspx

//     notepad Students.aspx.cs

//     csc /t:library /r:System.Web.dll /r:System.Data.dll /r:System.Configuration.dll /out:bin\Students.dll Students.aspx.cs

//     "C:\Program Files\IIS Express\iisexpress.exe" /path:D:\Assemblies\Task13 /port:8080

//    Open a browser and go to:  http://localhost:8080/

//   ---

//   File 1: StudentDB.sql

//   CREATE DATABASE StudentDB;
//   GO
//   USE StudentDB;
//   GO
//   CREATE TABLE Students (
//       StudentID  INT PRIMARY KEY IDENTITY(1,1),
//       Name       NVARCHAR(100),
//       Age        INT,
//       Email      NVARCHAR(100),
//       Department NVARCHAR(50)
//   );
//   GO




//   File 2: Web.config

//   <configuration>
//     <connectionStrings>
//       <add name="StudentDBConnectionString"
//            connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True"
//            providerName="System.Data.SqlClient" />
//     </connectionStrings>
//     <system.web>
//       <compilation debug="true" targetFramework="4.8" />
//     </system.web>
//     <system.webServer>
//       <defaultDocument>
//         <files>
//           <add value="Students.aspx" />
//         </files>
//       </defaultDocument>
//     </system.webServer>
//   </configuration>




//   File 3: Students.aspx

  
//   <%@ Page Language="C#" AutoEventWireup="true" Inherits="StudentManagementSystem.Students" %>
//   <!DOCTYPE html>
//   <html>
//   <head runat="server">
//       <title>Student Management</title>
//   </head>
//   <body>
//       <form id="form1" runat="server">
//           <h2>Add Student</h2>
//           Name: <asp:TextBox ID="txtName" runat="server" /><br /><br />
//           Age: <asp:TextBox ID="txtAge" runat="server" /><br /><br />
//           Email: <asp:TextBox ID="txtEmail" runat="server" /><br /><br />
//           Department: <asp:TextBox ID="txtDepartment" runat="server" /><br /><br />
//           <asp:Button ID="btnAdd" runat="server" Text="Add Student" OnClick="btnAdd_Click" />

//           <h2>Delete Student</h2>
//           Student ID: <asp:TextBox ID="txtDeleteID" runat="server" />
//           <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><br /><br />

//           <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />

//           <h2>All Students</h2>
//           <asp:GridView ID="GridView1" runat="server" />
//       </form>
//   </body>
//   </html>





//    Students.aspx.cs 

//   using System;
//   using System.Configuration;
//   using System.Data;
//   using System.Data.SqlClient;
//   using System.Web.UI.WebControls;

//   namespace StudentManagementSystem
//   {
//       public class Students : System.Web.UI.Page
//       {
//           protected TextBox txtName, txtAge, txtEmail, txtDepartment, txtDeleteID;
//           protected Label lblMessage;
//           protected GridView GridView1;

//           string connectionString = ConfigurationManager.ConnectionStrings["StudentDBConnectionString"].ConnectionString;

//           protected void Page_Load(object sender, EventArgs e)
//           {
//               if (!IsPostBack)
//                   BindGrid();
//           }

//           protected void btnAdd_Click(object sender, EventArgs e)
//           {
//               using (SqlConnection conn = new SqlConnection(connectionString))
//               {
//                   string query = "INSERT INTO Students (Name, Age, Email, Department) VALUES (@Name, @Age, @Email, @Department)";
//                   SqlCommand cmd = new SqlCommand(query, conn);
//                   cmd.Parameters.AddWithValue("@Name", txtName.Text);
//                   cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
//                   cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
//                   cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);

//                   conn.Open();
//                   cmd.ExecuteNonQuery();
//               }
//               lblMessage.Text = "Student added successfully!";
//               BindGrid();
//           }

//           protected void btnDelete_Click(object sender, EventArgs e)
//           {
//               using (SqlConnection conn = new SqlConnection(connectionString))
//               {
//                   SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentID = @ID", conn);
//                   cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtDeleteID.Text));

//                   conn.Open();
//                   int rows = cmd.ExecuteNonQuery();
//                   lblMessage.Text = rows > 0 ? "Student deleted successfully!" : "No student with that ID.";
//               }
//               BindGrid();
//           }

//           void BindGrid()
//           {
//               using (SqlConnection conn = new SqlConnection(connectionString))
//               {
//                   SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
//                   DataTable dt = new DataTable();
//                   da.Fill(dt);

//                   GridView1.DataSource = dt;
//                   GridView1.DataBind();
//               }
//           }
//       }
//   }

