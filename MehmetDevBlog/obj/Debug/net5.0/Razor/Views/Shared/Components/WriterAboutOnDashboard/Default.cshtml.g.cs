#pragma checksum "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3e8cdd3ba88a42f4fa2614254728c265ee854a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAboutOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
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
#line 1 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e8cdd3ba88a42f4fa2614254728c265ee854a9", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a1216afd556b30d34c29e5093136afaf62ced2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterAboutOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">About Writer</h4>
                <hr />
                <div class=""d-flex mt-5 align-items-top"">
");
#nullable restore
#line 11 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 402, "\"", 425, 1);
#nullable restore
#line 12 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
WriteAttributeValue("", 408, item.WriterImage, 408, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-sm rounded-circle mr-3\" alt=\"image\">\r\n                    <div class=\"mb-0 flex-grow\">\r\n                        <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 14 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                         Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                            Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 15 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                     Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 17 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; }
    }
}
#pragma warning restore 1591