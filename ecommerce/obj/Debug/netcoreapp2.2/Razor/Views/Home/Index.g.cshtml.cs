#pragma checksum "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918e42ba255f91617eeb94852a5e473b96d125ae"
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
#line 1 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/_ViewImports.cshtml"
using ecommerce;

#line default
#line hidden
#line 2 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/_ViewImports.cshtml"
using ecommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918e42ba255f91617eeb94852a5e473b96d125ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f21b70560d5a59d669ee90de49e3401f8465fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Index-Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Index-Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 251, true);
            WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <p>\r\n        Dashboard | \r\n        <a href=\"/products\">Products | </a>\r\n        <a href=\"/orders\">Orders | </a>\r\n        <a href=\"/customers\">Customers | </a>\r\n        <a href=\"/settings\">Settings</a>\r\n    </p>\r\n</div>\r\n\r\n");
            EndContext();
#line 15 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
 foreach(var product in ViewBag.FiveProducts)
{

#line default
#line hidden
            BeginContext(346, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 354, "\"", 374, 1);
#line 17 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
WriteAttributeValue("", 360, product.Image, 360, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(375, 67, true);
            WriteLiteral(" style=\"height:150px; width:150px; display:inline-block;\">\r\n    <p>");
            EndContext();
            BeginContext(443, 12, false);
#line 18 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
  Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(455, 14, true);
            WriteLiteral("</p>\r\n    <p>(");
            EndContext();
            BeginContext(470, 16, false);
#line 19 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
   Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(486, 12, true);
            WriteLiteral(" left)</p>\r\n");
            EndContext();
#line 20 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
}

#line default
#line hidden
            BeginContext(501, 26, true);
            WriteLiteral("\r\n<h3>Recent Orders</h3>\r\n");
            EndContext();
#line 23 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
 foreach (var order in ViewBag.ThreeOrders)
{

#line default
#line hidden
            BeginContext(575, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(583, 19, false);
#line 25 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
  Write(order.Customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(602, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 26 "/home/mole/Desktop/code_dojo/c_sharp/ecommerce/Views/Home/Index.cshtml"
}

#line default
#line hidden
            BeginContext(612, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "918e42ba255f91617eeb94852a5e473b96d125ae6390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(641, 12, true);
            WriteLiteral("</partial>\r\n");
            EndContext();
            BeginContext(653, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "918e42ba255f91617eeb94852a5e473b96d125ae7637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(685, 12, true);
            WriteLiteral("</partial>\r\n");
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
