using CMS.DocumentEngine;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Kentico.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TidyHome_MVC.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index(string nodeAliasPath)
        {
            try
            {
                var nodeAlias = String.Concat("/", nodeAliasPath);
                var treeNode = DocumentHelper.GetDocuments().WhereEquals("NodeAliasPath", nodeAlias).FirstOrDefault();
                HttpContext.Kentico().PageBuilder().Initialize(treeNode.DocumentID);
                return new TemplateResult(treeNode.DocumentID);
            }
            catch (Exception ex)
            {
                //LogHelper.LogException(nameof(PageController), nameof(Index), ex);
                return null;
            }

        }
    }
}