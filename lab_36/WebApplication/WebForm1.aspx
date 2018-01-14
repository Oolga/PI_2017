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
        <div>
            <span>
                <asp:TextBox ID="TextBoxSetZ" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonSetZ" runat="server" Text="SetZ" OnClick="ButtonSetZ_Click" />
            </span>
            <br/>
             <span>
                <asp:TextBox ID="TextBoxGetZ" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonGetZ" runat="server" Text="GetZ" OnClick="ButtonGetZ_Click" />
            </span>
               <span>
                <asp:TextBox ID="TextBoxZ" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonAddZ" runat="server" Text="AddZ" OnClick="ButtonAddZ_Click" />
                <asp:Button ID="ButtonSubZ" runat="server" Text="SubZ" OnClick="ButtonSubZ_Click" />
                <asp:Button ID="ButtonMulZ" runat="server" Text="MulZ" OnClick="ButtonMulZ_Click" />
                <asp:TextBox ID="TextBoxResultZ" runat="server"></asp:TextBox>
            </span>
        </div>
        <br/>
        <div>
             <span>
                <asp:TextBox ID="TextBoxSetAppZ" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonSetAppZ" runat="server" Text="SetAppZ" OnClick="ButtonSetAppZ_Click" />
            </span>
            <br/>
             <span>
                <asp:TextBox ID="TextBoxGetAppZ" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonGetAppZ" runat="server" Text="GetAppZ" OnClick="ButtonGetAppZ_Click" />
            </span>
               <span>
                <asp:TextBox ID="TextBoxAppZ" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonAddAppZ" runat="server" Text="AddAppZ" OnClick="ButtonAddAppZ_Click" />
                <asp:TextBox ID="TextBoxResultAppZ" runat="server"></asp:TextBox>
            </span>
        </div>
    </form>
</body>
</html>

