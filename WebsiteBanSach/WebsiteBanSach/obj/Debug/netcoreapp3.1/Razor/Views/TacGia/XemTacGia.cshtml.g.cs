#pragma checksum "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480305d18744dd2c551cdcbc7d1c3bce7386ac0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TacGia_XemTacGia), @"mvc.1.0.view", @"/Views/TacGia/XemTacGia.cshtml")]
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
#line 1 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\_ViewImports.cshtml"
using WebsiteBanSach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\_ViewImports.cshtml"
using WebsiteBanSach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480305d18744dd2c551cdcbc7d1c3bce7386ac0a", @"/Views/TacGia/XemTacGia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fc4dfdda67f370c24307dda62e1778518ad5fb", @"/Views/_ViewImports.cshtml")]
    public class Views_TacGia_XemTacGia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanSach.Models.TacGia>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
  
    ViewData["Title"] = "Thông tin tác giả";
    Layout = "_LayoutNV";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thông tin tác giả</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayNameFor(model => model.ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayFor(model => model.ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayNameFor(model => model.gioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayFor(model => model.gioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayNameFor(model => model.namSinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayFor(model => model.namSinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayNameFor(model => model.quocTich));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\TacGia\XemTacGia.cshtml"
       Write(Html.DisplayFor(model => model.quocTich));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBanSach.Models.TacGia> Html { get; private set; }
    }
}
#pragma warning restore 1591