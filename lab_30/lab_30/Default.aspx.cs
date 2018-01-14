using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace lab_30
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
         {
            if (!Page.IsPostBack)
            {
                ViewState.Add("rows", new List<List<string>>());
            }
            HtmlTable table = new HtmlTable();
            table.ID = "Table1";
            table.Border = 1;
            table.CellPadding = 3;
            table.CellSpacing = 3;
            table.Align = "center";
            table.BorderColor = "red";

            HtmlTableRow rows;
            HtmlTableCell cells;
            rows = new HtmlTableRow();
            cells = new HtmlTableCell(); cells.InnerHtml = "Html Control"; rows.Cells.Add(cells);
            cells = new HtmlTableCell(); cells.InnerHtml = "onserverclick"; rows.Cells.Add(cells);
            cells = new HtmlTableCell(); cells.InnerHtml = "onserverchange"; rows.Cells.Add(cells);

            table.Rows.Add(rows);
            
           
            this.Controls.Add(table);
        }

        protected void Page_Prerender(object sender, EventArgs e) {
            var t = (List<List<string>>)ViewState["rows"];
            if (t != null)
            {

                foreach (List<string> item in t)
                {
                    HtmlTableRow rows;
                    HtmlTableCell cells;

                    rows = new HtmlTableRow();
                    cells = new HtmlTableCell(); cells.InnerHtml = item[0]; rows.Cells.Add(cells);
                    cells = new HtmlTableCell(); cells.InnerHtml = item[1]; rows.Cells.Add(cells);
                    cells = new HtmlTableCell(); cells.InnerHtml = item[2]; rows.Cells.Add(cells);

                    ((HtmlTable)FindControl("Table1")).Rows.Add(rows);
                }

              
            }
           
        }


        private void WriteRow(string methodname, string onclick, string onchange) {
            List<string> str = new List<string>();
            str.Add(methodname);
            str.Add(onclick);
            str.Add(onchange);
            ((List<List<string>>)ViewState["rows"]).Add(str);
        }

        protected void Reset_OnServerClick(object sender, System.EventArgs args) {
           
            ViewState["rows"]=new List<List<string>>();
        }

        protected void Button_OnServerClick(object sender, System.EventArgs args)
        {

            WriteRow("Button_OnServerClick", "yes", "no");
        }

        protected void Common_OnServerChange(object sender, System.EventArgs args) {

            if ((new HtmlInputText()).GetType().Equals(sender.GetType()))
            {
                WriteRow("HtmlInputText", "no", "yes");
            }
            else if ((new HtmlInputPassword()).GetType().Equals(sender.GetType()))
            {
                WriteRow("HtmlInputPassword", "no", "yes");
            }
            else if ((new HtmlInputRadioButton()).GetType().Equals(sender.GetType()))
            {
                WriteRow("HtmlInputRadioButton", "no", "yes");
            }
            else if ((new HtmlSelect()).GetType().Equals(sender.GetType()))
            {
                WriteRow("HtmlSelect", "no", "yes");
            }
            else if ((new HtmlTextArea()).GetType().Equals(sender.GetType()))
            {
                WriteRow("HtmlTextArea", "no", "yes");
            }
            else if ((new HtmlInputCheckBox()).GetType().Equals(sender.GetType()))
            {
                WriteRow("HtmlInputCheckBox", "no", "yes");

            }

        }
    }
}