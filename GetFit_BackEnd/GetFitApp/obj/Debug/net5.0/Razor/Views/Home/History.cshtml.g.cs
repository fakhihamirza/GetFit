#pragma checksum "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48fd74d9681e9983addd7c587e8a88f8361af2a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_History), @"mvc.1.0.view", @"/Views/Home/History.cshtml")]
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
#nullable restore
#line 1 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\_ViewImports.cshtml"
using GetFitApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\_ViewImports.cshtml"
using GetFitApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48fd74d9681e9983addd7c587e8a88f8361af2a9", @"/Views/Home/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94308f696a93e7ba98ac84544c73f52dd8eca710", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GetFitApp.Models.ReadHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>History Of Food Items Consumed</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml"
           Write(Html.DisplayNameFor(model => model.food_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml"
           Write(Html.DisplayNameFor(model => model.food_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml"
 foreach (var item in @Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml"
           Write(Html.DisplayFor(modelItem => item.food_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml"
           Write(Html.DisplayFor(modelItem => item.food_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\History.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GetFitApp.Models.ReadHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
