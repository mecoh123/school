#pragma checksum "C:\Users\user\source\repos\School\School\Views\Enroll\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46cd1cd9a4593841f3527edb0034d00fea00e83b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enroll_Edit), @"mvc.1.0.view", @"/Views/Enroll/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Enroll/Edit.cshtml", typeof(AspNetCore.Views_Enroll_Edit))]
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
#line 1 "C:\Users\user\source\repos\School\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\School\School\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46cd1cd9a4593841f3527edb0034d00fea00e83b", @"/Views/Enroll/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Enroll_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<School.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\user\source\repos\School\School\Views\Enroll\Edit.cshtml"
   
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 44, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<ul class=\"list-group\">\r\n");
            EndContext();
#line 10 "C:\Users\user\source\repos\School\School\Views\Enroll\Edit.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(215, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(228, 42, false);
#line 12 "C:\Users\user\source\repos\School\School\Views\Enroll\Edit.cshtml"
       Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(270, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 13 "C:\Users\user\source\repos\School\School\Views\Enroll\Edit.cshtml"
    }

#line default
#line hidden
            BeginContext(284, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<School.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
