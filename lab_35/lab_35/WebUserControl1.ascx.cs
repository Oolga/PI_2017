using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_35
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public String Lastname
        {
            get { return LastnameTB.Text; }
            set { LastnameTB.Text = value; }
        }
        public String Firstname
        {
            get { return FirstnameTB.Text; }
            set { FirstnameTB.Text = value; }
        }
        public String Middlename
        {
            get { return MiddlenameTB.Text; }
            set { MiddlenameTB.Text = value; }
        }
        public DateTime BirthDate
        {
            get { return Convert.ToDateTime(BirthDateTB.Text); }
            set { BirthDateTB.Text = value.ToLongDateString(); }
        }
        public String Sex
        {
            get { return SexRadioList.SelectedValue.ToString(); }
            set { SexRadioList.SelectedValue = value; }
        }
        public String Faculty
        {
            get { return FacultyList.SelectedValue.ToString(); }
            set { FacultyList.SelectedValue = value; }
        }
        public Int16 Group
        {
            get { return Int16.Parse(GroupTB.Text); }
            set { LastnameTB.Text = value.ToString(); }
        }
        public DateTime EnterDate
        {
            get { return Convert.ToDateTime(EnterDateTB.Text); }
            set { EnterDateTB.Text = value.ToLongDateString(); }
        }
        public String OKButton
        {
            get { return OkButton.Text; }
            set { OkButton.Text = value; }
        }
        public String CancelButton
        {
            get { return CLButton.Text; }
            set { CLButton.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void OkButton_Click(object sender, EventArgs e)
        {
            Response.Write("OK");
        }

        protected void CLButton_Click(object sender, EventArgs e)
        {
            FirstnameTB.Text = "";
            LastnameTB.Text = "";
            MiddlenameTB.Text = "";
            BirthDateTB.Text = "";
            SexRadioList.ClearSelection();
            FacultyList.ClearSelection();
            GroupTB.Text = "";
            EnterDateTB.Text = "";
        }
    }
}