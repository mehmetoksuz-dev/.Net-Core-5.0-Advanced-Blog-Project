#pragma checksum "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eca496492ae990d53c6746f45a26f0b88380ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_AddCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eca496492ae990d53c6746f45a26f0b88380ca3", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
    public class Areas_Admin_Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add New Category</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm("AddCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Category Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Category Description"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextAreaFor(x => x.CategoryDescription, 10, 3, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 21 "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Areas\Admin\Views\Category\AddCategory.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
