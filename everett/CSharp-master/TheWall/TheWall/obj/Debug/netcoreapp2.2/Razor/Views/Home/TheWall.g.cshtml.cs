#pragma checksum "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "424cad6f4587e9c9825b07f5a834e69b87b2d5de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TheWall), @"mvc.1.0.view", @"/Views/Home/TheWall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TheWall.cshtml", typeof(AspNetCore.Views_Home_TheWall))]
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
#line 1 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/_ViewImports.cshtml"
using TheWall;

#line default
#line hidden
#line 2 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/_ViewImports.cshtml"
using TheWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"424cad6f4587e9c9825b07f5a834e69b87b2d5de", @"/Views/Home/TheWall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d202197c3bfd1895a7b2b59f7940dc9c3d32218c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TheWall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheWall.Models.Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CreateMessagePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 38, true);
            WriteLiteral("\n\n\n        <p class=\"navname\">Welcome ");
            EndContext();
            BeginContext(70, 22, false);
#line 5 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                              Write(ViewBag.LoggedIn.FName);

#line default
#line hidden
            EndContext();
            BeginContext(92, 174, true);
            WriteLiteral("!</p>\n\n        <a class=\"btn btn-primary btn-sm active\" role=\"button\" href=\'/logout\'>Logout</a>\n\n\n\n<div class=\"container inline-block holder\">\n    <div>\n        <br>\n        ");
            EndContext();
            BeginContext(266, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "424cad6f4587e9c9825b07f5a834e69b87b2d5de5390", async() => {
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
            BeginContext(303, 75, true);
            WriteLiteral("</partial></partial>\n        \n    </div>\n    <div class=\"container-fluid\">\n");
            EndContext();
#line 18 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
         foreach (var m in ViewBag.Messages)
        {

#line default
#line hidden
            BeginContext(433, 50, true);
            WriteLiteral("            <div class=\"display\">\n            <h5>");
            EndContext();
            BeginContext(484, 15, false);
#line 21 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
           Write(m.Creator.FName);

#line default
#line hidden
            EndContext();
            BeginContext(499, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(503, 11, false);
#line 21 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                              Write(m.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(514, 21, true);
            WriteLiteral("</h5>\n            <p>");
            EndContext();
            BeginContext(536, 9, false);
#line 22 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
          Write(m.Content);

#line default
#line hidden
            EndContext();
            BeginContext(545, 27, true);
            WriteLiteral("</p>\n            <p>Likes: ");
            EndContext();
            BeginContext(573, 13, false);
#line 23 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                 Write(m.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(586, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 24 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
             if (m.UserId == ViewBag.Id)
            {

#line default
#line hidden
            BeginContext(646, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 664, "\"", 693, 2);
            WriteAttributeValue("", 671, "/destroym/", 671, 10, true);
#line 26 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
WriteAttributeValue("", 681, m.MessageId, 681, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(694, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 27 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 30 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                 if(m.Likes.Count == 0)
                {

#line default
#line hidden
            BeginContext(809, 35, true);
            WriteLiteral("                    <a class=\"like\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 844, "\"", 869, 2);
            WriteAttributeValue("", 851, "/like/", 851, 6, true);
#line 32 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
WriteAttributeValue("", 857, m.MessageId, 857, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(870, 10, true);
            WriteLiteral(">Like</a>\n");
            EndContext();
#line 33 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                }
                else
                {
                    bool y = false;
                    

#line default
#line hidden
#line 37 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                     foreach(var user in m.Likes)
                    {
                        

#line default
#line hidden
#line 39 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                         if(user.UserId == ViewBag.Id)
                        {
                            y = true;
                        }

#line default
#line hidden
#line 42 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                         
                    }

#line default
#line hidden
#line 44 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                     if(y == true)
                        {

#line default
#line hidden
            BeginContext(1273, 45, true);
            WriteLiteral("                            <a class=\"unlike\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1318, "\"", 1345, 2);
            WriteAttributeValue("", 1325, "/unlike/", 1325, 8, true);
#line 46 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
WriteAttributeValue("", 1333, m.MessageId, 1333, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1346, 12, true);
            WriteLiteral(">Unlike</a>\n");
            EndContext();
#line 47 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1439, 43, true);
            WriteLiteral("                            <a class=\"like\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1482, "\"", 1507, 2);
            WriteAttributeValue("", 1489, "/like/", 1489, 6, true);
#line 50 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
WriteAttributeValue("", 1495, m.MessageId, 1495, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1508, 10, true);
            WriteLiteral(">Like</a>\n");
            EndContext();
#line 51 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                        }

#line default
#line hidden
#line 51 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                                            
                }

#line default
#line hidden
#line 52 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1595, 21, true);
            WriteLiteral("\n\n            </div>\n");
            EndContext();
            BeginContext(1629, 35, true);
            WriteLiteral("    <div class=\"container-fluid\">\n\n");
            EndContext();
#line 60 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
     foreach (var c in m.Comments)
    { 

#line default
#line hidden
            BeginContext(1706, 48, true);
            WriteLiteral("        <div class=\"container\">\n            <h6>");
            EndContext();
            BeginContext(1755, 22, false);
#line 63 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
           Write(c.CommentCreator.FName);

#line default
#line hidden
            EndContext();
            BeginContext(1777, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1781, 11, false);
#line 63 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                                     Write(c.UpdatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1792, 32, true);
            WriteLiteral("</h6>\n            <p class=\"sp\">");
            EndContext();
            BeginContext(1825, 9, false);
#line 64 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
                     Write(c.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1834, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 65 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
             if (c.UserId == ViewBag.Id)
            {

#line default
#line hidden
            BeginContext(1894, 41, true);
            WriteLiteral("                <a class=\"d inline-block\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1935, "\"", 1964, 2);
            WriteAttributeValue("", 1942, "/destroyc/", 1942, 10, true);
#line 67 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
WriteAttributeValue("", 1952, c.CommentId, 1952, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1965, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 68 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
            }

#line default
#line hidden
            BeginContext(1991, 15, true);
            WriteLiteral("        </div>\n");
            EndContext();
#line 70 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
    }

#line default
#line hidden
            BeginContext(2012, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2020, 455, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "424cad6f4587e9c9825b07f5a834e69b87b2d5de15700", async() => {
                BeginContext(2078, 90, true);
                WriteLiteral("\n            <label for=\"exampleFormControlTextarea1\">Post a comment:</label>\n            ");
                EndContext();
                BeginContext(2168, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "424cad6f4587e9c9825b07f5a834e69b87b2d5de16170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 73 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2237, 47, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2284, "\"", 2316, 1);
#line 74 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
WriteAttributeValue("", 2292, ViewBag.LoggedIn.UserId, 2292, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2317, 151, true);
                WriteLiteral(">\n            <br>\n            <p class=\"text-right\"><input type=\"submit\" value=\"Post a comment\" class=\"btn btn-primary\"></p>\n            <br>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2034, "/create_comment/", 2034, 16, true);
#line 71 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
AddHtmlAttributeValue("", 2050, m.MessageId, 2050, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2475, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 80 "/Users/jeverett/Desktop/CSharp/TheWall/TheWall/Views/Home/TheWall.cshtml"
    }  

#line default
#line hidden
            BeginContext(2495, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheWall.Models.Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
