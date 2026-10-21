using System;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class WebForm1 : System.Web.UI.Page
    {
        protected Label lblResult;

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblResult.Text = "Registration Successful!";
            }
        }
    }
}

















































// Task 9 : Web Pages





// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319




// Commands, in order

//     cd /d D:\Assemblies\Task9
//     mkdir bin
//     notepad WebForm1.aspx
//     notepad WebForm1.aspx.cs
//     notepad Web.config
//     csc /t:library /r:System.Web.dll /out:bin\WebForm1.dll WebForm1.aspx.cs
//     "C:\Program Files\IIS Express\iisexpress.exe" /path:D:\Assemblies\Task9 /port:8080
//     http://localhost:8080/
 
//   10. Press Q in the command prompt to stop the server

//   ---

//   File 1: WebForm1.aspx

//   aspx
//   <%@ Page Language="C#" AutoEventWireup="true" Inherits="WebApplication1.WebForm1" %>

//   <!DOCTYPE html>
//   <html>
//   <head runat="server">
//       <title>Registration Form</title>
//   </head>
//   <body>
//   <form id="form1" runat="server">

//       <h2>Registration Form</h2>

//       Name:
//       <asp:TextBox ID="txtName" runat="server" />
//       <asp:RequiredFieldValidator runat="server"
//           ControlToValidate="txtName"
//           ErrorMessage="Name is required" ForeColor="Red" />
//       <br /><br />

//       Password:
//       <asp:TextBox ID="txtPassword" runat="server"
//           TextMode="Password" />
//       <asp:RequiredFieldValidator runat="server"
//           ControlToValidate="txtPassword"
//           ErrorMessage="Password is required" ForeColor="Red" />
//       <br /><br />

//       Confirm Password:
//       <asp:TextBox ID="txtConfirm" runat="server"
//           TextMode="Password" />
//       <asp:RequiredFieldValidator runat="server"
//           ControlToValidate="txtConfirm"
//           ErrorMessage="Confirm password is required" ForeColor="Red" />
//       <asp:CompareValidator runat="server"
//           ControlToValidate="txtConfirm"
//           ControlToCompare="txtPassword"
//           ErrorMessage="Passwords do not match" ForeColor="Red" />
//       <br /><br />

//       Age:
//       <asp:TextBox ID="txtAge" runat="server" />
//       <asp:RequiredFieldValidator runat="server"
//           ControlToValidate="txtAge"
//           ErrorMessage="Age is required" ForeColor="Red" />
//       <asp:RangeValidator runat="server"
//           ControlToValidate="txtAge"
//           MinimumValue="21" MaximumValue="30"
//           Type="Integer"
//           ErrorMessage="Age must be 21-30" ForeColor="Red" />
//       <br /><br />

//       Email ID:
//       <asp:TextBox ID="txtEmail" runat="server" />
//       <asp:RequiredFieldValidator runat="server"
//           ControlToValidate="txtEmail"
//           ErrorMessage="Email is required" ForeColor="Red" />
//       <asp:RegularExpressionValidator runat="server"
//           ControlToValidate="txtEmail"
//           ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
//           ErrorMessage="Enter a valid email" ForeColor="Red" />
//       <br /><br />

//       User ID:
//       <asp:TextBox ID="txtUserID" runat="server" />
//       <asp:RequiredFieldValidator runat="server"
//           ControlToValidate="txtUserID"
//           ErrorMessage="User ID is required" ForeColor="Red" />
//       <asp:RegularExpressionValidator runat="server"
//           ControlToValidate="txtUserID"
//           ValidationExpression="^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{7,20}$"
//           ErrorMessage="User ID must be 7-20 characters with a capital letter and digit"
//           ForeColor="Red" />
//       <br /><br />

//       <asp:ValidationSummary ID="ValidationSummary1"
//           runat="server" ForeColor="Red" />

//       <asp:Button ID="btnSubmit" runat="server"
//           Text="Register" OnClick="btnSubmit_Click" />

//       <br /><br />
//       <asp:Label ID="lblResult" runat="server" ForeColor="Green" />

//   </form>
//   </body>
//   </html>

//   File 2: WebForm1.aspx.cs

//   using System;
//   using System.Web.UI.WebControls;

//   namespace WebApplication1
//   {
//       public class WebForm1 : System.Web.UI.Page
//       {
//           protected Label lblResult;

//           protected void btnSubmit_Click(object sender, EventArgs e)
//           {
//               if (Page.IsValid)
//               {
//                   lblResult.Text = "Registration Successful!";
//               }
//           }
//       }
//   }

//   File 3: Web.config

//   <configuration>
//     <appSettings>
//       <add key="ValidationSettings:UnobtrusiveValidationMode" value="None" />
//     </appSettings>
//     <system.web>
//       <compilation debug="true" targetFramework="4.8" />
//     </system.web>
//     <system.webServer>
//       <defaultDocument>
//         <files>
//           <add value="WebForm1.aspx" />
//         </files>
//       </defaultDocument>
//     </system.webServer>
//   </configuration>