using System.Web.Routing;
using OnesAndTwos.Web.Controllers;
using OnesAndTwos.Web.NavigationRoutes;

namespace OnesAndTwos.Web.App_Start
{
    public class NavigationConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapNavigationRoute<HomeController>("Home", c => c.Index());
            routes.MapNavigationRoute<HomeController>("Contact", c => c.Contact());
            routes.MapNavigationRoute<HomeController>("About", c => c.About());
        }
    }
}