#pragma checksum "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee747e74b3529ba3f10aa2e857b7dd5e944a4a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
#line 1 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\_ViewImports.cshtml"
using InventoryManagement.Web;

#line default
#line hidden
#line 2 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\_ViewImports.cshtml"
using InventoryManagement.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee747e74b3529ba3f10aa2e857b7dd5e944a4a5", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9551255ee82bbbbfa903353b772cecd6ea4c10", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("42"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/avatars/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\Shared\_Header.cshtml"
   
    var context = InventoryManagement.Web.Context.Context.UserContext;

#line default
#line hidden
            BeginContext(77, 1246, true);
            WriteLiteral(@"<div class=""app-header header-shadow"">
    <div class=""app-header__logo"">
        <div class=""logo-src""></div>
        <div class=""header__pane ml-auto"">
            <div>
                <button type=""button"" class=""hamburger close-sidebar-btn hamburger--elastic"" data-class=""closed-sidebar"">
                    <span class=""hamburger-box"">
                        <span class=""hamburger-inner""></span>
                    </span>
                </button>
            </div>
        </div>
    </div>
    <div class=""app-header__mobile-menu"">
        <div>
            <button type=""button"" class=""hamburger hamburger--elastic mobile-toggle-nav"">
                <span class=""hamburger-box"">
                    <span class=""hamburger-inner""></span>
                </span>
            </button>
        </div>
    </div>
    <div class=""app-header__menu"">
        <span>
            <button type=""button"" class=""btn-icon btn-icon-only btn btn-primary btn-sm mobile-toggle-header-nav"">
                <span class=""btn-ic");
            WriteLiteral("on-wrapper\">\n                    <i class=\"fa fa-ellipsis-v fa-w-6\"></i>\n                </span>\n            </button>\n        </span>\n    </div>\n    <div class=\"app-header__content\">\n        <div class=\"app-header-left\">\n");
            EndContext();
            BeginContext(1686, 469, true);
            WriteLiteral(@"        </div>
        <div class=""app-header-right"">
            <div class=""header-btn-lg pr-0"">
                <div class=""widget-content p-0"">
                    <div class=""widget-content-wrapper"">
                        <div class=""widget-content-left"">
                            <div class=""btn-group"">
                                <a data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" class=""p-0 btn"">
                                    ");
            EndContext();
            BeginContext(2155, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "730afc5337414bcaabc69e3c6a4291d9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2237, 940, true);
            WriteLiteral(@"
                                    <i class=""fa fa-angle-down ml-2 opacity-8""></i>
                                </a>
                                <div tabindex=""-1"" role=""menu"" aria-hidden=""true"" class=""dropdown-menu dropdown-menu-right"">
                                    <button type=""button"" tabindex=""0"" class=""dropdown-item"">User Account</button>
                                    <button type=""button"" tabindex=""0"" class=""dropdown-item"">Settings</button>
                                    <div tabindex=""-1"" class=""dropdown-divider""></div>
                                    <a href=""/Login/Logout"" tabindex=""0"" class=""dropdown-item"">Logout</a>
                                </div>
                            </div>
                        </div>
                        <div class=""widget-content-left  ml-3 header-user-info"">
                            <div class=""widget-heading"">
                               ");
            EndContext();
            BeginContext(3178, 12, false);
#line 65 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\Shared\_Header.cshtml"
                          Write(context.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3190, 169, true);
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div> ");
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