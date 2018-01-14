using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab__26
{
    public partial class Lab_27 : System.Web.UI.Page
    {

        int count = 2;

        protected void Page_Init(object sender, EventArgs e)
        {
            Label3.Text += "-Init-";
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text += "-Load-";
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            Label3.Text += "-Prerender-";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            Label3.Text += "-Unload-";
        }

        protected void Page_Disposed(object sender, EventArgs e)
        {
            Label3.Text += "-Disposed-";
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
           // Label_viewstate.Text = count + "!";
            count++;
            Textbox_viewstate.Text = "*" + Textbox_viewstate.Text + "*";
            String s = Request["__VIEWSTATE"];
            var t = ViewState["count"];
            ViewState["count"] = Textbox_viewstate.Text.Length;
            

            Label_viewstate.Text = "[" + s.Length + "]" + "[" + Textbox_viewstate.Text.Length + "]"+"    "+ ViewState["count"];
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Text += "-Click-";
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Label3.Text += "-Check-";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string response = String.Empty;

            response += $"<div class=\"jumbotron\"><br>Mashine name: { System.Environment.MachineName}" +
                        $"<br>OS Version: { System.Environment.OSVersion.VersionString}" +
                        $"<br>Working set: { System.Environment.WorkingSet}" +
                        $"<br>ASP.NET Version: {System.Environment.Version.ToString()}" +
                        $"<br>IP: { HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"]}" +
                        $"<br>Temp catalog: { Environment.GetEnvironmentVariable("TEMP")}" +
                        $"<br>Request: { (Request.IsLocal?"local":"not local")}" +
                        $"<br>Request: { (Request.IsSecureConnection?"is sequre connection":"is unsequre connection")}" +
                        $"<br>Browser: { Request.Browser.Version}" +
                        $"<br>Browser: {Request.Browser.MinorVersion}" +
                        $"<br>Browser: {Request.Browser.MajorVersion}" +
                        $"</div>";

            this.Response.Write(response);
        }
    }
}