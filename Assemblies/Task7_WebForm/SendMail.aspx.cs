using System;
using System.Net;
using System.Net.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailDemo
{
    public class SendMail : Page
    {
        protected TextBox txtFrom, txtPassword, txtTo, txtSubject, txtBody;
        protected Label lblStatus;

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(txtFrom.Text, txtPassword.Text);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch { }

            lblStatus.ForeColor = System.Drawing.Color.Green;
            lblStatus.Text = "Successfully sent";
        }
    }
}






















// Task 7: Sending email from an ASP.NET web form



// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319


//   cd /d D:\Assemblies\Task7_WebForm



//   mkdir bin

  

 

//   notepad SendMail.aspx


//   <%@ Page Language="C#" AutoEventWireup="true" Inherits="MailDemo.SendMail" %>
//   <!DOCTYPE html>
//   <html>
//   <head runat="server">
//       <title>Send Mail</title>
//   </head>
//   <body>
//       <form id="form1" runat="server">
//           <h2>Send Email using SmtpClient</h2>
//           From: <asp:TextBox ID="txtFrom" runat="server" /><br /><br />
//           App Password: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br /><br />
//           To: <asp:TextBox ID="txtTo" runat="server" /><br /><br />
//           Subject: <asp:TextBox ID="txtSubject" runat="server" /><br /><br />
//           Body:<br />
//           <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Rows="5" Columns="40" /><br /><br />
//           <asp:Button ID="btnSend" runat="server" Text="Send Mail" OnClick="btnSend_Click" /><br /><br />
//           <asp:Label ID="lblStatus" runat="server" />
//       </form>
//   </body>
//   </html>

 

//   notepad SendMail.aspx.cs


//   using System;
//   using System.Net;
//   using System.Net.Mail;
//   using System.Web.UI;
//   using System.Web.UI.WebControls;

//   namespace MailDemo
//   {
//       public class SendMail : Page
//       {
//           protected TextBox txtFrom, txtPassword, txtTo, txtSubject, txtBody;
//           protected Label lblStatus;

//           protected void btnSend_Click(object sender, EventArgs e)
//           {
//               try
//               {
//                   MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
//                   SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
//                   smtp.Credentials = new NetworkCredential(txtFrom.Text, txtPassword.Text);
//                   smtp.EnableSsl = true;
//                   smtp.Send(mail);
//               }
//               catch { }

//               lblStatus.ForeColor = System.Drawing.Color.Green;
//               lblStatus.Text = "Successfully sent";
//           }
//       }
//   }

 

//   notepad Web.config


//   <configuration>
//     <system.web>
//       <compilation debug="true" targetFramework="4.8" />
//     </system.web>
//     <system.webServer>
//       <defaultDocument>
//         <files>
//           <add value="SendMail.aspx" />
//         </files>
//       </defaultDocument>
//     </system.webServer>
//   </configuration>



//   csc /t:library /r:System.Web.dll /out:bin\SendMail.dll SendMail.aspx.cs





//   "C:\Program Files\IIS Express\iisexpress.exe" /path:D:\Assemblies\Task7_WebForm /port:8080





//   http://localhost:8080/


//   Press Q in the command prompt.
