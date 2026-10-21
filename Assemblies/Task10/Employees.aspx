<%@ Page Language="C#" AutoEventWireup="true" Inherits="EmpApp.Employees" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Employees Information</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Employee Details</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
    </form>
</body>
</html>
