#pragma checksum "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d6f7311a1aa388861edb00fbf9a06c39e899a5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6f7311a1aa388861edb00fbf9a06c39e899a5e", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4173e1c09328e4989c76d1431c897dfcd73c0666", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 521, true);
            WriteLiteral(@"<style>
    .new-dish {
        font-size: 20px;
        margin-left: 700px;
    }
</style>
<h1><a href=""/"">Chefs</a> | Dishes <a href=""/dishes/new"" class=""new-dish btn btn-primary"">Add a Dish</a></h1>
<h2>Yum, take a look at our tasty dishes!</h2>
<table class=""table table-striped table-dark"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Chef</th>
            <th scope=""col"">Tastiness</th>
            <th scope=""col"">Calories</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml"
         foreach (var dish in ViewBag.AllDishes)
        {

#line default
#line hidden
            BeginContext(592, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(630, 9, false);
#line 23 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(639, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(666, 19, false);
#line 24 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(dish.Chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(685, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(687, 18, false);
#line 24 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml"
                                    Write(dish.Chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(705, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(732, 14, false);
#line 25 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(746, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(773, 13, false);
#line 26 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(786, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 28 "/Users/jeverett/Desktop/CSharp/ChefsDishes/ChefsDishes/Views/Home/Dishes.cshtml"
        }

#line default
#line hidden
            BeginContext(820, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591