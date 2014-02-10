using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RushIsAwesome
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
			AreaRegistration.RegisterAllAreas();
			GlobalFilters.Filters.Add(new HandleErrorAttribute());

			RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			RouteTable.Routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });        
        }
    }
}