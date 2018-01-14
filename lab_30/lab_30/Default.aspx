<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab_30._Default" %>

<form id="form1" runat="server">

  
    <input id="TextBox22" runat="server" Width="178px" onchange="javascript:form1.submit();" onserverchange="Common_OnServerChange"/>
    <br/>
     <input id="Text1" type="password" runat="server" Width="178px" onchange="javascript:form1.submit();" onserverchange="Common_OnServerChange"/>    
    <br/>
    <textarea id="textarea1" runat="server" Width="178px" onchange="javascript:form1.submit();" onserverchange="Common_OnServerChange"></textarea>
    <br/>
    <input id="CheckBox" runat="server"  onchange="javascript:form1.submit();" onserverchange="Common_OnServerChange" type="checkbox" />
    <br/>

    <input runat="server"  name="g" onchange="javascript:form1.submit();" onserverchange="Common_OnServerChange"  type="radio"/>
    <input runat="server"  name="Radio1" onclick="javascript:form1.submit();"  onserverchange="Common_OnServerChange" type="radio"/> <br/>

    <input id ="reset" runat="server" onserverclick="Reset_OnServerClick" value="Reset" type="button" style="width: 178px" />
    <br/>
    <input id="button" runat="server" onserverclick="Button_OnServerClick" value="Button" type="button" style="width: 178px"/>
    <br/>
</form>
