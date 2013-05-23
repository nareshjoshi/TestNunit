<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="TestNUnitWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblInput1" runat="server" Text="Input  1 "></asp:Label>
        <asp:TextBox ID="txtInput1" runat="server" style="margin-left: 27px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblInput2" runat="server" Text="Input  2 "></asp:Label>
        <asp:TextBox ID="txtInput2" runat="server" style="margin-left: 27px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="margin-left: 87px" Text="Add" Width="74px" />
        <br />
        <br />
        <br />
        Output :-&nbsp;&nbsp;
        <asp:Label ID="lblOutPut" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
