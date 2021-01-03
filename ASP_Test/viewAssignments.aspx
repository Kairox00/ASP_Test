<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAssignments.aspx.cs" Inherits="ASP_Test.viewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course ID:
            <br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Views" onclick="viewAssign"/>
        </div>
    </form>
</body>
</html>
