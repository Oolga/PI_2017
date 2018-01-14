<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab_28_client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
         <asp:HiddenField ID="HiddenFileldVariable" runat="server" />
        <asp:Label ID="result" runat="server" ></asp:Label>
        <p>ParmA:</p><asp:TextBox runat="server" ID="ParmA"/>
        <p>ParmB:</p><asp:TextBox runat="server" ID="ParmB"/>
        <asp:Button runat="server" ID="Get" Text="Get" OnClick="Button_GetRequest"></asp:Button>
        <asp:Button runat="server" ID="Post" Text="Post" OnClick="Button_PostRequest"></asp:Button>
        <asp:Button runat="server" ID="Put" Text="Put" OnClick="Button_PutRequest"></asp:Button>
        <asp:Button runat="server" ID="Plus" Text="Plus"  OnClientClick="Plus(); return false;"></asp:Button>
        <asp:Button runat="server" ID="Button1" Text="403" OnClick="Button1_Click"></asp:Button>
    </div>

    <script>
        function Plus() {
            var xhr = new XMLHttpRequest();

            xhr.open('POST', "http://localhost/handlers/plus.mos", true);
            var data = "ParmA=" + document.getElementById("MainContent_ParmA").value + "&ParmB=" + document.getElementById("MainContent_ParmB").value;
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded')
            xhr.send(data); 

            xhr.onreadystatechange = function () { 
                if (xhr.readyState != 4) return;

                debugger;

                if (xhr.status == 200) {
                    document.getElementById("MainContent_result").innerHTML = xhr.responseText;
                }

            }
        }
</script>
</asp:Content>
