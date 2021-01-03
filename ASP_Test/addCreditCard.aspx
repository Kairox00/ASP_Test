<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCreditCard.aspx.cs" Inherits="ASP_Test.addCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Card Number<br />
            <asp:TextBox ID="cardNumber" runat="server"></asp:TextBox><br />
            Card Holder Name<br />
            <asp:TextBox ID="card_holder_name" runat="server"></asp:TextBox><br />
            Expiry Date<br />
            <asp:Calendar ID="expiry_calendar" runat="server"></asp:Calendar><br />
            CVV<br />
            <asp:TextBox ID="cvv_box" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="addCard" />
        </div>
    </form>
</body>
</html>
