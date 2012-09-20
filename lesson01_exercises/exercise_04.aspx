<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exercise_04.aspx.cs" Inherits="exercise_04" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hours<br />
        <asp:TextBox ID="tbHours" runat="server"></asp:TextBox><br /> <br />
    </div>
    <div>
        Minutes<br />
        <asp:TextBox ID="tbMinutes" runat="server"></asp:TextBox><br /> <br />
    </div>
    <div>
        <asp:Button ID="btCalculate" runat="server" Text="Calculate" 
            onclick="btCalculate_Click" /><br /> <br />
    </div>

    <div>
    <strong>Total minutes: 
        <asp:Label ID="lblTotalMinues" runat="server" Text=""></asp:Label></strong>
    </div>

    </form>
</body>
</html>
