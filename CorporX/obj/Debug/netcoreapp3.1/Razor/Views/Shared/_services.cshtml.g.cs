#pragma checksum "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "433ff7b0c5919e01ba5380c2044adcf114b3d85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__services), @"mvc.1.0.view", @"/Views/Shared/_services.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"433ff7b0c5919e01ba5380c2044adcf114b3d85b", @"/Views/Shared/_services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13762b49581517d50ee73634c0f44582458cef2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Services>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    
    
    <!--services section start-->
<section class=""services-section ptb-100 gray-light-bg"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-8"">
                <div class=""section-heading text-center mb-5"">
                    <h2>We Provide Best Quality Services</h2>
                    <p class=""lead"">
                        Efficiently aggregate end-to-end core competencies without maintainable ideas. Dynamically
                        foster tactical solutions without enabled value.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 19 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_services.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                    <div class=\"services-single d-flex p-5 my-md-3 my-lg-3 my-sm-0 shadow-sm white-bg rounded\">\r\n                        <div class=\"service-icon mr-4\">\r\n                            <span");
            BeginWriteAttribute("class", " class=\"", 1012, "\"", 1054, 3);
#nullable restore
#line 23 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_services.cshtml"
WriteAttributeValue("", 1020, item.Icon, 1020, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1030, "icon-md", 1031, 8, true);
            WriteAttributeValue(" ", 1038, "color-secondary", 1039, 16, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                        </div>\r\n                        <div class=\"services-content-wrap\">\r\n                            <h5>");
#nullable restore
#line 26 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_services.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"mb-0\">\r\n                                ");
#nullable restore
#line 28 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_services.cshtml"
                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <a href=""services-details.html"" target=""_blank"" class=""detail-link mt-3"">Read more <span class=""ti-arrow-right""></span></a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 34 "C:\Users\User\source\repos\CorporX\CorporX\Views\Shared\_services.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n        </div>\r\n    </div>\r\n</section>\r\n<!--services section end-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Services>> Html { get; private set; }
    }
}
#pragma warning restore 1591
