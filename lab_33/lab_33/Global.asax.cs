using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace lab_33
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (custom.Equals("browser"))
            {
                string browserName;
                browserName = Context.Request.Browser.Browser;
                browserName += Context.Request.Browser.MajorVersion;
                return browserName;
            }
            else
            {
                return base.GetVaryByCustomString(context, custom);
            }
        }
    }
}