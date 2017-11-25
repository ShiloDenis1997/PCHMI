using MinskForYou.Api.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MinskForYou.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
		private DiConfig _diConfig; 

		protected void Application_Start()
        {
			_diConfig = new DiConfig();
			_diConfig.Configure(GlobalConfiguration.Configuration);

			AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters
                .XmlFormatter);
        }

		protected void Application_End() {
			_diConfig.Dispose();
		}
	}
}
