#pragma checksum "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\Test\Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e8402a78a5124490fe6805ec687869255b17a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Table), @"mvc.1.0.view", @"/Views/Test/Table.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Table.cshtml", typeof(AspNetCore.Views_Test_Table))]
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
#line 1 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\_ViewImports.cshtml"
using TechLinkIntranet;

#line default
#line hidden
#line 2 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\_ViewImports.cshtml"
using TechLinkIntranet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e8402a78a5124490fe6805ec687869255b17a3", @"/Views/Test/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7087f3556ee938ca08c724b6716eb81619f8543a", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TechLinkIntranet.Models.Test.TableItems>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 365, true);
            WriteLiteral(@"<table class=""table table-striped"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                PhoneNumber
            </th>
            <th>
                Address
            </th>
            <th>
                Position
            </th>
        </tr>
       
    </thead>
    <tbody>
");
            EndContext();
#line 25 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\Test\Table.cshtml"
 for (int i = 0; i < Model.Count; i++)
{

#line default
#line hidden
            BeginContext(495, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(526, 13, false);
#line 28 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\Test\Table.cshtml"
           Write(Model[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(539, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(563, 20, false);
#line 29 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\Test\Table.cshtml"
           Write(Model[i].PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(583, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(607, 16, false);
#line 30 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\Test\Table.cshtml"
           Write(Model[i].Address);

#line default
#line hidden
            EndContext();
            BeginContext(623, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(647, 17, false);
#line 31 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\Test\Table.cshtml"
           Write(Model[i].Position);

#line default
#line hidden
            EndContext();
            BeginContext(664, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "E:\job\tech-link\Project\TLIntranet\TechLinkIntranet\TechLinkIntranet\Views\Test\Table.cshtml"
}

#line default
#line hidden
            BeginContext(689, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TechLinkIntranet.Models.Test.TableItems>> Html { get; private set; }
    }
}
#pragma warning restore 1591
