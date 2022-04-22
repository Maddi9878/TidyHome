using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TidyHome_MVC.Controllers.PageTemplate;

[assembly: RegisterPageTemplate("TidyHome_MVC.HomePageTemplateController", typeof(HomePageTemplateController), "Home Page Template", Description = "Home Template", IconClass = "icon-layout")]

namespace TidyHome_MVC.Controllers.PageTemplate
{
    public class HomePageTemplateController : PageTemplateController
    {
        // GET: HomePageTemplate
        public ActionResult Index()
        {
            try
            {
                return View("PageTemplate/_HomePage");

            }
            catch (Exception ex)
            {
                // EventLogProvider.LogException(ex.ToString(), ex.ToString(), ex);
                return null;
            }
        }
    }
}