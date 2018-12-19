#pragma checksum "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61cf4700536e0c6efdf8c91a5025fbed865cf200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PhieuNhapHang_ChitietPhieuHang), @"mvc.1.0.view", @"/Areas/Admin/Views/PhieuNhapHang/ChitietPhieuHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/PhieuNhapHang/ChitietPhieuHang.cshtml", typeof(AspNetCore.Areas_Admin_Views_PhieuNhapHang_ChitietPhieuHang))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61cf4700536e0c6efdf8c91a5025fbed865cf200", @"/Areas/Admin/Views/PhieuNhapHang/ChitietPhieuHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PhieuNhapHang_ChitietPhieuHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPCore_Final.Models.ChiTietPhieuNhap>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
  
    ViewData["Title"] = "ChitietPhieuHang";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 529, true);
            WriteLiteral(@"
<h2>Chi tiết phiếu hàng</h2>
<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:lightblue;color:white;"">
            <th>
               Mã phiếu nhập
            </th>
            <th>
                Kích cỡ
            </th>
            <th>
               Đơn giá nhập
            </th>
            <th>
                Số lượng nhập
            </th>
            <th>
                Tổng tiền
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(733, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(782, 39, false);
#line 33 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaHh));

#line default
#line hidden
            EndContext();
            BeginContext(821, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(877, 41, false);
#line 36 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
           Write(Html.DisplayFor(modelItem => item.KichCo));

#line default
#line hidden
            EndContext();
            BeginContext(918, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(974, 51, false);
#line 39 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
           Write(Convert.ToDouble(item.DonGiaNhap).ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1081, 46, false);
#line 42 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoLuongNhap));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 45 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
                  
                    double tien = Convert.ToDouble(item.DonGiaNhap * item.SoLuongNhap);
                 

#line default
#line hidden
            BeginContext(1295, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1312, 22, false);
#line 48 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
           Write(tien.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\ChitietPhieuHang.cshtml"
}

#line default
#line hidden
            BeginContext(1373, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPCore_Final.Models.ChiTietPhieuNhap>> Html { get; private set; }
    }
}
#pragma warning restore 1591