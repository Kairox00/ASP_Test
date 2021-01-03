<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ins_register.aspx.cs" Inherits="ASP_Test.Ins_register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Instructor Registration</h1>
            First Name: 
            <input id="f_name" type="text" runat="server" /><br />
            Last Name:
            <input id="l_name" type="text" runat="server" /><br />
            Password: 
            <input id="pass" type="password" runat="server"/><br />
            Email:
            <input id="mail" type="email" runat="server"/><br />
            Gender: 
            <input id="gndr" type="text" runat="server"/><br />
            Address: 
            <input id="adrs" type="text" runat="server"/><br />
            <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click" />

        </div>
    </form>
</body>
</html>
