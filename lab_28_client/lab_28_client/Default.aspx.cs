using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_28_client
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_GetRequest(object sender, EventArgs e) {
            HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create($"http://localhost/handlers/get.mos?ParmA={ParmA.Text}&ParmB={ParmB.Text}");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            StreamReader rdr = new StreamReader(response.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }

        protected void Button_PostRequest(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("http://localhost/handlers/post.mos");
            rq.Method = "POST";
            rq.MaximumResponseHeadersLength = 100;
            var postData = $"ParmA={ParmA.Text}&ParmB={ParmB.Text}";
            var data = Encoding.ASCII.GetBytes(postData);
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = data.Length;
            using (var stream = rq.GetRequestStream())
            {
               stream.Write(data, 0, data.Length);
            }
            var rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
            //        string script = @"<script>" +
            //    "function SendData()" +
            //       " {" +
            //            "var xhr = new XMLHttpRequest();" +
            //           " var a = document.getElementById(" + "TBA" + ").value;" +
            //            "var b = document.getElementById(" + "TBB" + ").value;" +
            //            "xhr.open(" + "POST" + ", " + "http://localhost:80/handlers/yyy.ndy" + ", true);" +
            //            "xhr.setRequestHeader(" + "Content-Type" + ", " + "application/x-www-form-urlencoded" + ");" +
            //            "var body = " + "a=" + " + encodeURIComponent(a) + " + "&b=" + " + encodeURIComponent(b);" +
            //            "xhr.send(body);" +
            //            "xhr.onreadystatechange = function() {" +
            //               " if (xhr.readyState == 4)" +
            //               " {" +
            //                    "if (xhr.status == 200)" +
            //                   " {" +
            //                       " document.getElementById(" + "TBR" + ").innerHTML = xhr.responseText;" +
            //                    "}" +
            //                "}" +
            //           " };" +
            //      "  }" +
            //"</ script > ";
            //        // Page.ClientScript.RegisterClientScriptBlock(this.GetType(),"SendD", script);
            //        // form1.Attributes.Add("onsubmit", "return SendData();");
            //        Response.Write(script);

        }

        protected void Button_PutRequest(object sender, EventArgs e)
        {
            var values = $"ParmA={ParmA.Text}&ParmB={ParmB.Text}";
            var bytes = Encoding.ASCII.GetBytes(values);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("http://localhost/handlers/put.mos"));
            request.Method = "PUT";
            request.ContentType = "application/x-www-form-urlencoded";
            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            StreamReader rdr = new StreamReader(response.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }

        protected void Button_PlusRequest(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("http://localhost/handlers/plus.mos");
            rq.Method = "POST";
            rq.MaximumResponseHeadersLength = 100;
            var postData = $"ParmA={ParmA.Text}&ParmB={ParmB.Text}";
            var data = Encoding.ASCII.GetBytes(postData);
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = data.Length;
            using (var stream = rq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("http://localhost/handlers/getForbidden.mos");
                rq.Method = "GET";
                var response = (HttpWebResponse)rq.GetResponse();
                StreamReader rdr = new StreamReader(response.GetResponseStream());
                Response.Write(rdr.ReadToEnd());

            }
            catch (WebException we) {
                Response.Write($"{we.Status}<br/>{we.Message}<br/>{we.TargetSite}<br/>{we.Source}");
            }
        }
    }
}