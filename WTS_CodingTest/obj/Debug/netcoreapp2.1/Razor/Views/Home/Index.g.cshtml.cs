#pragma checksum "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fefefcacf16380ee42dbf4468891b65367081599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\_ViewImports.cshtml"
using WTS_CodingTest;

#line default
#line hidden
#line 2 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\_ViewImports.cshtml"
using WTS_CodingTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fefefcacf16380ee42dbf4468891b65367081599", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1deb96a2aa3892464dcbed6d3de3ce5e9b748b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 412, true);
            WriteLiteral(@"

<div class=""row"">
    
    <table>
        <thead style=""border-bottom:2px solid black; font-weight:600;"">
            <tr>
                <td style=""width: 3rem;"">ID</td>
                <td style=""min-width:12rem;"">Full Name</td>
                <td style=""min-width:12rem;"">Weekly Hours</td>
                <td style=""min-width:12rem;"">Monthly Hours</td>
            </tr>
        </thead>

");
            EndContext();
#line 18 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml"
         foreach(var item in ViewBag.DisplayItems)
        {

#line default
#line hidden
            BeginContext(520, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(559, 16, false);
#line 21 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml"
               Write(item.Employee_ID);

#line default
#line hidden
            EndContext();
            BeginContext(575, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(603, 22, false);
#line 22 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml"
               Write(item.Employee_FullName);

#line default
#line hidden
            EndContext();
            BeginContext(625, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(653, 26, false);
#line 23 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml"
               Write(item.Employee_Hours_Weekly);

#line default
#line hidden
            EndContext();
            BeginContext(679, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(707, 27, false);
#line 24 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml"
               Write(item.Employee_Hours_Monthly);

#line default
#line hidden
            EndContext();
            BeginContext(734, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Rowan\source\repos\WTS_CodingTest\WTS_CodingTest\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(771, 26, true);
            WriteLiteral("\r\n    </table>\r\n\r\n</div>\r\n");
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
