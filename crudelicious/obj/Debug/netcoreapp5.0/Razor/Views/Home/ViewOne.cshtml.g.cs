#pragma checksum "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e347cd00f7e265ebcbe95eb80a458a8cad042a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewOne), @"mvc.1.0.view", @"/Views/Home/ViewOne.cshtml")]
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
#line 1 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\_ViewImports.cshtml"
using crudelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\_ViewImports.cshtml"
using crudelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e347cd00f7e265ebcbe95eb80a458a8cad042a83", @"/Views/Home/ViewOne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1344efeabb6281de7249210f4b4c13df6c6eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n    <h1>");
#nullable restore
#line 3 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml"
   Write(ViewBag.Dish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h4>");
#nullable restore
#line 4 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml"
   Write(ViewBag.Dish.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml"
  Write(ViewBag.Dish.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br>\r\n    <p>Calories: ");
#nullable restore
#line 8 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml"
            Write(ViewBag.Dish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Tastiness: ");
#nullable restore
#line 9 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml"
             Write(ViewBag.Dish.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 247, "\"", 282, 2);
            WriteAttributeValue("", 254, "/delete/", 254, 8, true);
#nullable restore
#line 11 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml"
WriteAttributeValue("", 262, ViewBag.Dish.DishID, 262, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 325, "\"", 358, 2);
            WriteAttributeValue("", 332, "/edit/", 332, 6, true);
#nullable restore
#line 12 "C:\Users\pkaze\Desktop\VS Projects\Coding Dojo\C#\crudelicious\Views\Home\ViewOne.cshtml"
WriteAttributeValue("", 338, ViewBag.Dish.DishID, 338, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591