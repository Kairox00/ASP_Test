<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enrollInCourse.aspx.cs" Inherits="ASP_Test.enrollInCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CourseID
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            Instructor ID
            <asp:TextBox ID="InstructorID" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Enroll" onclick="enroll"/>
        </div>
    </form>
</body>
</html>
