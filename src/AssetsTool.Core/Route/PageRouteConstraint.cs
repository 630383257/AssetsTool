using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace AssetsTool.Core.Route
{
    public class PageRouteConstraint : IRouteConstraint
    {
        List<string> _allowPages;
        public PageRouteConstraint(List<string> allowPages)
        {
            _allowPages = allowPages;
        }

        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var controller = values["controller"].ToString();
            var action = values["action"].ToString();
            return IsAllowVisit(controller, action);
        }

        bool IsAllowVisit(string controller, string action)
        {
            return _allowPages.Any(e => { return e == $"/{controller}/{action}"; });
        }
    }
}
