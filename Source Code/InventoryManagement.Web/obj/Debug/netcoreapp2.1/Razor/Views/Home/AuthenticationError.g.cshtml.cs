#pragma checksum "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\Home\AuthenticationError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aaf529781341c2053a075cc2abfc751cfbf5b80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AuthenticationError), @"mvc.1.0.view", @"/Views/Home/AuthenticationError.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AuthenticationError.cshtml", typeof(AspNetCore.Views_Home_AuthenticationError))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aaf529781341c2053a075cc2abfc751cfbf5b80", @"/Views/Home/AuthenticationError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9551255ee82bbbbfa903353b772cecd6ea4c10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AuthenticationError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 51, true);
            WriteLiteral("<div class=\"alert alert-danger\" role=\"alert\">\r\n    ");
            EndContext();
            BeginContext(52, 13, false);
#line 2 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\Home\AuthenticationError.cshtml"
Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(65, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\Home\AuthenticationError.cshtml"
  
    ViewBag.Path = new List<string>() { "Access denied", "" };

#line default
#line hidden
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