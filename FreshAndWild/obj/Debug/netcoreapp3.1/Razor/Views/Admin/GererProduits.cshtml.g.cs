#pragma checksum "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b77bc5f70a33f84c025cc05fe42fd53d356f4085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GererProduits), @"mvc.1.0.view", @"/Views/Admin/GererProduits.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77bc5f70a33f84c025cc05fe42fd53d356f4085", @"/Views/Admin/GererProduits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da1db42d014440f77495140b840a4d83478148d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GererProduits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FreshAndWild2.Models.Produit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
   Layout = "_LayoutAdmin";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <div class=""d-flex justify-content-between align-items-center"">
            <h2>Gestion de la boutique </h2>
            <ol>
                <li><a href=""index.html"">home</a></li>
                <li>Liste de produits</li>
            </ol>
        </div>
    </div>
</section>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nom</th>
            <th scope=""col"">Producteur</th>
            <th scope=""col"">prix</th>
            <th scope=""col"">Conditionnements</th>
            <th scope=""col"">Stock</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Photo</th>



        </tr>
    </thead>
    <tbody>


");
#nullable restore
#line 36 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
         foreach (var produit in Model)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>");
#nullable restore
#line 41 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(produit.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 42 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(produit.Producteur);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 43 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(produit.Prix);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 44 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(produit.Conditionnement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 45 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(produit.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 46 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(produit.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 47 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(produit.Photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n\n\n\n\n                <td>\n\n\n                    ");
#nullable restore
#line 57 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(Html.ActionLink("Modifier", "UpdateProduit", "Admin", new { @id = produit.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 58 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
               Write(Html.ActionLink("Supprimer", "DeleteProduit", "Admin", new { @id = produit.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n                </td>\n            </tr>\n");
#nullable restore
#line 64 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    </tbody>\n\n\n</table>\n\n");
#nullable restore
#line 73 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Admin/GererProduits.cshtml"
Write(Html.ActionLink("Ajouter Un produit", "CreerProduit", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n\n<div />\n<section />\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FreshAndWild2.Models.Produit>> Html { get; private set; }
    }
}
#pragma warning restore 1591