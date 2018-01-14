using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_34
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Label2.Text = Label3.Text = Label4.Text =Label6.Text= Label7.Text = DateTime.Now.ToLongTimeString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Label1.Text = DateTime.Now.ToLongTimeString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           // Label2.Text  = DateTime.Now.ToLongTimeString();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           // Label3.Text =  DateTime.Now.ToLongTimeString();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // Label4.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            throw new ApplicationException("Какая-то ошибка");
        }

        protected void cmdRefreshTime_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(15000);
            Label8.Text = DateTime.Now.ToLongTimeString();
        }
    }
}