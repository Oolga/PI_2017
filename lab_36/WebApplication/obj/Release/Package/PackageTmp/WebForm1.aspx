<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>
                <asp:Label ID="LabelX" runat="server">X</asp:Label>
                <asp:TextBox ID="TextBoxX" runat="server"></asp:TextBox>
            </span>
            <br/>
            <span>
                <asp:Label ID="LabelY" runat="server">Y</asp:Label>
                <asp:TextBox ID="TextBoxY" runat="server"></asp:TextBox>
            </span>
            <br/>
            <span>
                <asp:Button ID="ButtonSum" runat="server" Text="+" OnClick="ButtonSum_Click" />
                <asp:Button ID="ButtonSub" runat="server" Text="-" OnClick="ButtonSub_Click" />
                <asp:Button ID="ButtonMul" runat="server" Text="*" OnClick="ButtonMul_Click" />

                 <asp:Label ID="LabelRes" runat="server">Result: </asp:Label>
                <asp:TextBox ID="TextBoxRes" runat="server"></asp:TextBox>
                
            </span>

           
        </div>
    </form>
</body>
</html>

