#pragma checksum "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340378008f7c2ce8f6db3ad54085c8a17052dd5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectDetails_Index), @"mvc.1.0.view", @"/Views/ProjectDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340378008f7c2ce8f6db3ad54085c8a17052dd5b", @"/Views/ProjectDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13762b49581517d50ee73634c0f44582458cef2b", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("project"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_calltoaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!--body content wrap start-->\r\n<div class=\"main\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "340378008f7c2ce8f6db3ad54085c8a17052dd5b4839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Breadcrumb;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!--project details section start-->
    <section class=""project-details-section ptb-100"">
        <div class=""container"">
            <div class=""row justify-content-between"">
                <div class=""col-md-12 col-lg-8"">
                    <div class=""img-wrap mb-md-4 mb-lg-0"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "340378008f7c2ce8f6db3ad54085c8a17052dd5b6741", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 479, "~/uploads/", 479, 10, true);
#nullable restore
#line 14 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
AddHtmlAttributeValue("", 489, Model.ProjectDescription.Photo, 489, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-12 col-lg-4"">
                    <!--all services list-->
                    <aside class=""widget widget-categories"">
                        <div class=""widget-title"">
                            <h5>All Services</h5>
                        </div>
                        <ul class=""all-service-list"">
                            <li><a href=""#"">Financial Services Consulting</a></li>
                            <li><a href=""#"">Consumer Product Consulting</a></li>
                            <li><a href=""#"">Global Consumer insights</a></li>
                            <li><a href=""#"">Independent contractor</a></li>
                            <li><a href=""#"">Creative Idea Development</a></li>
                            <li><a href=""#"">Social Media Marketing</a></li>
                        </ul>
                    </aside>
                </div>
            </div>

            <!--project details row ");
            WriteLiteral("start-->\r\n            <div class=\"row mt-5\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"project-details-content\">\r\n                        <h5>");
#nullable restore
#line 39 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
                       Write(Model.ProjectDescription.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>\r\n                            ");
#nullable restore
#line 41 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
                       Write(Model.ProjectDescription.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                        
                       
                    </div>
                </div>
            </div>
            <div class=""row mt-5"">
                <div class=""col-md-6"">
                    <div class=""project-details-feature"">
                        <ul class=""list-unstyled tech-feature-list"">
");
#nullable restore
#line 52 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
                             foreach (var item in Model.ProjectDescriptionItem)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"py-1\">\r\n                                    <span class=\"ti-check-box mr-2 color-secondary\"></span><strong>");
#nullable restore
#line 55 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                    ");
#nullable restore
#line 56 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
                               Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 58 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          
                        </ul>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""project-details-feature"">
                        <ul class=""list-unstyled tech-feature-list"">

");
#nullable restore
#line 68 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
                             foreach (var item in Model.ProjectDescriptionItem)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"py-1\">\r\n    <span class=\"ti-check-box mr-2 color-secondary\"></span><strong>");
#nullable restore
#line 71 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n   ");
#nullable restore
#line 72 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"
Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</li>\r\n");
#nullable restore
#line 74 "C:\Users\User\source\repos\CorporX\CorporX\Views\ProjectDetails\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!--project details row end-->\r\n        </div>\r\n    </section>\r\n    <!--project details section end-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "340378008f7c2ce8f6db3ad54085c8a17052dd5b13581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</div>\r\n<!--body content wrap end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
