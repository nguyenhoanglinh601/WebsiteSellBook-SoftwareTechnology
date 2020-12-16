#pragma checksum "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "974945083130574ef401374703a91490a3828d17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang_XuLyDonHang), @"mvc.1.0.view", @"/Views/DonHang/XuLyDonHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"974945083130574ef401374703a91490a3828d17", @"/Views/DonHang/XuLyDonHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fc4dfdda67f370c24307dda62e1778518ad5fb", @"/Views/_ViewImports.cshtml")]
    public class Views_DonHang_XuLyDonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanSach.Models.ViewModel.DonHangVaTrangThai>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "xuLyDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
  
    ViewData["Title"] = "Xử lý đơn hàng";
    string[] cacTrangThai = new string[] { "Đang xử lý", "Đã tiếp nhận", "Chuyển giao hàng", "Đã giao hàng", "Hủy" };
    int intTrangThai = 0;
    Layout = "_LayoutNV";

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
            WriteLiteral("\r\n<h1>Xử lý đơn hàng</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Mã đơn hàng\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayFor(model => model.donHang.idDonHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayNameFor(model => model.donHang.tenNguoiNhan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayFor(model => model.donHang.tenNguoiNhan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayNameFor(model => model.donHang.diaChiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayFor(model => model.donHang.diaChiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayNameFor(model => model.donHang.soDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayFor(model => model.donHang.soDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayNameFor(model => model.donHang.VAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(dinhDangTien(Model.donHang.VAT));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(Html.DisplayNameFor(model => model.donHang.tongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
       Write(dinhDangTien(Model.donHang.tongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ
        </dd>
    </dl>
</div>
<hr />
<h2>Danh sách sản phẩm đặt</h2>
<br />
<table class=""table"">
    <thead>
        <tr>
            <th>
                Mã sách
            </th>
            <th>
                Lần tái bản
            </th>
            <th>
                Tên sách
            </th>
            <th>
                Loại sách
            </th>
            <th>
                NXB
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
#line 103 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
         foreach (var item in Model.gioHang)
        {
            var x = @item.sach.giaBan * @item.soLuong;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n            <td>\r\n                ");
#nullable restore
#line 108 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
           Write(item.sach.idSach);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 111 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
           Write(item.sach.lanTaiBan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
           Write(item.sach.ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 117 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                 foreach (var loaiSach in item.tapHopLoaiSach)
                {
                    if (item.sach.maLoai == loaiSach.idLoai)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                   Write(loaiSach.tenLoai);

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                                         
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 126 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                 foreach (var NXB in item.danhSachNXB)
                {
                    if (item.sach.idNhaXuatBan == NXB.idNhaXuatBan)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                   Write(NXB.ten);

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                                
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 135 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
           Write(item.soLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 138 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
           Write(item.sach.giaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 141 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
              Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</p>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 144 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr />\r\n<h2>Cập nhập đơn hàng</h2>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974945083130574ef401374703a91490a3828d1714702", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"idDonHang\"");
                BeginWriteAttribute("value", " value=\"", 4079, "\"", 4111, 1);
#nullable restore
#line 151 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
WriteAttributeValue("", 4087, Model.donHang.idDonHang, 4087, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <div class=\"row\">\r\n            <div class=\"form-group m-1\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974945083130574ef401374703a91490a3828d1715510", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 154 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.donHang.thoiGianGiaoHangDuKien);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input name=\"thoiGianGiaoHangDuKien\"");
                BeginWriteAttribute("value", " value=\"", 4341, "\"", 4386, 1);
#nullable restore
#line 155 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
WriteAttributeValue("", 4349, Model.donHang.thoiGianGiaoHangDuKien, 4349, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n            </div>\r\n            <div class=\"form-group m-1\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974945083130574ef401374703a91490a3828d1717703", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 158 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.donHang.phiGiaoHang);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input name=\"phiGiaoHang\"");
                BeginWriteAttribute("value", " value=\"", 4608, "\"", 4642, 1);
#nullable restore
#line 159 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
WriteAttributeValue("", 4616, Model.donHang.phiGiaoHang, 4616, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n            </div>\r\n            <div class=\"form-group m-1\">\r\n                <label class=\"control-label\">Trạng thái</label>\r\n                <select class=\"form-control\" name=\"idTrangThai\">\r\n");
#nullable restore
#line 164 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                     foreach (var trangThai in cacTrangThai)
                    {
                        intTrangThai++;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                         if (Model.trangThaiDonhang == trangThai)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974945083130574ef401374703a91490a3828d1720641", async() => {
#nullable restore
#line 169 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                                                              Write(trangThai);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 169 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                               WriteLiteral(intTrangThai);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 170 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974945083130574ef401374703a91490a3828d1723196", async() => {
#nullable restore
#line 173 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                                                     Write(trangThai);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 173 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                               WriteLiteral(intTrangThai);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 174 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974945083130574ef401374703a91490a3828d1725601", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 177 "C:\Users\user\source\repos\WebsiteBanSach\WebsiteBanSach\Views\DonHang\XuLyDonHang.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.trangThaiDonhang);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\" style=\"margin-right:5px;\">\r\n            <input type=\"submit\" value=\"Cập nhập\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBanSach.Models.ViewModel.DonHangVaTrangThai> Html { get; private set; }
    }
}
#pragma warning restore 1591
