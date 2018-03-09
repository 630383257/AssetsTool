using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mvc.Route
{
    public interface IRouteProvider
    {
        IEnumerable<RouteDescriptor> GetRoutes();
    }
}
