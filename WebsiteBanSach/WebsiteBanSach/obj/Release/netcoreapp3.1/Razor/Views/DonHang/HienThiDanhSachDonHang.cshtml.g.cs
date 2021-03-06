#pragma checksum "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a3246606685502a5716f0cf1ada3d33b1478d15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang_HienThiDanhSachDonHang), @"mvc.1.0.view", @"/Views/DonHang/HienThiDanhSachDonHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3246606685502a5716f0cf1ada3d33b1478d15", @"/Views/DonHang/HienThiDanhSachDonHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fc4dfdda67f370c24307dda62e1778518ad5fb", @"/Views/_ViewImports.cshtml")]
    public class Views_DonHang_HienThiDanhSachDonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebsiteBanSach.Models.ViewModel.DonHangVaTrangThai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 120px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mb-1 p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "suaThongTinDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mb-1 p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "xemDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "huyDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
  
    string trangChu = "sach-hienthidanhsachsach-Trang chủ;";
    string donHang = "Đơn hàng";
    string Navigation = trangChu + donHang;

    ViewBag.Navigation = Navigation;

    ViewData["Title"] = "Danh sách đơn đặt hàng";

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
        return giaBanVND+"đ";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Danh sách đơn hàng</h1>\r\n\r\n<div class=\"table-responsive\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.idDonHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.thoiGianDatHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.diaChiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.thoiGianGiaoHangDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.phiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.soDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.VAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 58 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
               Write(Html.DisplayNameFor(model => model.donHang.tongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Trạng thái\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 67 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donHang.idDonHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donHang.thoiGianDatHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donHang.diaChiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 80 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                         if (item.donHang.thoiGianGiaoHangDuKien.ToString() == "1/1/0001 12:00:00 AM")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i>Đang xử lý</i>\r\n");
#nullable restore
#line 83 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                       Write(Html.DisplayFor(modelItem => item.donHang.thoiGianGiaoHangDuKien));

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                                                                                              
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 90 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                         if (item.donHang.phiGiaoHang.ToString() == "0.00")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i>Đang xử lý</i>\r\n");
#nullable restore
#line 93 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                       Write(dinhDangTien(item.donHang.phiGiaoHang));

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                                                                   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 100 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donHang.soDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                   Write(dinhDangTien(item.donHang.VAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 106 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                   Write(dinhDangTien(item.donHang.tongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                   Write(Html.DisplayFor(modelItem => item.trangThaiDonhang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a3246606685502a5716f0cf1ada3d33b1478d1515729", async() => {
                WriteLiteral("Sửa thông tin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idDonHang", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                                                                                                                           WriteLiteral(item.donHang.idDonHang);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDonHang"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDonHang", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDonHang"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a3246606685502a5716f0cf1ada3d33b1478d1518238", async() => {
                WriteLiteral("Xem chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idDonHang", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                                                                                                                WriteLiteral(item.donHang.idDonHang);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDonHang"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDonHang", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDonHang"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a3246606685502a5716f0cf1ada3d33b1478d1520735", async() => {
                WriteLiteral("Hủy đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idDonHang", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
                                                                                                              WriteLiteral(item.donHang.idDonHang);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDonHang"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDonHang", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDonHang"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 117 "D:\hk1-20202021\software technology\1.0\WebsiteBanSach\WebsiteBanSach\Views\DonHang\HienThiDanhSachDonHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebsiteBanSach.Models.ViewModel.DonHangVaTrangThai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
