#pragma checksum "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Skills\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ffac6131e540e7e31a14e587d3b78bd11198b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Skills_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Skills/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ffac6131e540e7e31a14e587d3b78bd11198b2", @"/Areas/Admin/Views/Skills/Details.cshtml")]
    public class Areas_Admin_Views_Skills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio.Models.Skill>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Skills\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Skill</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Skills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SkillName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.SkillName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Skills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 637, "\"", 661, 1);
#nullable restore
#line 28 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Skills\Details.cshtml"
WriteAttributeValue("", 652, Model.Id, 652, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio.Models.Skill> Html { get; private set; }
    }
}
#pragma warning restore 1591
