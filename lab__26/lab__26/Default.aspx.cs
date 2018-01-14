using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace lab__26
{

    public interface AA
    {
        int a { get; set; }
        int b();
    }

    public class BB : AA
    {

        public int a { get ; set; }

        public int b()
        {

            return a*2;
        }
    }


    public partial class _Default : Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Label1.Text = Textbox1.Text;
          
        }


    }
}