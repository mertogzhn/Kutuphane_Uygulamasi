#pragma checksum "C:\Users\merto\Desktop\kutuphane24\Views\Odunc\OduncVer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a899f941f7f5f79571c5ee48b1ba0ae062dac7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Odunc_OduncVer), @"mvc.1.0.view", @"/Views/Odunc/OduncVer.cshtml")]
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
#line 1 "C:\Users\merto\Desktop\kutuphane24\Views\_ViewImports.cshtml"
using kutuphane24;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merto\Desktop\kutuphane24\Views\_ViewImports.cshtml"
using kutuphane24.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a899f941f7f5f79571c5ee48b1ba0ae062dac7", @"/Views/Odunc/OduncVer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"870c849239048ac1bf792cbce873f735fec70289", @"/Views/_ViewImports.cshtml")]
    public class Views_Odunc_OduncVer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kutuphane24.Models.TblHareket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\merto\Desktop\kutuphane24\Views\Odunc\OduncVer.cshtml"
  
    ViewData["Title"] = "OduncVer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ödünç Ver</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60a899f941f7f5f79571c5ee48b1ba0ae062dac74135", async() => {
                WriteLiteral("\r\n    <div></div>\r\n    <div style=\"margin-top:15 px\">\r\n        <label>Üye ID</label>\r\n        ");
#nullable restore
#line 14 "C:\Users\merto\Desktop\kutuphane24\Views\Odunc\OduncVer.cshtml"
   Write(Html.TextBoxFor(k => k.Uye, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div style=\"margin-top:15 px\">\r\n        <label>Kitap ID</label>\r\n        ");
#nullable restore
#line 18 "C:\Users\merto\Desktop\kutuphane24\Views\Odunc\OduncVer.cshtml"
   Write(Html.TextBoxFor(k => k.Kitap, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div style=\"margin-top:15 px\">\r\n        <label>Personel ID</label>\r\n        ");
#nullable restore
#line 22 "C:\Users\merto\Desktop\kutuphane24\Views\Odunc\OduncVer.cshtml"
   Write(Html.TextBoxFor(k => k.Personel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div style=\"margin-top:15 px\">\r\n        <label>Kitap Alış Tarihi</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"AlısTarih\"");
                BeginWriteAttribute("value", " value=\"", 819, "\"", 860, 1);
#nullable restore
#line 26 "C:\Users\merto\Desktop\kutuphane24\Views\Odunc\OduncVer.cshtml"
WriteAttributeValue("", 827, DateTime.Now.ToShortDateString(), 827, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div style=\"margin-top:15 px\">\r\n        <label>Kitap İade Tarihi</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"İadeTarih\"");
                BeginWriteAttribute("value", " value=\"", 1020, "\"", 1073, 1);
#nullable restore
#line 30 "C:\Users\merto\Desktop\kutuphane24\Views\Odunc\OduncVer.cshtml"
WriteAttributeValue("", 1028, DateTime.Now.AddDays(14).ToShortDateString(), 1028, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n\r\n\r\n    <div style=\"margin-top:15px\">\r\n        <button class=\"btn btn-group\" style=\"background-color:#b200ff; color:#ffffff\">Kitabı Ödünç Ver</button>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kutuphane24.Models.TblHareket> Html { get; private set; }
    }
}
#pragma warning restore 1591