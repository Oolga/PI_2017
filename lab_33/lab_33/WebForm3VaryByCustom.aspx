<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3VaryByCustom.aspx.cs" Inherits="lab_33.WebForm3VaryByCustom" %>
<%@ OutputCache Duration="30" VaryByParam="None" VaryByCustom="browser"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="DateTime.Now"></asp:Label>
    </form>
</body>
</html>
