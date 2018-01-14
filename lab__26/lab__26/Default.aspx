<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab__26._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>Lab-26</p>
        <asp:Label runat="server" ID="Label1"></asp:Label>
        <asp:Textbox runat="server" ID="Textbox1" value="Hello World!"/>
        <asp:Button ID="Button1" runat="server" Text="Change" OnClick="Button1_Click" />  
    </div>

</asp:Content>
