<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addPhone.aspx.cs" Inherits="ASP_Test.addPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            Mobile Number<br />
            <asp:TextBox ID="mobileNumber" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="addMobile" />
        </div>
    </form>
</body>
</html>
