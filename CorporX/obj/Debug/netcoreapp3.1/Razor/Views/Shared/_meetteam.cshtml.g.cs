#pragma checksum "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "882c7874672d5df87551e4b66ba05cda8d585cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__meetteam), @"mvc.1.0.view", @"/Views/Shared/_meetteam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"882c7874672d5df87551e4b66ba05cda8d585cbe", @"/Views/Shared/_meetteam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13762b49581517d50ee73634c0f44582458cef2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__meetteam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Member>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("team image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

<!--team two section start-->
<section class=""team-two-section ptb-100 gray-light-bg"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-8 col-lg-8"">
                <div class=""section-heading text-center mb-5"">
                    <h2>Meet Our Lovely Team</h2>
                    <p class=""lead"">
                        Distinctively grow go forward manufactured products and optimal networks. Enthusiastically
                        disseminate user-centric outsourcing.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 19 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4\">\r\n                    <div class=\"staff-member\">\r\n                        <div class=\"card text-center border-0\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "882c7874672d5df87551e4b66ba05cda8d585cbe5051", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 913, "~/uploads/", 913, 10, true);
#nullable restore
#line 23 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
AddHtmlAttributeValue("", 923, item.Photo, 923, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"teacher mb-0\">");
#nullable restore
#line 25 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
                                                    Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <span>");
#nullable restore
#line 26 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
                                 Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <ul class=\"list-inline pt-2 social\">\r\n");
#nullable restore
#line 28 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
                                     foreach (var items in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"list-inline-item\">\r\n                                            <a href=\"#\" target=\"_blank\">\r\n                                                <span");
            BeginWriteAttribute("class", " class=\"", 1542, "\"", 1571, 2);
            WriteAttributeValue("", 1550, "ti-", 1550, 3, true);
#nullable restore
#line 32 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
WriteAttributeValue("", 1553, items.MemberLinks, 1553, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 35 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                  
                                </ul>
                            </div>
                        </div>
                        <div class=""overlay d-flex align-items-center justify-content-center"">
                            <div class=""overlay-inner"">
                                <p class=""teacher-quote"">");
#nullable restore
#line 44 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
                                                    Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p><a href=\"#\" class=\"teacher-name\">\r\n                                    <h5 class=\"mb-0 teacher text-white\">");
#nullable restore
#line 45 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
                                                                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </a>\r\n                                <span class=\"teacher-field text-white\">");
#nullable restore
#line 47 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"
                                                                  Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <ul class=""list-inline py-4 social"">
                                    <li class=""list-inline-item"">
                                        <a href=""#"" target=""_blank"">
                                            <span class=""ti-facebook""></span>
                                        </a>
                                    </li>
                                    <li class=""list-inline-item"">
                                        <a href=""#"" target=""_blank"">
                                            <span class=""ti-linkedin""></span>
                                        </a>
                                    </li>
                                    <li class=""list-inline-item"">
                                        <a href=""#"" target=""_blank"">
                                            <span class=""ti-dribbble""></span>
                                        </a>
                                    </li>
                              ");
            WriteLiteral(@"  </ul>
                                <p class=""teacher-see-profile"">
                                    <a href=""#"" class=""btn outline-white-btn"">View my profile</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 72 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_meetteam.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n        </div>\r\n    </div>\r\n</section>\r\n<!--team two section end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
