#pragma checksum "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3cf083122b01ba41c133e9185e56fa48efce419"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_GetMaleGender), @"mvc.1.0.view", @"/Views/Rookies/GetMaleGender.cshtml")]
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
#line 1 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\_ViewImports.cshtml"
using APSCORE_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\_ViewImports.cshtml"
using APSCORE_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3cf083122b01ba41c133e9185e56fa48efce419", @"/Views/Rookies/GetMaleGender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b4f8b15379db635170d565a2047f3bcac65f345", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_GetMaleGender : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\r\n        table,\r\n        th,\r\n        td {\r\n            border: 1px solid black;\r\n        }\r\n    </style>\r\n    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
            Write(item.FirstName+" "+item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
           Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
           Write(item.DayOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
           Write(item.BirthPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
           Write(item.IsGraduated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 22 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\GetMaleGender.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
