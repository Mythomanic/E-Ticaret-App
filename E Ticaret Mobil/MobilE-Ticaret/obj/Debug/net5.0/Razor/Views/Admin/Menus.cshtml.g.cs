#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8ecafe97acab3dfe7a2379e36f224fad55cdc8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Menus), @"mvc.1.0.view", @"/Views/Admin/Menus.cshtml")]
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
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\_ViewImports.cshtml"
using MobilE_Ticaret;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\_ViewImports.cshtml"
using MobilE_Ticaret.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ecafe97acab3dfe7a2379e36f224fad55cdc8c", @"/Views/Admin/Menus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0104cefbdf8288a87465c6c63b90535b2159260c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Menus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List< Gender>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
  
    ViewData["Title"] = "Menus";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class="" container col-md-11"">
    <br />
    <h3>MENÜ</h3>
    <hr />
    <br />



    <table class="" container col-md-12 table table-bordered table-striped table-hover table-dark"">
        <thead>
            <tr>
                
                <th>Name</th>
                <th>Detay</th>
                <th>Düzenle</th>
                <th>Sil</th>

            </tr>
        </thead>

        <tbody>


");
#nullable restore
#line 30 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  \r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 775, 2);
            WriteAttributeValue("", 748, "/admin/menudetails/", 748, 19, true);
#nullable restore
#line 35 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
WriteAttributeValue("", 767, item.Id, 767, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" >Detay</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 877, 2);
            WriteAttributeValue("", 851, "/admin/updatemenu/", 851, 18, true);
#nullable restore
#line 36 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
WriteAttributeValue("", 869, item.Id, 869, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 945, "\"", 978, 2);
            WriteAttributeValue("", 952, "/admin/DeleteMenu/", 952, 18, true);
#nullable restore
#line 37 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
WriteAttributeValue("", 970, item.Id, 970, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\Menus.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n    <a class=\"btn btn-primary\" href=\"/admin/AddMenu\">Menü Ekle</a>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List< Gender>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591