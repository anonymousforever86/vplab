<%@ Page Language="C#" AutoEventWireup="true" Inherits="StudentManagementSystem.Students" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Add Student</h2>
        Name: <asp:TextBox ID="txtName" runat="server" /><br /><br />
        Age: <asp:TextBox ID="txtAge" runat="server" /><br /><br />
        Email: <asp:TextBox ID="txtEmail" runat="server" /><br /><br />
        Department: <asp:TextBox ID="txtDepartment" runat="server" /><br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Student" OnClick="btnAdd_Click" />

        <h2>Delete Student</h2>
        Student ID: <asp:TextBox ID="txtDeleteID" runat="server" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><br /><br />

        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />

        <h2>All Students</h2>
        <asp:GridView ID="GridView1" runat="server" />
    </form>
</body>
</html>
