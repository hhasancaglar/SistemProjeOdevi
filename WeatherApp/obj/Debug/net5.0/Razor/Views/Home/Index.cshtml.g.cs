#pragma checksum "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aac701ec937f7caef451b33429ca5ec0d1c1c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Hasan\source\repos\WeatherApp\Views\_ViewImports.cshtml"
using WeatherApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hasan\source\repos\WeatherApp\Views\_ViewImports.cshtml"
using WeatherApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aac701ec937f7caef451b33429ca5ec0d1c1c24", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5982ed880600284e9d1c6d2e6f98bfd2936ac1ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml"
  
    var icon = ViewBag.icon;
    string srcc = "http://openweathermap.org/img/w/" + icon + ".png";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"body-infos\">\r\n    <div class=\"card-infos\">\r\n        <div class=\"city-info\">İstanbul, TR</div>\r\n        <div class=\"temp-value\">");
#nullable restore
#line 14 "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml"
                           Write(ViewBag.temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>&#176;</span>C</div>\r\n        <div>\r\n            <img style=\"width:120px;height:120px;\"");
            BeginWriteAttribute("src", " src=", 412, "", 422, 1);
#nullable restore
#line 16 "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 417, srcc, 417, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n        </div>\r\n        <div class=\"weather-info\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml"
       Write(ViewBag.weather);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"other-infos\">\r\n            <div class=\"feels-like-info\">\r\n                <p>\r\n                    Hissedilen <br />\r\n                    <div class=\"deg-info\">");
#nullable restore
#line 25 "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml"
                                     Write(ViewBag.feelslike);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>&#176;</span>C</div>\r\n                </p>\r\n            </div>\r\n            <div class=\"humidity-info\">\r\n                <p>\r\n                    Nem <br />\r\n                    <div class=\"deg-info\">");
#nullable restore
#line 31 "C:\Users\Hasan\source\repos\WeatherApp\Views\Home\Index.cshtml"
                                     Write(ViewBag.humidity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</div>\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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