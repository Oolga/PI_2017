﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_37
{
    public partial class WebUserControl1 : System.Web.UI.UserControl, ICallbackEventHandler
    {
        private bool valid;
        ClientScriptManager client;

        public String Lastname
        {
            get; set;
        }
        public String Firstname
        {
            get; set;
        }
        public String Middlename
        {
            get; set;
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
            get; set;
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
            client = Page.ClientScript;
            String cbReference = client.GetCallbackEventReference(this, "arg", "ReceiveServerData", "");
            String callbackScript = "function CallServer (arg) {" + cbReference + "; }";
            client.RegisterClientScriptBlock(GetType(), "CallServer", callbackScript, true);
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

        public void RaiseCallbackEvent(string eventArgument)
        {
            String[] argsFromClient = eventArgument.Split(',');
            valid = true;
            if (argsFromClient.Length == 8)
            {
                foreach (string str in argsFromClient)
                {
                    if (str == "undefined" || str == "")
                    {
                        valid = false;
                        break;
                    }
                }
            }
            else
            {
                valid = false;
            }
        }

        public string GetCallbackResult()
        {
            return valid ? "OK" : "Check the fields";
        }
    }
}