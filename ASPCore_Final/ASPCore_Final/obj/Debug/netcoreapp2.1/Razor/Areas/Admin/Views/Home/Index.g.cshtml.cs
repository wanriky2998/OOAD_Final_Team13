#pragma checksum "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a886abdefd0ea0347e354e05353b3e9c4083548f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Index))]
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
#line 1 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a886abdefd0ea0347e354e05353b3e9c4083548f", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "/admin/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Info", async() => {
                BeginContext(120, 1751, true);
                WriteLiteral(@"
    <li class=""nav-item dropdown"">
        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown2"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true""
           aria-expanded=""false"">
            <i class=""far fa-user""></i>
        </a>
        <div class=""dropdown-menu drop-3"">
            <div class=""profile d-flex mr-o"">
                <div class=""profile-l align-self-center"">
                    <img src=""images/profile.jpg"" class=""img-fluid mb-3"" alt=""Responsive image"">
                </div>
                <div class=""profile-r align-self-center"">
                    <h3 class=""sub-title-w3-agileits"">Will Smith</h3>
                    <a href=""mailto:info@example.com"">info@example.com</a>
                </div>
            </div>
            <a href=""#"" class=""dropdown-item mt-3"">
                <h4>
                    <i class=""far fa-user mr-3""></i>My Profile
                </h4>
            </a>
            <a href=""#"" class=""dropdown-item mt-3"">
        ");
                WriteLiteral(@"        <h4>
                    <i class=""fas fa-link mr-3""></i>Activity
                </h4>
            </a>
            <a href=""#"" class=""dropdown-item mt-3"">
                <h4>
                    <i class=""far fa-envelope mr-3""></i>Messages
                </h4>
            </a>
            <a href=""#"" class=""dropdown-item mt-3"">
                <h4>
                    <i class=""far fa-question-circle mr-3""></i>Faq
                </h4>
            </a>
            <a href=""#"" class=""dropdown-item mt-3"">
                <h4>
                    <i class=""far fa-thumbs-up mr-3""></i>Support
                </h4>
            </a>
            <div class=""dropdown-divider""></div>
            ");
                EndContext();
                BeginContext(1871, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9dfde64e71f4f1c997b7b158507c587", async() => {
                    BeginContext(1946, 6, true);
                    WriteLiteral("Logout");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1956, 29, true);
                WriteLiteral("\r\n        </div>\r\n    </li>\r\n");
                EndContext();
            }
            );
            BeginContext(1988, 1531, true);
            WriteLiteral(@"<!-- main-heading -->
<h2 class=""main-title-w3layouts mb-2 text-center"">Blank page</h2>
<!--// main-heading -->
<!-- Error Page Content -->
<div class=""blank-page-content"">

    <!-- Error Page Info -->
    <div class=""outer-w3-agile mt-3"">
        <p class=""paragraph-agileits-w3layouts"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent mollis augue venenatis, laoreet magna
            sed, bibendum ligula. Cras eget ultricies leo. Aenean elementum semper commodo. Sed quis vehicula
            sapien. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur placerat massa at dolor
            faucibus, vitae molestie lorem cursus. Integer vulputate pretium urna, at mattis nibh convallis sed.
            Mauris suscipit dictum nulla, vel suscipit urna volutpat eu. Nunc interdum a sapien et sodales. Donec
            et turpis quis eros convallis finibus in non sem. Suspendisse semper dui quis pellentesque porta.
            Sed sodales risus sit amet libero");
            WriteLiteral(@" vestibulum congue. Integer pulvinar nunc at dui ultrices, vel ultrices
            nunc scelerisque. Nam facilisis ipsum sed hendrerit aliquet.
        </p>
    </div>
    <!--// Error Page Info -->

</div>

<!--// Error Page Content -->
<!-- Copyright -->
<div class=""copyright-w3layouts py-xl-3 py-2 mt-xl-5 mt-4 text-center"">
    <p>
        © 2018 Modernize . All Rights Reserved | Design by
        <a href=""http://w3layouts.com/""> W3layouts </a>
    </p>
</div>
<!--// Copyright -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591