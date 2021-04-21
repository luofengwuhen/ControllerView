using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace WebApp4
{
    public class TemplateViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var template = context.Values["template"] ?? "Default";
            //, "/" + template + "/{0}.cshtml" , "/" + template + "/{1}/{0}.html"
            string[] locations = { "/" + template + "/{1}/{0}.cshtml", "/" + template + "/Shared/{0}.cshtml" };
            return locations.Union(viewLocations);
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values["template"] = context.ActionContext.RouteData.Values["Template"]?.ToString() ?? "PC";
        }
    }
}
