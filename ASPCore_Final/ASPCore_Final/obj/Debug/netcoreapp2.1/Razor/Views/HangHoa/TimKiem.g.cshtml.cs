#pragma checksum "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5123276bc5c796eef2621fd9e75f995c5e12308"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangHoa_TimKiem), @"mvc.1.0.view", @"/Views/HangHoa/TimKiem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HangHoa/TimKiem.cshtml", typeof(AspNetCore.Views_HangHoa_TimKiem))]
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
#line 1 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5123276bc5c796eef2621fd9e75f995c5e12308", @"/Views/HangHoa/TimKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae0022d08f620143d968fa9654a9b9c381b59a0", @"/Views/_ViewImports.cshtml")]
    public class Views_HangHoa_TimKiem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPCore_Final.Models.HangHoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTiet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
  
    Layout = "";

#line default
#line hidden
#line 5 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(103, 38, true);
            WriteLiteral("    <h5 style=\"color:aquamarine\">Có (");
            EndContext();
            BeginContext(142, 13, false);
#line 7 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
                                 Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(155, 30, true);
            WriteLiteral(") kết quả tìm thấy:</h5>\r\n");
            EndContext();
#line 8 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(197, 53, true);
            WriteLiteral("    <h5 style=\"color:aquamarine\" class=\"hidden\">Có (");
            EndContext();
            BeginContext(251, 13, false);
#line 11 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
                                                Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(264, 30, true);
            WriteLiteral(") kết quả tìm thấy:</h5>\r\n");
            EndContext();
#line 12 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
}

#line default
#line hidden
            BeginContext(297, 26, true);
            WriteLiteral("<br />\r\n<ul type=\"none\">\r\n");
            EndContext();
#line 15 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
     if (Model != null)
    {
        foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(405, 96, true);
            WriteLiteral("            <li style=\"margin:10px;font-family:\'Segoe UI\', Tahoma, Geneva, Verdana, sans-serif\">");
            EndContext();
            BeginContext(501, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "659ef9f4ee684368bf653865fb01b100", async() => {
                BeginContext(578, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8be90b2998c04a4cb8d945bbe3fb2c0a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 588, "~/HangHoa/", 588, 10, true);
#line 20 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
AddHtmlAttributeValue("", 598, item.Hinh, 598, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(644, 6, true);
                WriteLiteral("<span>");
                EndContext();
                BeginContext(651, 10, false);
#line 20 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
                                                                                                                                                                                                                                                Write(item.TenHh);

#line default
#line hidden
                EndContext();
                BeginContext(661, 7, true);
                WriteLiteral("</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahh", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
                                                                                                                                                     WriteLiteral(item.MaHh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahh", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(672, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 21 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\HangHoa\TimKiem.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(697, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPCore_Final.Models.HangHoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591