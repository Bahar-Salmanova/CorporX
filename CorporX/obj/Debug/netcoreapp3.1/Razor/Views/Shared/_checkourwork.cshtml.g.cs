#pragma checksum "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_checkourwork.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c722ffce11a8e6402f227d460a3bd81cb9194ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__checkourwork), @"mvc.1.0.view", @"/Views/Shared/_checkourwork.cshtml")]
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
#line 1 "C:\Users\User\source\repos\CorporX\CorporX\Views\_ViewImports.cshtml"
using CorporX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\CorporX\CorporX\Views\_ViewImports.cshtml"
using CorporX.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\CorporX\CorporX\Views\_ViewImports.cshtml"
using CorporX.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c722ffce11a8e6402f227d460a3bd81cb9194ec9", @"/Views/Shared/_checkourwork.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13762b49581517d50ee73634c0f44582458cef2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__checkourwork : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("portfolio"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<section class=""our-portfolio-section ptb-100"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""section-heading text-center mb-5"">
                    <h2>Check Our Quality Work</h2>
                    <p class=""lead"">
                        Dynamically pursue reliable convergence rather than 24/7 process improvements. Intrinsicly
                        develop end-to-end customer service without extensive data.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""text-center pb-2"">
                    <button type=""button"" class=""filter-btn"" data-mixitup-control data-filter=""all"">All</button>
                    <button type=""button"" class=""filter-btn"" data-mixitup-control data-filter="".branding"">Branding</button>
                    <button type=""button"" class=""filter-btn");
            WriteLiteral(@""" data-mixitup-control data-filter="".animation"">Animation</button>
                    <button type=""button"" class=""filter-btn"" data-mixitup-control data-filter="".other"">Others</button>
                </div>
                <div class=""portfolio-container"" id=""MixItUp"">
");
#nullable restore
#line 28 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_checkourwork.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1423, "\"", 1464, 3);
            WriteAttributeValue("", 1431, "mix", 1431, 3, true);
            WriteAttributeValue(" ", 1434, "portfolio-item", 1435, 15, true);
#nullable restore
#line 30 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_checkourwork.cshtml"
WriteAttributeValue(" ", 1449, item.Category, 1450, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-ref=\"mixitup-target\">\r\n    <div class=\"portfolio-wrapper\">\r\n        <a href=\"project-details.html\" target=\"_blank\">\r\n            <div class=\"content-overlay\"></div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c722ffce11a8e6402f227d460a3bd81cb9194ec96353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1677, "~/uploads/", 1677, 10, true);
#nullable restore
#line 34 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_checkourwork.cshtml"
AddHtmlAttributeValue("", 1687, item.Photo, 1687, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"content-details fadeIn-bottom text-white\">\r\n                <h5 class=\"text-white mb-1\">");
#nullable restore
#line 36 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_checkourwork.cshtml"
                                       Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p> ");
#nullable restore
#line 37 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_checkourwork.cshtml"
               Write(item.Specialty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </a>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 42 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_checkourwork.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                   
                    <div class=""gap""></div>
                    <div class=""gap""></div>
                    <div class=""gap""></div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
