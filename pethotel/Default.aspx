<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" runat="server">
    <div >
        <h1>Pets Paradise Hotel</h1>
        <asp:Button ID="Button1" runat="server" Text="Show Pets" style="margin:4px; padding:0px;" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Show invoices" style="margin:4px; padding:0px;" TabIndex="1" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Show invoice specifik customer" style="margin:4px; padding:0px;" TabIndex="2" OnClick="Button3_Click" />
 
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
