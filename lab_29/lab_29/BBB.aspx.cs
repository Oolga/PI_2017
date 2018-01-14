using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_29
{
    public partial class BBB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           TextBox6.Text= DateTime.Now.Date.ToString();
        }

        protected void Check_Pass(object sender, ServerValidateEventArgs args)
        {
            string testString = args.Value.ToString();
         
            if (testString.Length < 7)
            {
                args.IsValid = false;
            }
            else
            {
                
                args.IsValid = testString.ToList().Distinct().Count() !=testString.Count() ? false : true;
            }
        }
    }
}