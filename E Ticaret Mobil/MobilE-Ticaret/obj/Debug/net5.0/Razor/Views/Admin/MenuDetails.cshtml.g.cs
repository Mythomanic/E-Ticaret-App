#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73745b2d82adad09363a11626c66609d452dab6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MenuDetails), @"mvc.1.0.view", @"/Views/Admin/MenuDetails.cshtml")]
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
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73745b2d82adad09363a11626c66609d452dab6b", @"/Views/Admin/MenuDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0104cefbdf8288a87465c6c63b90535b2159260c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_MenuDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
  
    ViewData["Title"] = "MenuDetails";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <br />\r\n    <h1> ");
#nullable restore
#line 10 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
    Write(ViewBag.menu);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Detay</h1>\r\n    <hr />\r\n    <br />\r\n\r\n\r\n\r\n\r\n    <div class=\"container mt-3\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 19 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"card\" style=\"width:300px;height:400px;margin-left:60px;\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 547, "\"", 567, 1);
#nullable restore
#line 23 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
WriteAttributeValue("", 553, item.ImageUrl, 553, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Card image"" height=""300"" style=""width:100%;height:300px;"">
                        <div class=""card-body"">

                            <div class=""mb-3"">
                                <h6 class=""card-title ml-3"" style=""color:darkslateblue;margin-left:22px;""><p style=""display:inline;color:black;"">Ürün Adı: </p>");
#nullable restore
#line 27 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
                                                                                                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 style=\"color:darkslateblue;margin-left:27px;\">\r\n                                    <p style=\"display:inline;color:black;\">Kategori:</p>\r\n                                    ");
#nullable restore
#line 30 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
                               Write(ViewBag.menu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h6>\r\n                               \r\n\r\n                            </div>\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1276, "\"", 1313, 2);
            WriteAttributeValue("", 1283, "/admin/CategoryDetail/", 1283, 22, true);
#nullable restore
#line 36 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
WriteAttributeValue("", 1305, item.Id, 1305, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\" style=\"margin-left:20px;\">Detay</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1403, "\"", 1442, 2);
            WriteAttributeValue("", 1410, "/admin/UpdateCategories/", 1410, 24, true);
#nullable restore
#line 37 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
WriteAttributeValue("", 1434, item.Id, 1434, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"margin-left:7px;\">Düzenle</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1536, "\"", 1573, 2);
            WriteAttributeValue("", 1543, "/admin/DeleteCategory/", 1543, 22, true);
#nullable restore
#line 38 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
WriteAttributeValue("", 1565, item.Id, 1565, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger \" style=\"margin-left:7px;\">Kaldır</a>\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                    <br>\r\n                </div>\r\n");
#nullable restore
#line 45 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\MenuDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
