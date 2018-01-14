<%@ Page Language="C#" MasterPageFile="~/Site.Master" EnableViewState="true"  AutoEventWireup="true" CodeBehind="Lab_27.aspx.cs" Inherits="lab__26.Lab_27" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>Lab-27</p>
        <asp:Label runat="server" ID="Label_viewstate"></asp:Label>
        <asp:Textbox runat="server" ID="Textbox_viewstate" value="Hello World!"/>
        <asp:Button ID="Button2_viewstate" runat="server" Text="Change" OnClick="Button2_Click" />  
    </div>

    <div class="jumbotron">
        <p>Lab-27</p>
        <asp:Label runat="server" ID="Label3"></asp:Label>
        <asp:Textbox runat="server" ID="Textbox3" value="Hello World!"/>
        <asp:Button ID="Button3" runat="server" Text="Change" OnClick="Button3_Click" />  
        <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="true" EnableViewState="false" OnCheckedChanged="CheckBox3_CheckedChanged"/>
        <asp:CheckBox ID="CheckBox4" runat="server" AutoPostBack="false" OnCheckedChanged="CheckBox3_CheckedChanged"/>
    </div>


        <div class="jumbotron">
        <p>Get system's parameters</p>

        <asp:Button ID="Button4" runat="server" Text="Get" OnClick="Button4_Click" />  

    </div>

</asp:Content>

