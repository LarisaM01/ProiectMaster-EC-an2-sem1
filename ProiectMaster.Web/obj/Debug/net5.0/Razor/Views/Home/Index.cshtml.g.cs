#pragma checksum "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b14f5fb7b3b8687a2de80879d94e47acbb43cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Models.DTOs.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b14f5fb7b3b8687a2de80879d94e47acbb43cd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be194870830f42a069c9ea434231893299df8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("no image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page";
                var detailsRoute = "/Details/{0}"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Slideshow container -->
<div class=""slideshow-container"">

    <!-- Full-width images with number and caption text -->
    <div class=""mySlides fade"">
        <div class=""numbertext"">1 / 3</div>
        <img src=""img\img4.png"" style=""width:100"">
        <div class=""text"">Caption Text</div>
    </div>

    <div class=""mySlides fade"">
        <div class=""numbertext"">2 / 3</div>
        <img src=""img\img5.png"" style=""width:100"">
        <div class=""text"">Caption Two</div>
    </div>

    <div class=""mySlides fade"">
        <div class=""numbertext"">3 / 3</div>
        <img src=""img\img7.png"" style=""width:100"">
        <div class=""text"">Caption Three</div>
    </div>

    <!-- Next and previous buttons -->
    <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
    <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>
</div>
<br>

<!-- The dots/circles -->
<div style=""text-align:center"">
    <span class=""dot"" onclick=""currentSlide(1)""></span>
    <span class=""dot"" onclick=""currentSlide(2)""></span>
    <spa");
            WriteLiteral("n class=\"dot\" onclick=\"currentSlide(3)\"></span>\n</div>\n\n\n<div class=\"row\">\n\n");
#nullable restore
#line 46 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-4\">\n    <div class=\"card mb-4\">\n\n        <div class=\"card-header\">\n            <h4 class=\"my-0 font-weight-normal\">\n                <label style=\"font-size: 23px; color: #006400;\">");
#nullable restore
#line 53 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n            </h4>\n        </div>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7b14f5fb7b3b8687a2de80879d94e47acbb43cd7299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1573, "~/", 1573, 2, true);
#nullable restore
#line 57 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1575, product.ImagePath, 1575, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        <div class=\"card-body\">\n            <div class=\"d-flex justify-content-between align-items-center\">\n                <div class=\"btn-group\">\n                    <label style=\"font-size: 20px; color: #006400 \"><b>$");
#nullable restore
#line 62 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml"
                                                                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\n                </div>\n                <a");
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1949, 1);
#nullable restore
#line 64 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1909, string.Format(detailsRoute, product.Id), 1909, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn pull-right btn-outline-info\">View Details</a>\n            </div>\n        </div>\n\n    </div>\n</div>");
#nullable restore
#line 69 "F:\E commerce\MasterAfaceriElectronice-main\LARISA_incearca_marea_cu_sarea\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591