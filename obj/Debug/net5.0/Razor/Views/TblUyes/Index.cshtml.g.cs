#pragma checksum "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9020ce89c97f09458b84716a4041908fba2d2796"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TblUyes_Index), @"mvc.1.0.view", @"/Views/TblUyes/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9020ce89c97f09458b84716a4041908fba2d2796", @"/Views/TblUyes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"870c849239048ac1bf792cbce873f735fec70289", @"/Views/_ViewImports.cshtml")]
    public class Views_TblUyes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<kutuphane24.Models.TblUye>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Üyeler</h2>

<table class=""table table-borderless"">
    <tr>
        <th>Üye Id</th>
        <th>Üye Adı</th>
        <th>Üye Soyadı</th>
        <th>Mail</th>
        <th>Kullanıcı Adı</th>
        <th>Şifre</th>
        <th>Telefon</th>
        <th>Okul</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 25 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
     foreach (var uye in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.UyeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.KullaniciAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.Sifre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
           Write(uye.Okul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 858, "\"", 891, 2);
            WriteAttributeValue("", 865, "/TblUyes/UyeSil/", 865, 16, true);
#nullable restore
#line 36 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
WriteAttributeValue("", 881, uye.UyeId, 881, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 948, "\"", 983, 2);
            WriteAttributeValue("", 955, "/TblUyes/UyeGetir/", 955, 18, true);
#nullable restore
#line 37 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
WriteAttributeValue("", 973, uye.UyeId, 973, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\merto\Desktop\kutuphane24\Views\TblUyes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n<a href=\"/TblUyes/UyeEkle\" class=\"btn btn-primary\">Yeni Üye Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<kutuphane24.Models.TblUye>> Html { get; private set; }
    }
}
#pragma warning restore 1591
