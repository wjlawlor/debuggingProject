<%@ Page Trace="true" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="errorHandlingExample.Defult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error Handling Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Number1" runat="server" />
        <asp:TextBox ID="Number2" runat="server" />

        <asp:Button ID="Sum" runat="server" Text="Add" OnClick="Sum_Click" />

        <asp:Label ID="Result" runat="server" /><%= Sum %>
        
        <br />
        <asp:Hyperlink runat="server" NavigateUrl="~/Default.aspx" Text="Clear" Value="Home" />
    </div>
    </form>
</body>
</html>
