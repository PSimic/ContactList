#pragma checksum "d:\Repos\ContactList\Views\Roles\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc79880dc64b2e4a782d7caf7eecd5caf82702f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Update), @"mvc.1.0.view", @"/Views/Roles/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Update.cshtml", typeof(AspNetCore.Views_Roles_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffc79880dc64b2e4a782d7caf7eecd5caf82702f", @"/Views/Roles/Update.cshtml")]
    public class Views_Roles_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactList.Models.Roles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(37, 784, true);
            WriteLiteral(@"    <section class=""content-header"">
        <h1>
        Roles
        </h1>
    </section>
    <!-- Main content -->
    <section class=""content container-fluid"">
        <!-- Horizontal Form -->
        <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Update Role</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action=""/Roles/UpdateRole"">
            <div class=""box-body"">
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Type</label>
                <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""Type"" placeholder=""Type""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 821, "\"", 840, 1);
#line 21 "d:\Repos\ContactList\Views\Roles\Update.cshtml"
WriteAttributeValue("", 829, Model.Type, 829, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(841, 319, true);
            WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Description</label>
                <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""Description"" placeholder=""Description""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1160, "\"", 1186, 1);
#line 27 "d:\Repos\ContactList\Views\Roles\Update.cshtml"
WriteAttributeValue("", 1168, Model.Description, 1168, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1187, 91, true);
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <input type=\"hidden\" name=\"Pkey\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1278, "\"", 1297, 1);
#line 30 "d:\Repos\ContactList\Views\Roles\Update.cshtml"
WriteAttributeValue("", 1286, Model.Pkey, 1286, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1298, 379, true);
            WriteLiteral(@"/>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
            <button type=""submit"" class=""btn btn-default"">Cancel</button>
            <button type=""submit"" class=""btn btn-info pull-right"">Update</button>
            </div>
            <!-- /.box-footer -->
        </form>
        </div>
        <!-- /.box -->
    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactList.Models.Roles> Html { get; private set; }
    }
}
#pragma warning restore 1591
