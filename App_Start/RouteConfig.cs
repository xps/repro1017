using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Repro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            foreach (var r in routes.OfType<Route>())
                r.Url = "{lang}/" + r.Url;
        }
    }
}
