#pragma checksum "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c065349869979be6943434be005a1e0688dcd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
#line 1 "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
#line 1 "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/Home/Users.cshtml"
using viewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c065349869979be6943434be005a1e0688dcd8", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 54, true);
            WriteLiteral("    <h4 class=\"text-center\">Here are some Users!</h4>\n");
            EndContext();
#line 4 "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/Home/Users.cshtml"
     foreach(var name in Model)
    {

#line default
#line hidden
            BeginContext(140, 31, true);
            WriteLiteral("        <p class=\"text-center\">");
            EndContext();
            BeginContext(172, 14, false);
#line 6 "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/Home/Users.cshtml"
                          Write(name.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(186, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(188, 13, false);
#line 6 "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/Home/Users.cshtml"
                                          Write(name.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(201, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 7 "/Users/jeverett/Desktop/CSharp/ViewModelFun/ViewModelFun/Views/Home/Users.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
