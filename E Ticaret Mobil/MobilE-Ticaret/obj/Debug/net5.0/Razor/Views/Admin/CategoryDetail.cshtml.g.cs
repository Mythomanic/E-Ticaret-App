#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24ff849986df2055e49243182d80a66a9898a749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryDetail), @"mvc.1.0.view", @"/Views/Admin/CategoryDetail.cshtml")]
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
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ff849986df2055e49243182d80a66a9898a749", @"/Views/Admin/CategoryDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0104cefbdf8288a87465c6c63b90535b2159260c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CategoryDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
  
    ViewData["Title"] = "CategoryDetail";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <br />\r\n    <h1> ");
#nullable restore
#line 10 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
    Write(ViewBag.ctg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Detay</h1>\r\n    <hr />\r\n    <br />\r\n\r\n\r\n\r\n\r\n    <div class=\"container mt-3\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 19 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"card\" style=\"width:300px;height:400px;margin-left:60px;\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 548, "\"", 568, 1);
#nullable restore
#line 23 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
WriteAttributeValue("", 554, item.ImageUrl, 554, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Card image"" height=""300"" style=""width:100%;height:300px;"">
                        <div class=""card-body"">

                            <div class=""mb-3"">
                                <h6 class=""card-title ml-3"" style=""color:darkslateblue;margin-left:22px;""><p style=""display:inline;color:black;"">Ürün Adı: </p>");
#nullable restore
#line 27 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
                                                                                                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 style=\"color:darkslateblue;margin-left:27px;\">\r\n                                    <p style=\"display:inline;color:black;\">Kategori:</p>\r\n                                    ");
#nullable restore
#line 30 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
                               Write(ViewBag.ctg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h6>\r\n\r\n                                    <h6 style=\"color:darkslateblue;margin-left:27px;\">\r\n                                    <p style=\"display:inline;color:black;\">Fiyat:</p>\r\n                                    ");
#nullable restore
#line 35 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\r\n                                </h6>\r\n                            </div>\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1509, "\"", 1545, 2);
            WriteAttributeValue("", 1516, "/admin/ProductDetail/", 1516, 21, true);
#nullable restore
#line 39 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
WriteAttributeValue("", 1537, item.Id, 1537, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\" style=\"margin-left:20px;\">Detay</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1635, "\"", 1671, 2);
            WriteAttributeValue("", 1642, "/admin/UpdateProduct/", 1642, 21, true);
#nullable restore
#line 40 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
WriteAttributeValue("", 1663, item.Id, 1663, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"margin-left:7px;\">Düzenle</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1765, "\"", 1801, 2);
            WriteAttributeValue("", 1772, "/admin/DeleteProduct/", 1772, 21, true);
#nullable restore
#line 41 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
WriteAttributeValue("", 1793, item.Id, 1793, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger \" style=\"margin-left:7px;\">Kaldır</a>\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                    <br>\r\n                </div>\r\n");
#nullable restore
#line 48 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Mobil E Ticaret\MobilE-Ticaret\Views\Admin\CategoryDetail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591