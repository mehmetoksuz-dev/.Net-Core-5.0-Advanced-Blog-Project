#pragma checksum "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3461fb03576db698ce88fccdfdb4a9ef024b3710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\_ViewImports.cshtml"
using MehmetDevBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\_ViewImports.cshtml"
using MehmetDevBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3461fb03576db698ce88fccdfdb4a9ef024b3710", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a1216afd556b30d34c29e5093136afaf62ced2", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 16 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 645, "\"", 666, 1);
#nullable restore
#line 20 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 651, item.BlogImage, 651, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 698, "\"", 704, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 26 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                                                            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 36 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1922, "\"", 1960, 3);
            WriteAttributeValue("", 1929, "/Blog/BlogReadAll/", 1929, 18, true);
#nullable restore
#line 41 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1947, item.BlogID, 1947, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1959, "/", 1959, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">\r\n");
#nullable restore
#line 44 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                     if (item.BlogContent != null && item.BlogContent.Length > 130)
                                    { 
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                   Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                                                                                                                                      
                                    } 
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                   Write(item.BlogContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2666, "\"", 2704, 3);
            WriteAttributeValue("", 2673, "/Blog/BlogReadAll/", 2673, 18, true);
#nullable restore
#line 53 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2691, item.BlogID, 2691, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2703, "/", 2703, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 56 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591