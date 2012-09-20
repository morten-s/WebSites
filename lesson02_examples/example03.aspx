<%@ Page Language="C#" AutoEventWireup="true" CodeFile="example03.aspx.cs" Inherits="example03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example 3</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Literal ID="ltrProduct1" runat="server"></asp:Literal>
        <br />
        <br />
        <asp:Literal ID="ltrProduct2" runat="server"></asp:Literal>
        <br />
        <br />
        <asp:Literal ID="ltrProduct3" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="ltrPerson1" runat="server"></asp:Literal>
        <br />
    
        <asp:Button ID="BtnShowAll" runat="server" onclick="BtnShowAll_Click" 
            Text="Show all" />
    
    </div>
    </form>
</body>
</html>
