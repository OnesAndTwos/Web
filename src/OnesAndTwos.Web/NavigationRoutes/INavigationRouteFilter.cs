using System.Web.Routing;

namespace OnesAndTwos.Web.NavigationRoutes
{
    public interface INavigationRouteFilter
    {
        bool ShouldRemove(Route navigationRoutes);
    }
}
