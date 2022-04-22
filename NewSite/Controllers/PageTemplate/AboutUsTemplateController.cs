using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TidyHome_MVC.Controllers.PageTemplate;

[assembly: RegisterPageTemplate("TidyHome_MVC.AboutUsTemplateController", typeof(AboutUsTemplateController), "AboutUs Page Template", Description = "AboutUs Template", IconClass = "icon-layout")]

namespace TidyHome_MVC.Controllers.PageTemplate
{
    public class AboutUsTemplateController : PageTemplateController
    {
        // GET: AboutUsTemplate
        public ActionResult Index()
        {
            try
            {
                return View("PageTemplate/_AboutUsPage");

            }
            catch (Exception ex)
            {
                // EventLogProvider.LogException(ex.ToString(), ex.ToString(), ex);
                return null;
            }
        }
    }
}