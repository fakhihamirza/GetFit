#pragma checksum "D:\Fast\Semester 7\IPT\Project\GetFit_BackEnd\GetFitApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df29e8842ec95b4fd8c2a577f25ea738a3815fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df29e8842ec95b4fd8c2a577f25ea738a3815fc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94308f696a93e7ba98ac84544c73f52dd8eca710", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<html lang=""en"">

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df29e8842ec95b4fd8c2a577f25ea738a3815fc4990", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content=""Northstreet Restaurant"">
    <meta name=""author"" content=""A.K."">

    <title>Restaurant Northstreet</title>


    <!-- Latest compiled and minified CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"">

    <!-- jQuery library -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>

    <!-- Popper JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""></script>

    <!-- Latest compiled JavaScript -->
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>

    <!-- Custom Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans"" rel=");
                WriteLiteral(@"""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Leckerli+One"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Lora"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Ubuntu"" rel=""stylesheet"">

    <!-- Custom CSS -->
    <link rel=""stylesheet"" href=""style.css"" type=""text/css"">

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df29e8842ec95b4fd8c2a577f25ea738a3815fc7625", async() => {
                WriteLiteral(@"
    <div class=""jumbotron"">
        <div class=""container-fluid"">
            <div class=""header-content-inner"">
                <h1>Welcome to Northstreet restaurant</h1>
                <h3>
                    We are proud of our long history of making delicious meals, warm and
                    friendly atmosphere and professional staff.
                </h3>
            </div>
        </div>
    </div>

    <section class=""bg-about bg-section"" id=""about"">
        <div class=""container-fluid"">
            <h1 class=""container-h1"">About</h1>
            <div class=""row"">
                <div class=""col-sm-5"">

                    <div class=""hov-img"">
                        <img src=""https://res.cloudinary.com/dbte0ueti/image/upload/v1536951746/new/warm_welcome.jpg"" alt=""Warm welcome"" class=""hov-img-bottom img-fluid"">
                        <div class=""hov-img-top hov-img-slideup"">
                            <div class=""hov-img-text"">
                                <h5>Warm welcome</h5>
            ");
                WriteLiteral(@"                    <p>It had separate tables, a menu, and specialized in soups made with a base of meat and eggs, which were said to be restaurants or, in English ""restoratives"".</p>
                            </div>
                        </div>
                    </div>

                    <div class=""hov-img"">
                        <img src=""https://res.cloudinary.com/dbte0ueti/image/upload/v1536951746/new/delicious_meals.jpg"" alt=""Delicious meals"" class=""hov-img-bottom img-fluid"">
                        <div class=""hov-img-top hov-img-slideup"">
                            <div class=""hov-img-text"">
                                <h5>Delicious meals</h5>
                                <p> In about 1765 a new kind of eating establishment, called a ""Bouillon"", was opened on rue des Poulies, near the Louvre, by a man named Boulanger.</p>
                            </div>
                        </div>
                    </div>

                    <div class=""hov-img"">
                        <img");
                WriteLiteral(@" src=""https://res.cloudinary.com/dbte0ueti/image/upload/v1536951746/new/professional_staff.jpg"" alt=""Professional staff"" class=""hov-img-bottom img-fluid"">
                        <div class=""hov-img-top hov-img-slideup"">
                            <div class=""hov-img-text"">
                                <h5>Professional staff</h5>
                                <p>For centuries Paris had taverns which served food at large common tables, but they were notoriously crowded, noisy, not very clean, and served food of dubious quality.</p>
                            </div>
                        </div>
                    </div>

                </div>

                <div class=""col-sm-7"">
                    <div class=""row "">
                        <div class=""restaurant-history slideanim text-center"">
                            <h3 class=""section-heading"">Restaurant Northstreet</h3>
                            <p class=""about-history first"">
                                The modern idea of a restauran");
                WriteLiteral(@"t – as well as the term itself – appeared in Paris in the 18th century. For centuries Paris had taverns which served food at large common tables, but they were notoriously crowded, noisy, not very clean, and served food of dubious quality. In about 1765 a new kind of eating establishment, called a ""Bouillon"", was opened on rue des Poulies, near the Louvre, by a man named Boulanger.<br /> <br>
                                It had separate tables, a menu, and specialized in soups made with a base of meat and eggs, which were said to be restaurants or, in English ""restoratives"". Other similar bouillons soon opened around Paris.
                                In about 1765 a new kind of eating establishment, called a ""Bouillon"", was opened on rue des Poulies, near the Louvre, by a man named Boulanger.
                                It had separate tables, a menu, and specialized in soups made with a base of meat and eggs, which were said to be restaurants or, in English ""restoratives"". Other similar bouillons");
                WriteLiteral(@" soon opened around Paris.
                            </p>

                            <button type=""button"" class=""btn more"" id=""more"" data-toggle=""collapse"" data-target=""#demo"">More</button>
                            <div id=""demo"" class=""collapse"">
                                <p class=""about-history""> Thanks to Boulanger and his imitators, these soups moved from the category of remedy into the category of health food and ultimately into the category of ordinary food. Their existence was predicated on health, not gustatory, requirements.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591