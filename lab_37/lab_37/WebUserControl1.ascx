<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="lab_37.WebUserControl1" %>
<%@ implements interface="System.Web.UI.ICallbackEventHandler" %>


<script type="text/javascript">
    function SendData() {
        debugger;
        var firstname = document.getElementById("MainContent_WebUserControl11_FirstnameTB");
        var lastname = document.getElementById("MainContent_WebUserControl11_LastnameTB");
        var middlename = document.getElementById("MainContent_WebUserControl11_MiddlenameTB");
        var birthDate = document.getElementById("MainContent_WebUserControl11_BirthDateTB");
        var faculty = document.getElementById("MainContent_WebUserControl11_FacultyList");
        var group = document.getElementById("MainContent_WebUserControl11_GroupTB");
        var enterDate = document.getElementById("MainContent_WebUserControl11_EnterDateTB");
        var sexM = document.getElementById("MainContent_WebUserControl11_SexRadioList_0");
        var sexW = document.getElementById("MainContent_WebUserControl11_SexRadioList_1");
        var sex = sexM.checked ? 'М' : 'Ж';
        CallServer(firstname.value + "," + lastname.value + "," + middlename.value + "," +
            birthDate.value + "," + faculty.value + "," + sex + "," + group.value + "," + enterDate.value);
    }
    function ReceiveServerData(arg, context) {
        debugger;
        var dc = document.getElementById("message");
        dc.innerText = arg;
    }
</script>

<p id="message"></p>
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
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="GroupTB" ErrorMessage="Group must to be 1-100" MaximumValue="100" MinimumValue="1" Display="None" Type="Integer"></asp:RangeValidator>
<br />
<p>Enter date: </p>
<asp:TextBox ID="EnterDateTB" runat="server"></asp:TextBox>
<br />
<asp:Button ID="OkButton" runat="server" Text="OK" OnClientClick="SendData(); return false;" OnClick="OkButton_Click"/>
&nbsp;&nbsp;&nbsp;
<asp:Button ID="CLButton" runat="server" Text="Cancel" OnClick="CLButton_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />