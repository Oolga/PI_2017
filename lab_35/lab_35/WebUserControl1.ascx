<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="lab_35.WebUserControl1" %>
<p>Firstname: </p>
<asp:TextBox ID="FirstnameTB" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="LastnameTB" Display="None" ErrorMessage="Enter the lastname"></asp:RequiredFieldValidator>
<br />
<p>Lastname: </p>
<asp:TextBox ID="LastnameTB" runat="server"></asp:TextBox>
<br />
<p>Middlename: </p>
<asp:TextBox ID="MiddlenameTB" runat="server"></asp:TextBox>
<br />
<p>Birthday: </p>
<asp:TextBox ID="BirthDateTB" runat="server"></asp:TextBox>

<asp:RadioButtonList ID="SexRadioList" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem>М</asp:ListItem>
    <asp:ListItem>Ж</asp:ListItem>
</asp:RadioButtonList>


<asp:DropDownList ID="FacultyList" runat="server">
    <asp:ListItem>FIT</asp:ListItem>
    <asp:ListItem>PIM</asp:ListItem>
    <asp:ListItem>TOV</asp:ListItem>
</asp:DropDownList>
<br />
<p>Group: </p>
<asp:TextBox ID="GroupTB" runat="server"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="GroupTB" ErrorMessage="Group 1-100" MaximumValue="100" MinimumValue="1" Display="None" Type="Integer"></asp:RangeValidator>
<br />
<p>Enter date: </p>
<asp:TextBox ID="EnterDateTB" runat="server"></asp:TextBox>
<br />
<asp:Button ID="OkButton" runat="server" Text="OK" OnClick="OkButton_Click" />
&nbsp;&nbsp;&nbsp;
<asp:Button ID="CLButton" runat="server" Text="Cancel" OnClick="CLButton_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />