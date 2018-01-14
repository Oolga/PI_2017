using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient client;
        protected void Page_Init(object sender, EventArgs e)
        {
            client = new ServiceReference1.WebService1SoapClient();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSum_Click(object sender, EventArgs e)
        {
                TextBoxRes.Text = client.Sum(Int32.Parse(TextBoxX.Text), Int32.Parse(TextBoxY.Text)).ToString();
        }

        protected void ButtonSub_Click(object sender, EventArgs e)
        {
            TextBoxRes.Text = client.Sub(Int32.Parse(TextBoxX.Text), Int32.Parse(TextBoxY.Text)).ToString();
        }

        protected void ButtonMul_Click(object sender, EventArgs e)
        {
            TextBoxRes.Text = client.Mul(Int32.Parse(TextBoxX.Text), Int32.Parse(TextBoxY.Text)).ToString();
        }


        protected void ButtonSetZ_Click(object sender, EventArgs e)
        {
            client.SetZ(Int32.Parse(TextBoxSetZ.Text));
        }

        protected void ButtonGetZ_Click(object sender, EventArgs e)
        {
            TextBoxGetZ.Text = client.GetZ().ToString();
        }

        protected void ButtonAddZ_Click(object sender, EventArgs e)
        {
            TextBoxResultZ.Text = client.AddZ(Int32.Parse(TextBoxZ.Text)).ToString();
        }

        protected void ButtonSubZ_Click(object sender, EventArgs e)
        {
            TextBoxResultZ.Text = client.SubZ(Int32.Parse(TextBoxZ.Text)).ToString();
        }

        protected void ButtonMulZ_Click(object sender, EventArgs e)
        {
            TextBoxResultZ.Text = client.MulZ(Int32.Parse(TextBoxZ.Text)).ToString();
        }

        protected void ButtonSetAppZ_Click(object sender, EventArgs e)
        {
            client.SetAppZ(Int32.Parse(TextBoxSetAppZ.Text));
        }

        protected void ButtonGetAppZ_Click(object sender, EventArgs e)
        {
            TextBoxGetAppZ.Text = client.GetAppZ().ToString();
        }

        protected void ButtonAddAppZ_Click(object sender, EventArgs e)
        {
            TextBoxResultAppZ.Text = client.AddAppZ(Int32.Parse(TextBoxAppZ.Text)).ToString();
        }
    }
}