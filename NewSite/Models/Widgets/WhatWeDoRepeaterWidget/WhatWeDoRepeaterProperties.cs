using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TidyHome_MVC.Models.Widgets.WhatWeDoRepeaterWidget
{
    public class WhatWeDoRepeaterProperties : IWidgetProperties
    {
        [EditingComponent(PathSelector.IDENTIFIER, Label = "Path")]
        [EditingComponentProperty(nameof(PathSelectorProperties.RootPath), "/")]
        [Required(ErrorMessage = "Please Select Path")]
        public List<PathSelectorItem> FeaturesPath { get; set; }
    }
}
