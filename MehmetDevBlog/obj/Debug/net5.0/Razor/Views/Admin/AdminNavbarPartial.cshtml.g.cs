#pragma checksum "C:\Users\mehme\source\repos\MehmetDevBlog\.Net-Core-5.0-Advanced-Blog-Project\MehmetDevBlog\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785e77c4f8e55b42e9d21742149b4270ca6a3e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785e77c4f8e55b42e9d21742149b4270ca6a3e0a", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a1216afd556b30d34c29e5093136afaf62ced2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/inspinia-gh-pages/img/profile_small.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "785e77c4f8e55b42e9d21742149b4270ca6a3e0a4631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""block m-t-xs font-bold"">Mehmet Öksüz</span>
                        <span class=""text-muted text-xs block"">Software Engineer <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"">
                        <li><a class=""dropdown-item"" href=""profile.html"">Profile</a></li>
                        <li><a class=""dropdown-item"" href=""contacts.html"">Contacts</a></li>
                        <li><a class=""dropdown-item"" href=""mailbox.html"">Mailbox</a></li>
                        <li class=""dropdown-divider""></li>
                        <li><a class=""dropdown-item"" href=""login.html"">Logout</a></li>
                    </ul>
                </div>
                <div class=""logo-element"">
                    IN+
                </div>
            </li>
            <li>
                <a href=""index.html""><i cl");
            WriteLiteral(@"ass=""fa fa-th-large""></i> <span class=""nav-label"">Dashboard</span> <span class=""fa arrow""></span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""index.html"">Dashboard v.1</a></li>
                    <li><a href=""dashboard_2.html"">Dashboard v.2</a></li>
                    <li><a href=""dashboard_3.html"">Dashboard v.3</a></li>
                    <li><a href=""dashboard_4_1.html"">Dashboard v.4</a></li>
                    <li><a href=""dashboard_5.html"">Dashboard v.5 </a></li>
                </ul>
            </li>
            <li>
                <a href=""layouts.html""><i class=""fa fa-diamond""></i> <span class=""nav-label"">Layouts</span></a>
            </li>
            <li>
                <a href=""#""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">Graphics</span><span class=""fa arrow""></span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""graph_flot.html"">Flot Charts</a></li>
          ");
            WriteLiteral(@"          <li><a href=""graph_morris.html"">Morris.js Charts</a></li>
                    <li><a href=""graph_rickshaw.html"">Rickshaw Charts</a></li>
                    <li><a href=""graph_chartjs.html"">Chart.js</a></li>
                    <li><a href=""graph_chartist.html"">Chartist</a></li>
                    <li><a href=""c3.html"">c3 charts</a></li>
                    <li><a href=""graph_peity.html"">Peity Charts</a></li>
                    <li><a href=""graph_sparkline.html"">Sparkline Charts</a></li>
                </ul>
            </li>
            <li>
                <a href=""mailbox.html""><i class=""fa fa-envelope""></i> <span class=""nav-label"">Messages </span><span class=""label label-warning float-right"">16/24</span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""mailbox.html"">Inbox</a></li>
                    <li><a href=""mail_detail.html"">Email view</a></li>
                    <li><a href=""mail_compose.html"">Compose email</a></li>
       ");
            WriteLiteral(@"             <li><a href=""email_template.html"">Email templates</a></li>
                </ul>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-pie-chart""></i> <span class=""nav-label"">Metrics</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-group""></i> <span class=""nav-label"">Categories</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-list-alt""></i> <span class=""nav-label"">Blogs</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-comment""></i> <span class=""nav-label"">Comments</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-user""></i> <span class=""nav-label"">Writers</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-info""></i> <span class=""nav-label"">Settings</span>  </a>
            </li>");
            WriteLiteral(@"
            <li>
                <a href=""metrics.html""><i class=""fa fa-diamond""></i> <span class=""nav-label"">Notifications</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-phone""></i> <span class=""nav-label"">Contact</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-address-book""></i> <span class=""nav-label"">About Us</span>  </a>
            </li>
            <li>
                <a href=""widgets.html""><i class=""fa fa-flask""></i> <span class=""nav-label"">Statistics</span></a>
            </li>
            <li>
                <a href=""#""><i class=""fa fa-edit""></i> <span class=""nav-label"">Forms</span><span class=""fa arrow""></span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""form_basic.html"">Basic form</a></li>
                    <li><a href=""form_advanced.html"">Advanced Plugins</a></li>
                    <li><a href=""form_wizard.html""");
            WriteLiteral(@">Wizard</a></li>
                    <li><a href=""form_file_upload.html"">File Upload</a></li>
                    <li><a href=""form_editors.html"">Text Editor</a></li>
                    <li><a href=""form_autocomplete.html"">Autocomplete</a></li>
                    <li><a href=""form_markdown.html"">Markdown</a></li>
                </ul>
            </li>

            <li class=""active"">
                <a href=""#""><i class=""fa fa-table""></i> <span class=""nav-label"">Tables</span><span class=""fa arrow""></span></a>
                <ul class=""nav nav-second-level"">
                    <li class=""active""><a href=""table_basic.html"">Static Tables</a></li>
                    <li><a href=""table_data_tables.html"">Data Tables</a></li>
                    <li><a href=""table_foo_table.html"">Foo Tables</a></li>
                    <li><a href=""jq_grid.html"">jqGrid</a></li>
                </ul>
            </li>
            <li>
                <a href=""#""><i class=""fa fa-picture-o""></i> <span class=""nav");
            WriteLiteral(@"-label"">Gallery</span><span class=""fa arrow""></span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""basic_gallery.html"">Lightbox Gallery</a></li>
                    <li><a href=""slick_carousel.html"">Slick Carousel</a></li>
                    <li><a href=""carousel.html"">Bootstrap Carousel</a></li>

                </ul>
            </li>
        </ul>

    </div>
</nav>");
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
