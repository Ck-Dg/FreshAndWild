#pragma checksum "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33d6d2dd98e2c5faa07722623e91a23c6c0c8ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producteur_Index), @"mvc.1.0.view", @"/Views/Producteur/Index.cshtml")]
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
#line 1 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/_ViewImports.cshtml"
using FreshAndWild2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/_ViewImports.cshtml"
using FreshAndWild2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33d6d2dd98e2c5faa07722623e91a23c6c0c8ec", @"/Views/Producteur/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da1db42d014440f77495140b840a4d83478148d", @"/Views/_ViewImports.cshtml")]
    public class Views_Producteur_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
   ViewBag.Title = "Index";
    Layout = "_LayoutDuSite"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    img {
        object-fit: cover;
    }
</style>

<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">
        <div class=""d-flex justify-content-between align-items-center"">
            <h2>Nos Producteurs</h2>
            <ol>
                <li><a href=""/Home/Index"">Accueil</a></li>
                <li>Producteurs</li>
            </ol>
        </div>
    </div>
</section>

<section id=""producteurs"" class=""producteurs"">
    <div class=""container"">

        <div class=""section-title"">
            <h2>Origine de nos produits</h2>
            <p>
                Ils s'engagent pour une agriculture durable et respectueuse de l'environnement et de notre santé à tous.<br />
                Les producteurs partenaires de Fresh & Wild se mobilisent au quotidien pour vous proposer une large gamme de produits de qualité
                et cultivés avec soin.<br />
                Voici nos super producteurs !
            </p>
        </div>



    ");
            WriteLiteral("    <div class=\"row justify-content-center\">\r\n\r\n");
#nullable restore
#line 39 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
             foreach (var producteur in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n\r\n        <div class=\"product-grid\">\r\n            <div class=\"product-image\">\r\n                <a class=\"image\">\r\n");
#nullable restore
#line 46 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
                       var ip = "~/img/Producteurs/prod" + producteur.Id + ".jpeg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 1485, "\"", 1507, 1);
#nullable restore
#line 47 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
WriteAttributeValue("", 1491, Url.Content(ip), 1491, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </div>\r\n            <div class=\"product-content\">\r\n                <h4><a>");
#nullable restore
#line 51 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
                  Write(producteur.NomFerme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                <p><a>");
#nullable restore
#line 52 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
                 Write(producteur.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n\r\n\r\n");
#nullable restore
#line 55 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
                   var dp = "/Producteur/NomFerme/" + producteur.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>");
#nullable restore
#line 59 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Producteur/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
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