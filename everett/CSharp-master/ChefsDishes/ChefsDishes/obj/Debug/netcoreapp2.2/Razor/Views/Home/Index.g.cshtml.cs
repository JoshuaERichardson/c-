#pragma checksum "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2b6a1352e20b610169b70d78c3dc9e8cc8de7d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/_ViewImports.cshtml"
using ChefsDishes;

#line default
#line hidden
#line 2 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/_ViewImports.cshtml"
using ChefsDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b6a1352e20b610169b70d78c3dc9e8cc8de7d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4173e1c09328e4989c76d1431c897dfcd73c0666", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 488, true);
            WriteLiteral(@"<style>
    .new-chef {
        font-size: 20px;
        margin-left: 700px;
    }
</style>
<h1>Chefs | <a href=""/dishes"">Dishes</a><a href=""/new"" class=""new-chef btn btn-primary"">Add a Chef</a></h1>
<h2>Check out our roster of Chefs!</h2>
<table class=""table table-striped table-dark"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Age</th>
            <th scope=""col""># of Dishes</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Index.cshtml"
         foreach (var chef in ViewBag.AllChefs)
        {

#line default
#line hidden
            BeginContext(561, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(600, 14, false);
#line 22 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Index.cshtml"
               Write(chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(614, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(616, 13, false);
#line 22 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Index.cshtml"
                               Write(chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(629, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(657, 8, false);
#line 23 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Index.cshtml"
               Write(chef.Age);

#line default
#line hidden
            EndContext();
            BeginContext(665, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(693, 24, false);
#line 24 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Index.cshtml"
               Write(chef.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(717, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(754, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591