#pragma checksum "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c19ef1c39bca8526d0e029d276c4758aaa540c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activite_EditActivity), @"mvc.1.0.view", @"/Views/Activite/EditActivity.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c19ef1c39bca8526d0e029d276c4758aaa540c9", @"/Views/Activite/EditActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da1db42d014440f77495140b840a4d83478148d", @"/Views/_ViewImports.cshtml")]
    public class Views_Activite_EditActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreshAndWild2.Models.Activite>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate-vsdoc.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Layout = "_LayoutDuSite";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">
        <div class=""d-flex justify-content-between align-items-center"">
            <h2>Modifier Activit??</h2>

        </div>
    </div>
</section>

<h2>Modifier une Activite </h2>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c19ef1c39bca8526d0e029d276c4758aaa540c95849", async() => {
                WriteLiteral("\n    <div>\n\n        ");
#nullable restore
#line 20 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.LabelFor(m => Model.titre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 21 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.TextBoxFor(m => Model.titre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 22 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.ValidationMessageFor(m => Model.titre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        <br />\n        <br />\n        ");
#nullable restore
#line 26 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.LabelFor(m => Model.Lieu));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 27 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.TextBoxFor(m => Model.Lieu));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 28 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.ValidationMessageFor(m => Model.Lieu));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <br />\n        ");
#nullable restore
#line 31 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.LabelFor(m => Model.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 32 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.TextBoxFor(m => Model.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 33 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.ValidationMessageFor(m => Model.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <br />\n        ");
#nullable restore
#line 36 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.LabelFor(m => Model.NbreParticipant));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 37 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.TextBoxFor(m => Model.NbreParticipant));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 38 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.ValidationMessageFor(m => Model.NbreParticipant));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <br />\n        ");
#nullable restore
#line 41 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.LabelFor(m => Model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 42 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.TextBoxFor(m => Model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 43 "/Users/ckdieng/OneDrive MacbookPro/OneDrive/Isika/IsikaWork/PROJET2/Fresh_and_Wild_V3 7/FreshAndWild2/Views/Activite/EditActivity.cshtml"
   Write(Html.ValidationMessageFor(m => Model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n        <input type=\"submit\" value=\"Modifier\" />\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c19ef1c39bca8526d0e029d276c4758aaa540c912162", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c19ef1c39bca8526d0e029d276c4758aaa540c913190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c19ef1c39bca8526d0e029d276c4758aaa540c914218", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreshAndWild2.Models.Activite> Html { get; private set; }
    }
}
#pragma warning restore 1591
