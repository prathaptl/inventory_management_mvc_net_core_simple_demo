#pragma checksum "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa91640920cb30ddccb5985398f848de125d80a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRole_Index), @"mvc.1.0.view", @"/Views/UserRole/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRole/Index.cshtml", typeof(AspNetCore.Views_UserRole_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa91640920cb30ddccb5985398f848de125d80a4", @"/Views/UserRole/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9551255ee82bbbbfa903353b772cecd6ea4c10", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserRoleListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Head", async() => {
                BeginContext(50, 103, true);
                WriteLiteral("\r\n    <link href=\"https://cdn.datatables.net/1.10.25/css/jquery.dataTables.min.css\" rel=\"stylesheet\">\r\n");
                EndContext();
            }
            );
#line 5 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
  
    ViewBag.Path = new List<string>() { "User Roles", "" };

#line default
#line hidden
            BeginContext(224, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
{

#line default
#line hidden
            BeginContext(280, 87, true);
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(368, 20, false);
#line 12 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
   Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(388, 172, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
}

#line default
#line hidden
            BeginContext(563, 344, true);
            WriteLiteral(@"<div class="""" align=""right"">
    <a href=""/UserRole/Edit"" class=""mt-2 btn btn-primary"">Add New</a>

</div>
<br>
<div class=""table-responsive"">
    <table class=""mb-0 table"" id=""data_table"">
        <thead>
            <tr>
                <th>Name</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 32 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(964, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1011, 9, false);
#line 35 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 74, true);
            WriteLiteral("</td>\r\n                    <td align=\"center\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1094, "\"", 1152, 1);
#line 37 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
WriteAttributeValue("", 1101, Url.Action("Edit", "UserRole",new { id = item.Id}), 1101, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1153, 355, true);
            WriteLiteral(@" class=""mm-active"">
                            <i class=""metismenu-icon pe-7s-edit""></i>
                            Edit
                        </a>
                        &nbsp; &nbsp;
                        <a href=""javascript:void(0)"" id=""deleteItem"" class=""deleteItem red"" data-target=""#deleteConfirmationModal"" data-toggle=""modal"" data-id=""");
            EndContext();
            BeginContext(1509, 7, false);
#line 42 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
                                                                                                                                                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1516, 192, true);
            WriteLiteral("\">\r\n                            <i class=\"metismenu-icon pe-7s-trash\"></i>\r\n                            Delete\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1723, 42, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
            DefineSection("Modal", async() => {
                BeginContext(1780, 1098, true);
                WriteLiteral(@"
    <div class=""modal fade"" id=""deleteConfirmationModal"" tabindex=""-1"" role=""basic"" aria-hidden=""true""
         style=""display: none;"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                    </button>
                    <h4 class=""modal-title"">
                        Delete Confirmation
                    </h4>
                </div>
                <div class=""modal-body"">
                    Are you sure you want to delete this record?
                </div>
                <div class=""modal-footer"">
                    <button data-dismiss=""modal"" type=""button"" class=""btn btn-primary btn-round"">
                        No
                    </button>
                    <button id=""btnContinueDelete"" type=""button"" class=""btn btn-danger btn-round"">
                        Yes
                    </button>");
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(2898, 689, true);
                WriteLiteral(@"

    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#data_table').DataTable();
        });

        var item_to_delete;
        debugger;
        $("".deleteItem"").click(function (e) {
            debugger;
            item_to_delete = $(this).data('id');
        });

        debugger;
        $(function () {
            $('#btnContinueDelete').click(function () {
                debugger;
                window.location = ""/UserRole/Delete?id="" + item_to_delete;
            });
        });

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserRoleListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
