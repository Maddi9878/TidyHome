using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Custom;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TidyHome_MVC.Controllers.Widgets;
using TidyHome_MVC.Models.Dto_s;
using TidyHome_MVC.Models.Widgets.WhatWeDoRepeaterWidget;
[assembly: RegisterWidget("TidyHome_MVC.Widget.WhatWeDoRepeaterWidget", typeof(WhatWeDoRepeaterWidgetController), "RepeaterWidget", Description = "To Display RepeaterWidget", IconClass = "icon-badge")]

namespace TidyHome_MVC.Controllers.Widgets
{
    public class WhatWeDoRepeaterWidgetController : WidgetController<WhatWeDoRepeaterProperties>
    {
        // GET: WhatWeDoRepeaterWidget
        public ActionResult Index()
        {
            var properties = GetProperties();

            if (properties.FeaturesPath != null)
            {
                string selectedPagePath = properties.FeaturesPath == null ? "/" : properties.FeaturesPath.FirstOrDefault().NodeAliasPath;
                return PartialView("Widgets/_WhatWeDoRepeater", new WhatWeDoRepeaterViewModel()
                {
                    Repeater = GetWhatWeDoRepeater(selectedPagePath)
                });
            }
            else
            {
                return null;
            }

        }
        public List<WhatWeDoRepeaterdto> GetWhatWeDoRepeater(string selectedPagePath)
        {

            var data = DocumentHelper.GetDocuments<WhatWeDoRepeater>()
                            .Path(selectedPagePath, PathTypeEnum.Children)
                            .Select(m => new WhatWeDoRepeaterdto()
                            {
                                anchor = m.anchor,
                                Image = m.Image,
                                Title = m.Title

                            }).ToList();
            return data;
        }

    }
}