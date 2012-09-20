
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exercise_03.aspx.cs" Inherits="lesson1_exercise_03" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 3</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Calculator</h1>
        <div>
            <asp:TextBox ID="tbNumber1" runat="server" Width="125"></asp:TextBox><br />
            <asp:TextBox ID="tbNumber2" runat="server" Width="125"></asp:TextBox>
        </div>
        
        
        <div>
        <br />
        <asp:Button ID="btnAddition" runat="server" Text="+" onclick="btnAddition_Click" /> 
        <asp:Button ID="btnSubtraktion" runat="server" Text="-" onclick="btnSubtraction_Click" /> 
        <asp:Button ID="btnDivision" runat="server" Text="/" onclick="btnDivision_Click" /> 
        <asp:Button ID="btnMultiplikation" runat="server" Text="*" 
                onclick="btnMultiplication_Click" /> 
        </div>
         
        <div>
            <p style="font-weight:bold">
                Result: <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </p>
        </div>
       
    </div>
    </form>
</body>
</html>