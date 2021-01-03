<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPortal.aspx.cs" Inherits="ASP_Test.StudentPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink href="StudentProfile.aspx" ID="HyperLink6" runat="server">View Profile</asp:HyperLink>
            <br />
            <asp:HyperLink href="addPhone.aspx" ID="HyperLink1" runat="server">Add Phone</asp:HyperLink>
            <br />
            <asp:HyperLink href="courses.aspx" ID="HyperLink2" runat="server"> View Courses</asp:HyperLink>
            <br />
            <asp:HyperLink href="enrollInCourse.aspx" ID="HyperLink5" runat="server">Enroll in Courses</asp:HyperLink>
            <br />
            <asp:HyperLink href="addCreditCard.aspx" ID="HyperLink3" runat="server">Add Credit Card</asp:HyperLink>
            <br />
            <asp:HyperLink href="viewPromos.aspx" ID="HyperLink4" runat="server">View my Promocodes</asp:HyperLink>
            <br />
            <asp:HyperLink href="viewAssignments.aspx" ID="HyperLink7" runat="server">View assignments content</asp:HyperLink>
            <br />
            <asp:HyperLink href="submitAssignmnets.aspx" ID="HyperLink8" runat="server">Submit Assignment</asp:HyperLink>
            <br />
            <asp:HyperLink href="viewAssignGrades.aspx" ID="HyperLink9" runat="server">View assignments grades</asp:HyperLink>
            <br />
            <asp:HyperLink href="addMyFeedback.aspx" ID="HyperLink10" runat="server">Add course feedback</asp:HyperLink>
            <br />
            <asp:HyperLink href="listCertificates.aspx" ID="HyperLink11" runat="server">View my Certificates</asp:HyperLink>
            <br />

        </div>
    </form>
</body>
</html>
