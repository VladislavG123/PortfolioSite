#pragma checksum "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a2677c3dce88b8a7876ba3337f0008a73e670f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Educations_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Educations/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a2677c3dce88b8a7876ba3337f0008a73e670f", @"/Areas/Admin/Views/Educations/Index.cshtml")]
    public class Areas_Admin_Views_Educations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Portfolio.Models.Education>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EducationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EducationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 800, "\"", 823, 1);
#nullable restore
#line 34 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
WriteAttributeValue("", 815, item.Id, 815, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 876, "\"", 899, 1);
#nullable restore
#line 35 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
WriteAttributeValue("", 891, item.Id, 891, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 954, "\"", 977, 1);
#nullable restore
#line 36 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
WriteAttributeValue("", 969, item.Id, 969, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Portfolio.Models.Education>> Html { get; private set; }
    }
}
#pragma warning restore 1591