#pragma checksum "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c927b277bc042580e195628ebaed80637f051c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TblKategoris_KategoriGetir), @"mvc.1.0.view", @"/Views/TblKategoris/KategoriGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c927b277bc042580e195628ebaed80637f051c", @"/Views/TblKategoris/KategoriGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"870c849239048ac1bf792cbce873f735fec70289", @"/Views/_ViewImports.cshtml")]
    public class Views_TblKategoris_KategoriGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kutuphane24.Models.TblKategori>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml"
  
    ViewData["Title"] = "KategoriGetir";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Kategori Güncelle</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml"
 using (Html.BeginForm("KategoriGuncelle", "TblKategoris", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"margin-bottom:15px\"></div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml"
   Write(Html.LabelFor(k => k.KategoriId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml"
   Write(Html.TextBoxFor(k => k.KategoriId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 18 "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml"
   Write(Html.LabelFor(k => k.KategoriAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml"
   Write(Html.TextBoxFor(k => k.KategoriAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n    </div>\r\n    <div>\r\n        <button class=\"btn btn-warning\">Güncelle</button>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\merto\Desktop\kutuphane24\Views\TblKategoris\KategoriGetir.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kutuphane24.Models.TblKategori> Html { get; private set; }
    }
}
#pragma warning restore 1591
