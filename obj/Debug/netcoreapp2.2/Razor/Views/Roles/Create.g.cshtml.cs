#pragma checksum "d:\Repos\ContactList\Views\Roles\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16aca1e7c6669ab9fc9de75658590257ab0e86df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Create), @"mvc.1.0.view", @"/Views/Roles/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Create.cshtml", typeof(AspNetCore.Views_Roles_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16aca1e7c6669ab9fc9de75658590257ab0e86df", @"/Views/Roles/Create.cshtml")]
    public class Views_Roles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1219, true);
            WriteLiteral(@"    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <h1>
        Roles
        </h1>
    </section>
    <!-- Main content -->
    <section class=""content container-fluid"">
        <!-- Horizontal Form -->
        <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Add Role</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action=""CreateRole"">
            <div class=""box-body"">
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Type</label>
                <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""Type"" placeholder=""Type"">
                </div>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
            <button type=""submit"" class=""btn btn-default"">Cancel</button>
            <b");
            WriteLiteral("utton type=\"submit\" class=\"btn btn-info pull-right\">Create</button>\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        </form>\r\n        </div>\r\n        <!-- /.box -->\r\n    </section>");
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