#pragma checksum "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0722b53c0f132dfb5ed5a14adb03714f9c8f223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Educations_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Educations/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0722b53c0f132dfb5ed5a14adb03714f9c8f223", @"/Areas/Admin/Views/Educations/Create.cshtml")]
    public class Areas_Admin_Views_Educations_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio.Models.Education>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Education</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Specialization"" class=""control-label""></label>
                <input asp-for=""Specialization"" class=""form-control"" />
                <span asp-validation-for=""Specialization"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EducationName"" class=""control-label""></label>
                <input asp-for=""EducationName"" class=""form-control"" />
                <span asp-validation-for=""EducationName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to L");
            WriteLiteral("ist</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\гороховв\source\repos\Portfolio\Portfolio\Areas\Admin\Views\Educations\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio.Models.Education> Html { get; private set; }
    }
}
#pragma warning restore 1591
