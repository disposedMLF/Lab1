#pragma checksum "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b0760521c8c408c9e7a5d3f5140e07f31bb05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
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
#line 1 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\_ViewImports.cshtml"
using CSC237_mLopezFleming_Bethanys.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\_ViewImports.cshtml"
using CSC237_mLopezFleming_Bethanys.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b0760521c8c408c9e7a5d3f5140e07f31bb05f", @"/Views/Pie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f7642afcd2cdbbbaed8609001d135e68f9f50f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PiesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 5 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml"
 foreach (var pie in Model.Pies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 201, "\"", 229, 1);
#nullable restore
#line 12 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml"
WriteAttributeValue("", 207, pie.ImageThumbnailUrl, 207, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 230, "\"", 236, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
#nullable restore
#line 14 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml"
                                  Write(pie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h3>\r\n                    <a>");
#nullable restore
#line 16 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml"
                  Write(pie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h3>\r\n                <p>");
#nullable restore
#line 18 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml"
              Write(pie.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\Marcos\Desktop\C#\Advanced\CSC237_mLopezFleming_Bethanys\Views\Pie\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
