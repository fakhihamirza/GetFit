#pragma checksum "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc3355c5f6c0180868d863720d5dbd71732a7b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetData), @"mvc.1.0.view", @"/Views/Home/GetData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc3355c5f6c0180868d863720d5dbd71732a7b8", @"/Views/Home/GetData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94308f696a93e7ba98ac84544c73f52dd8eca710", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetFitApp.Models.ViewProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
  
    ViewData["Title"] = "GetData";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Calorie Calculator</h1>
<div><b>Table Format Data Displaying in ForEach</b><br /></div>
<table class=""table table-bordered table-responsive table-hover"">
    <tr>
        <th>name </th>
        <th>fat_total_g </th>
        <th>calories </th>
        <th>cholesterol_mg</th>
        <th>protein_g</th>
        <th>sugar_g</th>
        <th>carbohydrates_total_g</th>
    </tr>
");
#nullable restore
#line 19 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
       foreach (var i in Model.gt.items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
               Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
               Write(i.fat_total_g);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
               Write(i.calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
               Write(i.cholesterol_mg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
               Write(i.protein_g);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
               Write(i.sugar_g);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
               Write(i.carbohydrates_total_g);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>\r\n<input type=\"submit\" value=\"Save Results\" />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bc3355c5f6c0180868d863720d5dbd71732a7b86441", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
#nullable restore
#line 38 "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\GetData.cshtml"
Write(Html.ActionLink("Get History", "History", new { Id = Model.gu.UserID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetFitApp.Models.ViewProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
