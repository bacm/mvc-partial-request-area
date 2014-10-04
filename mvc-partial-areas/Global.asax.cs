using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace mvc_partial_areas
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (custom.Equals("partial"))
            {
                // delegate using some pattern
                if (context.Session["id"] == null)
                {
                    context.Session["id"] = Guid.NewGuid();
                }

                // might use other custom string based on area to render, like action parameters

                var id = context.Session["id"];
                return "Partial=" + id;
            }

            return base.GetVaryByCustomString(context, custom);
        }
    }
}
