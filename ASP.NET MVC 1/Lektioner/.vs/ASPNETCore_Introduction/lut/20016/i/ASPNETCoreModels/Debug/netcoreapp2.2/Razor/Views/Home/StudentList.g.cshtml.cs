#pragma checksum "C:\Users\Cheesecake\Documents\CMS18\ASP.NET MVC 1\Lektioner\ASPNETCoreModels\Views\Home\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b2e7170512c2121f87e17bd55e56ca7fe8de42a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentList), @"mvc.1.0.view", @"/Views/Home/StudentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/StudentList.cshtml", typeof(AspNetCore.Views_Home_StudentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b2e7170512c2121f87e17bd55e56ca7fe8de42a", @"/Views/Home/StudentList.cshtml")]
    public class Views_Home_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPNETCoreModels.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Cheesecake\Documents\CMS18\ASP.NET MVC 1\Lektioner\ASPNETCoreModels\Views\Home\StudentList.cshtml"
  
    ViewData["Title"] = "StudentList";

#line default
#line hidden
            BeginContext(95, 30, true);
            WriteLiteral("\r\n<h1>StudentList</h1>\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\Cheesecake\Documents\CMS18\ASP.NET MVC 1\Lektioner\ASPNETCoreModels\Views\Home\StudentList.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
            BeginContext(169, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(182, 12, false);
#line 11 "C:\Users\Cheesecake\Documents\CMS18\ASP.NET MVC 1\Lektioner\ASPNETCoreModels\Views\Home\StudentList.cshtml"
       Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(194, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(197, 13, false);
#line 11 "C:\Users\Cheesecake\Documents\CMS18\ASP.NET MVC 1\Lektioner\ASPNETCoreModels\Views\Home\StudentList.cshtml"
                      Write(student.Email);

#line default
#line hidden
            EndContext();
            BeginContext(210, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(213, 13, false);
#line 11 "C:\Users\Cheesecake\Documents\CMS18\ASP.NET MVC 1\Lektioner\ASPNETCoreModels\Views\Home\StudentList.cshtml"
                                      Write(student.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(226, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\Cheesecake\Documents\CMS18\ASP.NET MVC 1\Lektioner\ASPNETCoreModels\Views\Home\StudentList.cshtml"
    }

#line default
#line hidden
            BeginContext(240, 10, true);
            WriteLiteral(" </ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPNETCoreModels.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
