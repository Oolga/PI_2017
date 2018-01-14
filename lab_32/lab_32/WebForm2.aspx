<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="lab_32.WebForm2" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="lalala"/>
             <asp:Button ID="Button2" runat="server" Text="lalala" EnableTheming="false"/>
            <asp:TextBox ID="Text1" runat="server">safsdfdsf</asp:TextBox>
            <asp:Label ID="LAbel1" runat="server" SkinID="Label1">wdasf</asp:Label>
            <asp:Label ID="LAbel2" runat="server" SkinID="Label2">wdasf</asp:Label>
        </div>
    </form>
</body>
</html>
