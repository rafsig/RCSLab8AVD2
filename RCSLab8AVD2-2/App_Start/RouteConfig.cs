using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using System.Web.Compilation;
using System.Web.UI;
using RCSLab8AVD2_2.ssrs;

namespace RCSLab8AVD2_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Add("ReportRoute",
                   new Route("reports/{rn}", new ReportRouteHander()));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

    internal class ReportRouteHander : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            Dictionary<string, string> Reports = new Dictionary<string, string>();
            Reports.Add("contactlist", "/Fall 2018/Rafael Sigwalt/ContactList");
            Reports.Add("salespercity", "/Fall 2018/Rafael Sigwalt/salespercity");


            string rn = requestContext.RouteData.Values["rn"] as string;

            ReportsWebForm rvwf = BuildManager.CreateInstanceFromVirtualPath("~/ssrs/ReportsWebForm.aspx",
                                                                typeof(Page))
                                                                as ReportsWebForm;

            rvwf.ReportServerURL = "http://142.55.32.96/reportserver";
            rvwf.ReportPath = Reports[rn.ToLower()];
            return rvwf;

        }
    }
}
