<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3Profile.aspx.cs" Inherits="lab_33.WebForm3Profile" %>

<%@ OutputCache CacheProfile="Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:Label ID="Label1" runat="server" Text="DateTime.Now"></asp:Label>
        <asp:Substitution runat="server" ID="Substitution1" MethodName="Get_Date"/>
    </form>
</body>
</html>
