#pragma checksum "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3b54810644a524ed2e25ee92e4cdbf763c2c706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TrendingPost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TrendingPost/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TrendingPost/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TrendingPost_Default))]
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
#line 2 "D:\GitProjects\MyBlog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#line 3 "D:\GitProjects\MyBlog\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3b54810644a524ed2e25ee92e4cdbf763c2c706", @"/Views/Shared/Components/TrendingPost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9441f6bc3cc00f7951c7eb7911917222fac2c378", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TrendingPost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 132, true);
            WriteLiteral("<div class=\"blog-sidebar-section -trending-post\">\r\n    <div class=\"center-line-title\">\r\n        <h5>Trending post</h5>\r\n    </div>\r\n");
            EndContext();
#line 6 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
       
        int rank = 0;
    

#line default
#line hidden
            BeginContext(197, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 9 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
     foreach (var item in Model)
    {
        rank++;

#line default
#line hidden
            BeginContext(255, 135, true);
            WriteLiteral("    <!--Trending Post 1 -->\r\n    <div class=\"trending-post\">\r\n        <div class=\"trending-post_image\">\r\n            <div class=\"rank\">");
            EndContext();
            BeginContext(391, 4, false);
#line 15 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
                         Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(395, 62, true);
            WriteLiteral("</div>\r\n            <!--Img size is 100 x 100 -->\r\n           ");
            EndContext();
            BeginContext(457, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e56c7da05ea4960b314a8e5937d823a", async() => {
                BeginContext(525, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 529, "\"", 553, 2);
                WriteAttributeValue("", 535, "/Image/", 535, 7, true);
#line 17 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
WriteAttributeValue("", 542, item.Image, 542, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 554, "\"", 577, 1);
#line 17 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
WriteAttributeValue("", 560, item.Description, 560, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(578, 1, true);
                WriteLiteral(">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(583, 118, true);
            WriteLiteral(" \r\n        </div>\r\n        <div class=\"trending-post_content\">\r\n            <!-- Category Header -->\r\n            <h5>");
            EndContext();
            BeginContext(702, 18, false);
#line 21 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
           Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(720, 19, true);
            WriteLiteral("</h5>\r\n            ");
            EndContext();
            BeginContext(739, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df9290cfa3c46abb61806b961e04350", async() => {
                BeginContext(808, 10, false);
#line 22 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
                                                                           Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(822, 105, true);
            WriteLiteral("\r\n            <div class=\"info__time\">\r\n                <i class=\"far fa-clock\"></i>\r\n                <p>");
            EndContext();
            BeginContext(928, 43, false);
#line 25 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
              Write(item.Created.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(971, 147, true);
            WriteLiteral("</p>\r\n                \r\n\r\n            </div>\r\n            <div class=\"info__time\">\r\n                <i class=\"fas fa-eye\"></i>\r\n                <p>");
            EndContext();
            BeginContext(1119, 14, false);
#line 31 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"
              Write(item.ViewCount);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 35 "D:\GitProjects\MyBlog\Blog\Views\Shared\Components\TrendingPost\Default.cshtml"

    }

#line default
#line hidden
            BeginContext(1196, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
