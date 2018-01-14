using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_28_client.App_Code
{
    public class Post_PlusHandler: IHttpHandler
    {
        public bool IsReusable { get { return false; } }

        public void ProcessRequest(HttpContext context)
        {

            HttpRequest request = context.Request;

            string parmA = request.Params.Get("ParmA");
            string parmB = request.Params.Get("ParmB");

            long pA, pB;
            Int64.TryParse(parmA, out pA);
            Int64.TryParse(parmB, out pB);

            HttpResponse response = context.Response;
            response.Write($"Post-Plus-Http-mos: ParmA + ParmB={pA+pB}");
        }
    }
}