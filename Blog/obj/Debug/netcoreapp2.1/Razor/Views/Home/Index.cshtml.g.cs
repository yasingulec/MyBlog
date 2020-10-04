#pragma checksum "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96617e6d705321f94ed9439537f7f7f27df04cbf"
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
#line 2 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#line 3 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96617e6d705321f94ed9439537f7f7f27df04cbf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9441f6bc3cc00f7951c7eb7911917222fac2c378", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
   
    ViewBag.Title = "Blog Website";
    ViewBag.Description = "This blog about programming";
    ViewBag.Keywords = "C#,MSSQL,ORACLE";

#line default
#line hidden
            BeginContext(172, 158, true);
            WriteLiteral("    <div class=\"container mt-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <div class=\"list-group\">\r\n                   ");
            EndContext();
            BeginContext(331, 39, false);
#line 11 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
              Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
            EndContext();
            BeginContext(370, 88, true);
            WriteLiteral("\r\n    \r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n");
            EndContext();
#line 16 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(523, 119, true);
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-header\">\r\n                            ");
            EndContext();
            BeginContext(643, 12, false);
#line 20 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
                       Write(item.Created);

#line default
#line hidden
            EndContext();
            BeginContext(655, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 717, "\"", 748, 2);
            WriteAttributeValue("", 723, "/content/blog/", 723, 14, true);
#line 22 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 737, item.Image, 737, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(749, 136, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(886, 10, false);
#line 25 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
                                              Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(896, 56, true);
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
            EndContext();
            BeginContext(953, 16, false);
#line 26 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(969, 34, true);
            WriteLiteral("</p>\r\n                            ");
            EndContext();
            BeginContext(1003, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd23518216f4fa48743b74330d20c64", async() => {
                BeginContext(1094, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1105, 90, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n");
            EndContext();
#line 31 "C:\Users\yasin\source\repos\BlogApplication\Blog\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1214, 46, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
