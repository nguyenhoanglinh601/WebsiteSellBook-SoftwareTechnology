#pragma checksum "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ef8ac141322c7fd27d6a13738b30e4cafd3dc2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang_DatHang), @"mvc.1.0.view", @"/Views/DonHang/DatHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef8ac141322c7fd27d6a13738b30e4cafd3dc2f", @"/Views/DonHang/DatHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fc4dfdda67f370c24307dda62e1778518ad5fb", @"/Views/_ViewImports.cshtml")]
    public class Views_DonHang_DatHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanSach.Models.ViewModel.GioHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "datHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
  
    ViewData["Title"] = "Đặt hàng";
    decimal tongTien = 0;

    string dinhDangTien(decimal gia)
    {
        string giaBanVND = "";
        string giaBan = Convert.ToInt32(gia).ToString();
        var j = 0;
        for (var i = giaBan.Length - 1; i >= 0; i--)
        {
            giaBanVND = giaBan[i] + giaBanVND;
            j++;
            if (j % 3 == 0 && i != 0)
            {
                giaBanVND = "." + giaBanVND;
            }
        }
        return giaBanVND;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Đặt hàng</h1>\r\n\r\n<h4>Thông tin đặt hàng</h4>\r\n\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef8ac141322c7fd27d6a13738b30e4cafd3dc2f5551", async() => {
                WriteLiteral("\r\n        <div class=\"col-md-4\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef8ac141322c7fd27d6a13738b30e4cafd3dc2f5857", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 32 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""form-group"">
                <label name=""tenNguoiNhan"" class=""control-label"">Tên người nhận</label>
                <input name=""tenNguoiNhan"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label name=""diaChiGiaoHang"" class=""control-label"">Địa chỉ giao hàng</label>
                <textarea name=""diaChiGiaoHang"" class=""form-control""> </textarea>
            </div>
            <div class=""form-group"">
                <label name=""soDienThoai"" class=""control-label"">Số điện thoại</label>
                <input name=""soDienThoai"" class=""form-control"" />
            </div>
            <br />
        </div>
        <h1>Giỏ hàng</h1>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Tên sách
                    </th>
                    <th>
                        Loại sách
                    </th>
                    <th>
                        ");
                WriteLiteral(@"NXB
                    </th>
                    <th>
                        Số lượng
                    </th>
                    <th>
                        Giá Bán
                    </th>
                    <th>
                        Thành tiền
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 72 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                 foreach (var item in Model.tapHopSanPham)
                {
                    var x = @item.sach.giaBan * @item.soLuong;
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 77 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                       Write(item.sach.ten);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 80 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                             foreach (var loaiSach in Model.tapHopLoaiSach)
                            {
                                if (item.sach.maLoai == loaiSach.idLoai)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                               Write(loaiSach.tenLoai);

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                                                     
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 89 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                             foreach (var NXB in Model.danhSachNXB)
                            {
                                if (item.sach.idNhaXuatBan == NXB.idNhaXuatBan)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                               Write(NXB.ten);

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                                            
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 98 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                       Write(item.soLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 101 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                       Write(dinhDangTien(item.sach.giaBan));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ\r\n                        </td>\r\n                        <td>\r\n\r\n                            <p>");
#nullable restore
#line 105 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                          Write(dinhDangTien(x));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</p>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 108 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <br />\r\n");
#nullable restore
#line 112 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\DatHang.cshtml"
         foreach (var item in Model.tapHopSanPham)
        {
            tongTien = tongTien + item.sach.giaBan * item.soLuong;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br /><br />\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Đặt hàng\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBanSach.Models.ViewModel.GioHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
