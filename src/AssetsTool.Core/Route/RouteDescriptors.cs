using System;
using System.Collections.Generic;
using System.Text;
using Base.Mvc.Route;
namespace AssetsTool.Core.Route
{
    public class RouteDescriptors
    {
        public static List<RouteDescriptor> routes => new List<RouteDescriptor>
        {
             new RouteDescriptor
             {
                RouteName = "year",
                Template = "{controller}/{action}/{year:int}",
                Defaults = new { controller = "Assets", action = "Year" ,year= DateTime.Now.Year },
                Constraints=new { year=new PageRouteConstraint(new List<string>{ "/Assets/Year"})},
                Priority = 10
             },
             new RouteDescriptor
             {
                RouteName = "year",
                Template = "{controller}/{action}/{month:int}",
                Defaults = new { controller = "Assets", action = "Year" ,month= DateTime.Now.Month },
                Constraints=new { month=new PageRouteConstraint(new List<string>{ "/Assets/Month"})},
                Priority = 10
             }
        };
    }
}
