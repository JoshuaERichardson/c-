#pragma checksum "/home/mole/Desktop/code_dojo/c_sharp/wedding_planner/Views/Home/Wedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e5dd4199ac5e4b07ebc2b4aa66f972952ab432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wedding), @"mvc.1.0.view", @"/Views/Home/Wedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Wedding.cshtml", typeof(AspNetCore.Views_Home_Wedding))]
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
#line 1 "/home/mole/Desktop/code_dojo/c_sharp/wedding_planner/Views/_ViewImports.cshtml"
using wedding_planner;

#line default
#line hidden
#line 2 "/home/mole/Desktop/code_dojo/c_sharp/wedding_planner/Views/_ViewImports.cshtml"
using wedding_planner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e5dd4199ac5e4b07ebc2b4aa66f972952ab432", @"/Views/Home/Wedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0aadd694686a14c367f0150bd67bec2e71f0b6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 73, true);
            WriteLiteral("\n<div class=\"weddingDiv\">\n    <div class=\"weddingDivHeader\">\n        <h1>");
            EndContext();
            BeginContext(74, 27, false);
#line 4 "/home/mole/Desktop/code_dojo/c_sharp/wedding_planner/Views/Home/Wedding.cshtml"
       Write(ViewBag.CurrentWedding.WOne);

#line default
#line hidden
            EndContext();
            BeginContext(101, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(107, 27, false);
#line 4 "/home/mole/Desktop/code_dojo/c_sharp/wedding_planner/Views/Home/Wedding.cshtml"
                                        Write(ViewBag.CurrentWedding.WTwo);

#line default
#line hidden
            EndContext();
            BeginContext(134, 104, true);
            WriteLiteral("</h1>\n        <a href=\"/dashboard\">Dashboard</a>\n        <a href=\"/\">Logout</a>\n    </div>\n    <p>Date: ");
            EndContext();
            BeginContext(239, 16, false);
#line 8 "/home/mole/Desktop/code_dojo/c_sharp/wedding_planner/Views/Home/Wedding.cshtml"
        Write(ViewBag.ThisDate);

#line default
#line hidden
            EndContext();
            BeginContext(255, 35, true);
            WriteLiteral(" <p>\n    <h3>Guests:</h3>\n\n\n\n</div>");
            EndContext();
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
