<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="lab_29.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>RequiredFiledValidator</p>
            <br/>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="g1" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" ForeColor="#FF3300">TextBox is empty</asp:RequiredFieldValidator>
            <br/>
            <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="g1">
             </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="g1" ControlToValidate="DropDownList1" ForeColor="#FF3300">DropDownList is empty</asp:RequiredFieldValidator>
            <br/>
            <asp:Button runat="server" ID="Button1"></asp:Button>
        </div>  
        <br/>
        <div>
            <p>RangeValidator</p>
            <br/>
             <asp:TextBox runat="server" ID="TextBox3" ValidationGroup="g2"></asp:TextBox>
             <asp:RangeValidator ID="RangeValidator1" ValidationGroup="g2" runat="server" ErrorMessage="RangeValidator" ControlToValidate="TextBox3" Type="Integer" MinimumValue="100" MaximumValue="200" ForeColor="#FF3300">Uncorrected integer range</asp:RangeValidator>
            <br/>
             <asp:TextBox runat="server" ID="TextBox4" ValidationGroup="g2"></asp:TextBox>
             <asp:RangeValidator ID="RangeValidator2" runat="server" ValidationGroup="g2" ErrorMessage="RangeValidator" ControlToValidate="TextBox4" Type="Date" MinimumValue="01.01.2011" MaximumValue="31.12.2011" ForeColor="#FF3300">Uncorrected date range</asp:RangeValidator>
        </div>

           <br/>
        <div>
            <p>CompareValidator</p>
            <br/>
            <asp:TextBox runat="server" ID="TextBox5" ValidationGroup="g3"></asp:TextBox>
            <asp:TextBox runat="server" ID="TextBox6" ValidationGroup="g3"></asp:TextBox>
             <asp:Button ID="Button3" runat="server" Text="Button" ValidationGroup="g3" />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox5" ErrorMessage="CompareValidator" ValidationGroup="g3" ForeColor="Red" Operator="LessThan" Type="Date"></asp:CompareValidator>
        </div>
        <br/>
        <div>
            <p>RegularExpressionValidator</p>
            <br/>
            <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="g4"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Button" ValidationGroup="g4" />
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Check Email" ValidationGroup="g4" ControlToValidate="TextBox7" ForeColor="Red" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
        </div>
            <br/>
        <div>
            <p>CustomValidator</p>
            <br/>
            <asp:TextBox ID="TextBox8" runat="server" ValidationGroup="g5"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="Button" ValidationGroup="g5" />
            <br />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox8" ErrorMessage="Not simple" ForeColor="Red" ValidationGroup="g5" OnServerValidate="Error_Handler" ClientValidationFunction="JsErrorHandler"></asp:CustomValidator>
        </div>
       
    </form>

        <script type="text/javascript">
        function JsErrorHandler(c, a) {
            debugger
            var isSimple = true;
            for (var i = 2; i <= a.Value / 2; i++) {
                debugger
                if (a.Value % i == 0) {
                    debugger
                    isSimple = false;
                    break;
                }
            }
            a.IsValid = (isSimple) ? true : false;
        }
    </script>
</body>
</html>
