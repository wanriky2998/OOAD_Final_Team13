#pragma checksum "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80dd61488240f60d2727ce78fe5ebd0f208f505b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhanViens_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NhanViens/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NhanViens/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_NhanViens_Index))]
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
#line 2 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80dd61488240f60d2727ce78fe5ebd0f208f505b", @"/Areas/Admin/Views/NhanViens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NhanViens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.NhanVien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(249, 113, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"outer-w3-agile mt-3\">\r\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách nhân viên</h4>\r\n    ");
            EndContext();
            BeginContext(362, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdffb66884a64d268a537d3266bc44de", async() => {
                BeginContext(401, 81, true);
                WriteLiteral("\r\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 482, "\"", 539, 1);
#line 16 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
WriteAttributeValue("", 506, Model.RouteValue["searchString"], 506, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(540, 169, true);
                WriteLiteral(" />\r\n        <button type=\"submit\" class=\"btn btn-info\">\r\n            <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span> Search\r\n        </button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(716, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(735, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcf930a7c4c949748299df31343ab654", async() => {
                BeginContext(782, 7, true);
                WriteLiteral("Tạo mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(793, 148, true);
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(942, 40, false);
#line 31 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(982, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1062, 41, false);
#line 34 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1183, 41, false);
#line 37 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 96, true);
            WriteLiteral("\r\n                </th>\r\n               \r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1321, 47, false);
#line 41 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1448, 50, false);
#line 44 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaPqNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1661, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1680, "\"", 1716, 4);
            WriteAttributeValue("", 1690, "_delete(", 1690, 8, true);
#line 52 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
WriteAttributeValue("", 1698, item.MaNv, 1698, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1708, ",", 1708, 1, true);
            WriteAttributeValue(" ", 1709, "event)", 1710, 7, true);
            EndWriteAttribute();
            BeginContext(1717, 65, true);
            WriteLiteral(">\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1783, 39, false);
#line 54 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1914, 40, false);
#line 57 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2046, 40, false);
#line 60 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 112, true);
            WriteLiteral("\r\n                    </td>\r\n                   \r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2198, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d35fb10d99fd415aae770798a43cda24", async() => {
                BeginContext(2272, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2274, 70, false);
#line 64 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                                                                                              Write(Html.Raw(item.TrangThaiHd == true ? "<strong>True</strong>" : "False"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                                                       WriteLiteral(item.MaNv);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2348, 92, true);
            WriteLiteral(" \r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2441, 54, false);
#line 67 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaPqNavigation.MaPq));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2586, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d57b4acb0b54270a7d7db0c3f3a8d34", async() => {
                BeginContext(2657, 3, true);
                WriteLiteral("Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                                               WriteLiteral(item.MaNv);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2664, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2692, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3280a8ecfa1e488a9bf3ad99ac5a282c", async() => {
                BeginContext(2766, 12, true);
                WriteLiteral("Xem chi tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                                                  WriteLiteral(item.MaNv);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2782, 151, true);
            WriteLiteral(" |\r\n\r\n                        <button type=\"button\" class=\"btn btn-primary btn-delete\">Xóa</button>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 76 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2948, 1139, true);
            WriteLiteral(@"        </tbody>

    </table>
    <script>
        function _delete(id, ev) {
            if (ev.target.className == 'btn btn-primary btn-delete') {
                console.log(ev.target);
                console.log(ev.currentTarget);
                var cf = confirm('Bạn có muốn xoá nhân viên ID: ' + id + '?');
                if (cf) {
                    $(ev.currentTarget).fadeOut();
                    $.ajax({
                        url: '/api/NhanViens/' + id,
                        type: ""Delete"",
                        contentType: ""application/json; charset=utf-8"",
                        dataType: ""json"",
                        async: true,
                        success: function (result) {
                            alert(""Xoá nhân viên thành công"");
                        },
                        error: function (errormessage) {
                            alert(errormessage.responseText);
                        }
                    });
                }
   ");
            WriteLiteral("         }\r\n        }\r\n    </script>\r\n    <nav class=\"navbar-default justify-content-center\"  >\r\n   \r\n\r\n           ");
            EndContext();
            BeginContext(4088, 135, false);
#line 108 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
      Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(4223, 55, true);
            WriteLiteral("\r\n                   \r\n      \r\n    </nav>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.NhanVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
