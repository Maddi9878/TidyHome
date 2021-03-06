using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CMS.DocumentEngine;

using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Kentico.Web.Mvc;

namespace TidyHome_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Uncomment and optionally adjust the document query sample when using Page builder on the Home page
            // See ~/App_Start/ApplicationConfig.cs, ~/Views/Shared/_Layout.cshtml and ~/Views/Home/Index.cshtml
            // In the administration UI, create a Page type and set its
            //   URL pattern = '/Home'
            //   Use Page tab = True
            // In the administration UI, create a Page utilizing the new Page type

            //TreeNode page = DocumentHelper.GetDocuments().Path("/Home").OnCurrentSite().TopN(1).FirstOrDefault();
            //if (page == null)
            //{
            //    return HttpNotFound();
            //}

            //HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);
            var treeNode = DocumentHelper.GetDocuments().WhereEquals("NodeAliasPath", "/Home").OnCurrentSite().FirstOrDefault();
            HttpContext.Kentico().PageBuilder().Initialize(treeNode.DocumentID);
            return new TemplateResult(treeNode.DocumentID);
        }
    }
}