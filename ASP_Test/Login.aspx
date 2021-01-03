<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASP_Test.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                User ID<br />
                <asp:TextBox ID="username" runat="server"></asp:TextBox><br />
                Password<br />
                <asp:TextBox ID="password" runat="server"></asp:TextBox><br />
            <asp:Button ID="login_btn" runat="server" Text="Login" OnClick="Btn_click"/><br />
            Register as
            <asp:HyperLink href="Ins_register.aspx"  ID="ins_link" runat="server" >Instructor </asp:HyperLink>
            or
            <asp:HyperLink href="Stu_register.aspx" ID="stu_link" runat="server" > Student </asp:HyperLink>
        </div>
        
    </form>
    
</body>
</html>
