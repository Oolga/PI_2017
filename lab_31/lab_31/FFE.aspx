<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FFE.aspx.cs" Inherits="lab_31.FFE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server">

                <asp:View ID="View1" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="View1"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 26px" Width="222px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" style="margin-left: 50px" Text="Click"  OnClick="Button_Click" />
                    <br/>
                    <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="5" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="253px" Width="607px"  DisplayCancelButton="true" OnActiveStepChanged="Wizard1_ActiveStepChanged1" OnCancelButtonClick="Wizard1_CancelButtonClick1" OnFinishButtonClick="Wizard1_FinishButtonClick">
                        <FinishNavigationTemplate>
                            <asp:Button ID="FinishPreviousButton" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="MovePrevious" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Text="Предыдущ." />
                            <asp:Button ID="FinishButton" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CommandName="MoveComplete" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Text="Готово" />
                        </FinishNavigationTemplate>
                        <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                        <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                        <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" />
                        <SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" />
                        <StepStyle Font-Size="0.8em" ForeColor="#333333" />
                        <WizardSteps>
                            <asp:WizardStep runat="server" title="Step 1">
                                <asp:Table ID="Table1" runat="server" Height="92px" Width="130px">
                                    <asp:TableRow runat="server">
                                        <asp:TableCell runat="server">
                                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow runat="server">
                                        <asp:TableCell runat="server">
                                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow runat="server">
                                        <asp:TableCell runat="server">
                                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>

                            </asp:WizardStep>
                            <asp:WizardStep runat="server" title="Step 2">
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem>Rad1</asp:ListItem>
                                    <asp:ListItem>Rad2</asp:ListItem>
                                    <asp:ListItem>Rad3</asp:ListItem>
                                </asp:RadioButtonList>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" title="Step 3">
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                    <asp:ListItem>Chk1</asp:ListItem>
                                    <asp:ListItem>Chk2</asp:ListItem>
                                    <asp:ListItem>Chk3</asp:ListItem>
                                </asp:CheckBoxList>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" title="Step 4">
                                <asp:ListBox ID="ListBox1" runat="server">
                                    <asp:ListItem>1111</asp:ListItem>
                                    <asp:ListItem>2222</asp:ListItem>
                                    <asp:ListItem>3333</asp:ListItem>
                                </asp:ListBox>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" title="Step 5">
                                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                            </asp:WizardStep>
                             <asp:WizardStep runat="server" title="Step 6">
                                <asp:Label runat="server" ID="Result"></asp:Label>
                            </asp:WizardStep>
                        </WizardSteps>
                    </asp:Wizard>
                    <asp:Label ID="Result_Wizard" runat="server"></asp:Label>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Label ID="Label2" runat="server" Text="View2"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 26px" Width="222px"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" style="margin-left: 50px" Text="Click"  OnClick="Button_Click" />
                    <br/>
                    <asp:TreeView ID="TreeView1" runat="server" Width="550px"  Font-Names= "Arial"
                ForeColor="Blue"
                SelectedNodeStyle-ForeColor="Green"
                SelectedNodeStyle-VerticalPadding="0">
                        <Nodes>
                            <asp:TreeNode Text="1" Value="Новый узел">
                                <asp:TreeNode ShowCheckBox="True" Text="1.1" Value="Новый узел">
                                    <asp:TreeNode Text="1.1.1" Value="Новый узел">
                                        <asp:TreeNode Text="1.1.1.1" Value="Новый узел"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="1.1.2" Value="Новый узел">
                                        <asp:TreeNode Text="1.1.2.1" Value="Новый узел"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="1.1.3" Value="Новый узел">
                                        <asp:TreeNode Text="1.1.3.1" Value="Новый узел"></asp:TreeNode>
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="1.2" ToolTip="4687643" Value="Новый узел" ShowCheckBox="True"></asp:TreeNode>
                                <asp:TreeNode ImageUrl="~/Image/stop.png" Text="1.3" Value="Новый узел" ShowCheckBox="True"></asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                      <asp:Label ID="Label4" runat="server" Text="View2"></asp:Label>
                     <asp:Button ID="Button6" runat="server" style="margin-left: 50px" Text="Click"  OnClick="Button6_Click"/>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Label ID="Label3" runat="server" Text="View3"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 26px" Width="222px"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" style="margin-left: 50px" Text="Click"  OnClick="Button_Click"/>
                    <br/>
                    <asp:Menu ID="Menu1" runat="server" onmenuitemclick="Menu1_MenuItemClick" >
                        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
	<DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
	<DynamicMenuStyle BackColor="#B5C7DE" />
	<DynamicSelectedStyle BackColor="#507CD1" />
	<StaticHoverStyle BackColor="#284E98" ForeColor="White" />
	<StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
	<StaticSelectedStyle BackColor="#507CD1" />
                        <Items>
                            <asp:MenuItem Text="1" Value="1">
                                <asp:MenuItem Text="1.1" ToolTip="456" Value="1.1">
                                    <asp:MenuItem Text="1.1.1" Value="1.1.1"></asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="1.2" Value="1.2"></asp:MenuItem>
                                <asp:MenuItem Text="1.3" Value="1.3"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="2" Value="2"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </asp:View>
            </asp:MultiView>
        </div>
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Next" Width="66px" />
        <br/>
        <div> 
            <asp:AdRotator ID="AdRotator1" runat="server"  AdvertisementFile="~/App_Data/AdRotaror.xml"/>
            <asp:Button ID="Button5" runat="server" OnClick="ButtonBanner_Click" Text="Filter" />
        </div>
    </form>
</body>
</html>
