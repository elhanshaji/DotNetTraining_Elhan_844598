<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspExercise_11_2_20.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="fnval" runat="server" BorderStyle="None" ControlToValidate="fname" ErrorMessage="First name is required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            <br />
            Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="age" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="ageval" runat="server" ControlToValidate="age" ErrorMessage="Minimum Age is 16" ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="16">*</asp:CompareValidator>
            <br />
            Login Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="lgn" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="lgnval" runat="server" ControlToValidate="lgn" ErrorMessage="Login name required" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="pwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="pwd" ErrorMessage="Password Required" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            Confirm Password:<asp:TextBox ID="cpwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pwd" ControlToValidate="cpwd" ErrorMessage="Password not matching!" ForeColor="Red">*</asp:CompareValidator>
            <br />
            Experience:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="exp" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="exp" ErrorMessage="Experience Required is not within the required range" ForeColor="Red" MaximumValue="10" MinimumValue="5" Type="Integer">*</asp:RangeValidator>
            <br />
            Salary Expected:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="sal" runat="server"></asp:TextBox>
        

            <asp:CompareValidator ID="SalVal" runat="server" ControlToValidate="sal" ErrorMessage="Salary is beyond our expectation" ForeColor="Red" Operator="LessThanEqual" Type="Double" ValueToCompare="40000">*</asp:CompareValidator>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add New User" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        

        </div>
    </form>
</body>
</html>
