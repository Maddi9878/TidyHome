using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CMS.DocumentEngine;
using Kentico.Web.Mvc;

namespace TidyHome_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Maps routes to Kentico HTTP handlers and features enabled in ApplicationConfig.cs
            // Always map the Kentico routes before adding other routes. Issues may occur if Kentico URLs are matched by a general route, for example images might not be displayed on pages
            routes.Kentico().MapRoutes();
            routes.MapRoute(
               name: "Page",
               url: "{*nodeAliasPath}",
               defaults: new { controller = "Page", action = "Index" },
               constraints: new { nodeAliasPath = new CmsUrlConstraint() }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        public class CmsUrlConstraint : IRouteConstraint
        {
            public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
            {
                List<string> excludePaths = new List<string>()
        {
            "/Home"
        };
                var db = DocumentHelper.GetDocuments().Column("NodeAliasPath").WhereNotIn("NodeAliasPath", excludePaths).OnCurrentSite().ToList();
                if (values[parameterName] != null)
                {
                    var permalink = string.Concat("/", values[parameterName].ToString());
                    return db.Any(p => p.NodeAliasPath.ToLower() == permalink.ToLower());
                }
                return false;
            }
        }
    }
}
