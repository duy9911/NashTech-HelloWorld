#pragma checksum "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "783bd012799b3c0fb3e1f90e9a7c53fd6b468499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Index), @"mvc.1.0.view", @"/Views/Rookies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"783bd012799b3c0fb3e1f90e9a7c53fd6b468499", @"/Views/Rookies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b4f8b15379db635170d565a2047f3bcac65f345", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonModel>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <style>
        th {
            color: red;
        }

        .title {
            color: green;
        }

        button {
            width: 70px;
        }
    </style>
    <div class=title>
        <h3>Table Displaying All Memmber's Information</h3>
    </div>
    <table class=""table table-bordered table-responsive table-hover"">
        <tr>
            <th> Member Name</th>
            <th> Genger</th>
            <th>Phone Number</th>
            <th> Birth Place</th>
            <th> Day of Birth</th>
            <th> Graduate Status</th>
            <th>Email </th>
            <th>Feature </th>
        </tr>
");
#nullable restore
#line 34 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
                Write(item.FirstName+" "+item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
               Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
               Write(item.BirthPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
               Write(item.DayOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
               Write(item.IsGraduated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "783bd012799b3c0fb3e1f90e9a7c53fd6b4684996092", async() => {
                WriteLiteral(" Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1178, "~/Rookies/Edit/", 1178, 15, true);
#nullable restore
#line 45 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
AddHtmlAttributeValue("", 1193, item.ID, 1193, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                    <button onclick=\"return confirm(\'Are you sure you want to delete this?\')\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "783bd012799b3c0fb3e1f90e9a7c53fd6b4684997722", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1328, "~/Rookies/Delete/", 1328, 17, true);
#nullable restore
#line 46 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
AddHtmlAttributeValue("", 1345, item.ID, 1345, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                </td>\r\n                </tr >\r\n");
#nullable restore
#line 49 "C:\Users\ngoduy9911\Desktop\VSCODE\APSCORE_MVC\Views\Rookies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table >\r\n    </div >\r\n");
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
