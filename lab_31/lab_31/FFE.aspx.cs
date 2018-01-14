using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_31
{
    public partial class FFE : System.Web.UI.Page
    {
       // private static int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            this.MultiView1.ActiveViewIndex = (this.MultiView1.ActiveViewIndex + 1) % 3;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            ((Label)((View)((Button)sender).Parent).Controls[1]).Text = ((TextBox)((View)((Button)sender).Parent).Controls[3]).Text;
        }

        protected void ButtonBanner_Click(object sender, EventArgs e) {

            ViewState["flag"] =ViewState["flag"] ==null? 0: (Int64.Parse(ViewState["flag"].ToString()) + 1) % 3;
            switch (Int64.Parse(ViewState["flag"].ToString()))
            {
                case 0: AdRotator1.KeywordFilter = "b2";
                    break;
                case 1:
                    AdRotator1.KeywordFilter = "";
                    break;
                case 2:
                    AdRotator1.KeywordFilter = "b1";
                    break;

            }
             
        }

            protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Result_Wizard.Text =$"Step 1:\n" +
                         $"textbox1: {TextBox4.Text}\n" +
                         $"textbox2: {TextBox5.Text}\n" +
                         $"textbox3: {TextBox6.Text}\n" +
                         $"Step 2:\n" +
                         $"RadioButtonList1: {RadioButtonList1.SelectedValue}\n" +
                         $"Step 3: \n" +
                         $"CheckBoxList1: {CheckBoxList1.SelectedValue}\n" +
                         $"Step 4:\n" +
                         $"ListBox1: {ListBox1.SelectedValue}\n" +
                         $"Step 5: \n" +
                         $"Calendar1: {Calendar1.SelectedDate.ToString()}";

        }

        protected void Wizard1_ActiveStepChanged1(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 5)
            {
                Result.Text = $"Step 1: <br/>" +
                              $"textbox1: {TextBox4.Text}<br/>" +
                              $"textbox2: {TextBox5.Text}<br/>" +
                              $"textbox3: {TextBox6.Text}<br/>" +
            $"Step 2:<br/>" +
            $"RadioButtonList1: {RadioButtonList1.SelectedValue}<br/>" +
            $"Step 3: <br/>" +
            $"CheckBoxList1: {CheckBoxList1.SelectedValue}<br/>" +
            $"Step 4:<br/>" +
            $"ListBox1: {ListBox1.SelectedValue}<br/>" +
            $"Step 5: <br/>" +
            $"Calendar1: {Calendar1.SelectedDate.ToString()}<br/>";
            }

        }

        protected void Wizard1_CancelButtonClick1(object sender, EventArgs e)
        {
            TextBox4.Text = String.Empty;
            TextBox5.Text = String.Empty;
            TextBox6.Text = String.Empty;

            RadioButtonList1.ClearSelection();
            CheckBoxList1.ClearSelection();
            ListBox1.ClearSelection();
            Calendar1.SelectedDate = DateTime.Now;

            Result_Wizard.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label4.Text = "";
            foreach (TreeNode item in TreeView1.CheckedNodes)
            {
                Label4.Text += item.Text+" ";
            }
            
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

            Menu mnu = (Menu)sender;
            Response.Write(mnu.SelectedItem.Text + " " + mnu.SelectedItem.Value);


        }
    }
    }