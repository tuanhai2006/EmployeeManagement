#pragma checksum "C:\ASP.NET CORE\EmployeeManagement\Views\Home\EmployeeNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56ce5c9a6eb10943fdd1f4081784b08e6b98ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeNotFound), @"mvc.1.0.view", @"/Views/Home/EmployeeNotFound.cshtml")]
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
#line 1 "C:\ASP.NET CORE\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ASP.NET CORE\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ASP.NET CORE\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56ce5c9a6eb10943fdd1f4081784b08e6b98ae4", @"/Views/Home/EmployeeNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9343a3fa1a5d5302dba0a60f9433083b3deb4965", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\ASP.NET CORE\EmployeeManagement\Views\Home\EmployeeNotFound.cshtml"
  
    ViewBag.Tilte = "404 Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger mt-1 mb-1\">\r\n        <h1>404 Not found error</h1>\r\n        <hr />\r\n        <h5>\r\n            Employee with ID = ");
#nullable restore
#line 9 "C:\ASP.NET CORE\EmployeeManagement\Views\Home\EmployeeNotFound.cshtml"
                          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cannot be found\r\n        </h5>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
