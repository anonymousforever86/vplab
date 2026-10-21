<%@ Page Language="C#" AutoEventWireup="true" Inherits="MailDemo.SendMail" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Send Mail</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Send Email using SmtpClient</h2>
        From: <asp:TextBox ID="txtFrom" runat="server" /><br /><br />
        App Password: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br /><br />
        To: <asp:TextBox ID="txtTo" runat="server" /><br /><br />
        Subject: <asp:TextBox ID="txtSubject" runat="server" /><br /><br />
        Body:<br />
        <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Rows="5" Columns="40" /><br /><br />
        <asp:Button ID="btnSend" runat="server" Text="Send Mail" OnClick="btnSend_Click" /><br /><br />
        <asp:Label ID="lblStatus" runat="server" />
    </form>
</body>
</html>
