#pragma checksum "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71048195880a8743fa6893cc475867e107a16d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRole_Edit), @"mvc.1.0.view", @"/Views/UserRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRole/Edit.cshtml", typeof(AspNetCore.Views_UserRole_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71048195880a8743fa6893cc475867e107a16d5", @"/Views/UserRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9551255ee82bbbbfa903353b772cecd6ea4c10", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserRoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Edit.cshtml"
  
    ViewBag.Path = new List<string>() { "Users Role - Add / Edit" };

#line default
#line hidden
#line 5 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Edit.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
{

#line default
#line hidden
            BeginContext(157, 59, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(217, 20, false);
#line 8 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Edit.cshtml"
   Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(237, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 10 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Edit.cshtml"
}

#line default
#line hidden
            DefineSection("Head", async() => {
                BeginContext(268, 103, true);
                WriteLiteral("\r\n    <link href=\"https://cdn.datatables.net/1.10.25/css/jquery.dataTables.min.css\" rel=\"stylesheet\">\r\n");
                EndContext();
            }
            );
            BeginContext(374, 978, true);
            WriteLiteral(@"
<div class="""" id=""app"">
    <div class=""form-row"">
        <div class=""col-md-6"">
            <div class=""position-relative form-group"">
                <label class="""">Name</label>
                <input placeholder=""name"" type=""text"" class=""form-control"" v-model=""model.Name"">
            </div>
            <div class=""position-relative form-check"">
                <input type=""checkbox"" class=""form-check-input"" v-model=""model.IsSuperUser"">
                <label class=""form-check-label"">Super User</label>
            </div>
        </div>
    </div>
    <br>
    <h5 class="""">Privileges</h5>
    <br>
    <privilege-group-view v-for=""(group,index) in model.PrivilegeGroups"" :key=""group.Name"" :group=""group"" :index=""index"">
    </privilege-group-view>
    <div align=""right"">
        <a href=""/UserRole/Index"" class=""mt-2 btn btn-danger"">Cancel</a>
        <button class=""mt-2 btn btn-primary"" v-on:click=""save()"">Save</button>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1369, 1510, true);
                WriteLiteral(@"
    <script src=""https://unpkg.com/vue@2""></script>
    <script src=""https://unpkg.com/vue-select@2""></script>
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script src=""https://unpkg.com/vue""></script>
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>

    <script>

        Vue.component('v-select', VueSelect.VueSelect);

        Vue.component('privilege-group-view', {
            template: `<div style=""margin-bottom:40px"">
                            <h6 class="""">{{group.Name}}</h6>
                            <div class=""divider""></div>
                            <form class="""">
                                <privilege-view v-for=""(privilege,index) in group.RolePrivileges"" :key=""privilege.Name"" :privilege=""privilege"" :index=""index"">
    </privilege-view>

                            </form>
                        </div>`,

            props: ['group', 'index'],
        });

        Vue.component('privilege-view', {
           ");
                WriteLiteral(@" template: `
                                <div class=""position-relative form-check form-check-inline""><label class=""form-check-label""><input type=""checkbox"" v-model=""privilege.Value"" class=""form-check-input""> {{privilege.DisplayName}}</label></div>
                        `,

            props: ['privilege', 'index'],
        });

        var app = new Vue({
            el: '#app',
            components: {

            },
            data: {
                model: ");
                EndContext();
                BeginContext(2880, 31, false);
#line 77 "C:\Users\Prathap\Downloads\InventoryManagementSystem\InventoryManagementSystem\Source Code\InventoryManagement.Web\Views\UserRole\Edit.cshtml"
                  Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
                EndContext();
                BeginContext(2911, 2960, true);
                WriteLiteral(@",
                isSubmited: false,
                error: false,
                errorMessage: """",
                privileges: []
            },
            created() {
            },
            mounted() {
            },
            methods: {

                save() {
                    debugger;

                    var jsonData = JSON.stringify(this.model);
                    var url = '/UserRole/Edit';
                    axios({
                        method: 'post',
                        dataType: 'json',
                        url: url,
                        async: false,
                        data: ""data="" + btoa(unescape(encodeURIComponent(jsonData))),
                    }).then(response => {
                        var res = response.data;
                        if (res.success) {

                            Swal.fire({
                                icon: 'success',
                                title: 'Your work has been saved',
                   ");
                WriteLiteral(@"             showConfirmButton: true,

                            }).then((result) => {
                                if (result.isConfirmed) {
                                    window.location.href = ""/UserRole/Index"";
                                }
                            });

                        }
                        else {

                            Swal.fire({
                                icon: 'error',
                                title: 'Error',
                                //text: res.error,
                                html: '<pre>' + res.error + '</pre>',
                                customClass: {
                                    popup: 'format-pre'
                                }
                            });

                        }
                    }).catch(e => {
                        Swal.fire({
                            icon: 'error',
                            title: 'Something went wrong (e)',
                  ");
                WriteLiteral(@"          text: """",
                        });
                    });
                },
            },

            computed: {
            },
            watch: {
                //'Invoice.OtherPartyId'(value) {
                //    if (value == '' || value == null) return;

                //    if (this.Invoice.Id > 0) return;

                //    axios.get('/Invoice/GetPendingOrderLines?id=' + value + '&typeId=' + this.Invoice.Type.Id)
                //        .then(response => {
                //            debugger;
                //            var data = response.data
                //            this.linkedPos = data;
                //        })
                //        .catch(e => {
                //            debugger;
                //            alert(e);
                //        });
                //}
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
