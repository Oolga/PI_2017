<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="lab_29.BBB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
     <div>
        <asp:Label runat="server" ID="Label11">ФИО:</asp:Label>
        <asp:TextBox runat="server" ID="TextBox1" ValidationGroup="g1"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="Label1">Дата рождения:</asp:Label>
          <asp:TextBox runat="server" ID="TextBox6" ReadOnly="True" Visible="False"></asp:TextBox>
        <asp:TextBox runat="server" ID="TextBox2" ValidationGroup="g1"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="Label2">Email:</asp:Label>
        <asp:TextBox runat="server" ID="TextBox3" ValidationGroup="g1"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="Label3">Сумма:</asp:Label>
        <asp:TextBox runat="server" ID="TextBox4" ValidationGroup="g1"></asp:TextBox>
         
        <br/>
        <asp:Label runat="server" ID="Label4">Пароль:</asp:Label>
        <asp:TextBox runat="server" ID="TextBox5" ValidationGroup="g1" TextMode="Password"></asp:TextBox>
        <br/>
          <asp:Button ID="Button1" runat="server" Text="Button" />
         <br/>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"  ValidationGroup="g1">empty</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationGroup="g1"  ControlToValidate="TextBox1" ForeColor="#FF3300" ValidationExpression="^[А-ЯЁа-яё]+$">Use russian</asp:RegularExpressionValidator>
            <asp:RangeValidator ID="RangeValidator3" runat="server" ValidationGroup="g1"  ControlToValidate="TextBox4" Type="Integer" MinimumValue="1000" MaximumValue="2000" ForeColor="#FF3300">Uncorrected date range</asp:RangeValidator>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ValidationGroup="g1"  ControlToValidate="TextBox6" ErrorMessage="Date"  Operator="GreaterThanEqual"></asp:CompareValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Incorrect email</asp:RegularExpressionValidator>
         <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox5"  OnServerValidate="Check_Pass">Pass contains duplicate char or length less 7</asp:CustomValidator>  
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="g1"/>       
     </div>
      

    </form>
</body>
</html>
