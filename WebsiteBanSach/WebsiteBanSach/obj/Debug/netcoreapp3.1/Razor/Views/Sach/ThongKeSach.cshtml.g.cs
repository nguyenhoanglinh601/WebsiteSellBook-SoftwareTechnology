#pragma checksum "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a31863211513f962ae5abc82a5c97b533c694c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sach_ThongKeSach), @"mvc.1.0.view", @"/Views/Sach/ThongKeSach.cshtml")]
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
#line 1 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\_ViewImports.cshtml"
using WebsiteBanSach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\_ViewImports.cshtml"
using WebsiteBanSach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a31863211513f962ae5abc82a5c97b533c694c", @"/Views/Sach/ThongKeSach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fc4dfdda67f370c24307dda62e1778518ad5fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Sach_ThongKeSach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanSach.Models.ViewModel.ThongKeSach>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "themSach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
  
    string level1 = "donhang-thongkedonhang-Trang chủ;";
    string level2 = "Thống kê sách;";
    string Navigation = level1 + level2;
    ViewBag.Navigation = Navigation;

    ViewData["Title"] = "Thống kê sách";
    Layout = "_LayoutNV";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thống kê sách</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a31863211513f962ae5abc82a5c97b533c694c4349", async() => {
                WriteLiteral("Thêm sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<div style=""overflow-x:auto;"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Tên sách
                </th>
                <th>
                    Nhà xuất bản
                </th>
                <th>
                    Loại sách
                </th>
                <th>
                    Giá bán
                </th>
                <th>
                    Số lượng còn
                </th>
                <th>
                    Hình ảnh
                </th>
                <th>
                    Trạng thái
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 47 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
             foreach (var item in Model.tapHopSach)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 54 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                          
                            foreach (NhaXuatBan NXB in Model.danhSachNXB)
                            {
                                if (item.idNhaXuatBan == NXB.idNhaXuatBan)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                               Write(Html.DisplayFor(modelNXB => NXB.ten));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                                                                         
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 65 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                          
                            foreach (LoaiSach loaiSach in Model.tapHopLoaiSach)
                            {
                                if (item.maLoai == loaiSach.idLoai)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                               Write(Html.DisplayFor(modelLoaiSach => loaiSach.tenLoai));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                                                                                       
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                   Write(Html.DisplayFor(modelItem => item.giaBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                   Write(Html.DisplayFor(modelItem => item.soLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2576, "\"", 2625, 1);
#nullable restore
#line 82 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
WriteAttributeValue("", 2582, Html.DisplayFor(modelItem => item.hinhAnh), 2582, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px;\">\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
                   Write(Html.DisplayFor(modelItem => item.trangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2881, "\"", 2947, 4);
            WriteAttributeValue("", 2888, "./suaThongTinSach?id=", 2888, 21, true);
#nullable restore
#line 88 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
WriteAttributeValue("", 2909, item.idSach, 2909, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2921, "&lanTaiBan=", 2921, 11, true);
#nullable restore
#line 88 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
WriteAttributeValue("", 2932, item.lanTaiBan, 2932, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 91 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\Sach\ThongKeSach.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBanSach.Models.ViewModel.ThongKeSach> Html { get; private set; }
    }
}
#pragma warning restore 1591
