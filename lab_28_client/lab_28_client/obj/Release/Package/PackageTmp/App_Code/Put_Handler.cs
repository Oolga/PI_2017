using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_28.App_Code
{
    public class Put_Handler : IHttpHandler
    {
        public bool IsReusable { get { return false; } }

        public void ProcessRequest(HttpContext context)
        {

            HttpRequest request = context.Request;

            string parmA = request.Params.Get("ParmA");
            string parmB = request.Params.Get("ParmB");

            HttpResponse response = context.Response;
            response.Write($"Put-Http-mos: ParmA={parmA}, parmB={parmB}");
        }
    }
}