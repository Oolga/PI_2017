<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_26.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>


    <form id="form1" runat="server">
        <div>
             <asp:Textbox runat="server" ID="Textbox1" value="Hello World!"/>
             <asp:Label runat="server" ID="Label1"></asp:Label>
             <asp:Button ID="Button1" runat="server" Text="Change" OnClick="Button1_Click" />  
        </div>
    </form>
</body>
</html>
