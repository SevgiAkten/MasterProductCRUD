#pragma checksum "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "016d41127f97205c6168dac1c447eca5b07a5a1f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016d41127f97205c6168dac1c447eca5b07a5a1f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.MasterProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(77, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2e1e094d87413dad90928e7f31e6b9", async() => {
                BeginContext(100, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(114, 584, true);
            WriteLiteral(@"
    </p>
    <table id=""myTable"" class=""display"" style=""width:100%"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>LeadTime</th>
                <th>ShiploadTime</th>
                <th>MainPrice</th>
                <th>SalesPrice</th>
                <th>Discount</th>
                <th>BrandId</th>
                <th>CategoryId</th>
                <th>AutoID</th>
                <th>CriticalStock</th>
                <th>Operation</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 24 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(755, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(802, 7, false);
#line 27 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(809, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(841, 9, false);
#line 28 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(850, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(882, 13, false);
#line 29 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.LeadTime);

#line default
#line hidden
            EndContext();
            BeginContext(895, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(927, 17, false);
#line 30 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.ShiploadTime);

#line default
#line hidden
            EndContext();
            BeginContext(944, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(976, 14, false);
#line 31 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.MainPrice);

#line default
#line hidden
            EndContext();
            BeginContext(990, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1022, 15, false);
#line 32 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.SalesPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1069, 13, false);
#line 33 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(1082, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1114, 12, false);
#line 34 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.BrandId);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1158, 15, false);
#line 35 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(1173, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1205, 11, false);
#line 36 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.AutoId);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1248, 18, false);
#line 37 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(item.CriticalStock);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1324, 52, false);
#line 39 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1405, 54, false);
#line 40 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1488, 52, false);
#line 41 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 45 "C:\Users\sevgI.akten\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1609, 124, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    \r\n    <script>\r\n  $(function(){\r\n      $(\"#myTable\").dataTable();\r\n  })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.MasterProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
