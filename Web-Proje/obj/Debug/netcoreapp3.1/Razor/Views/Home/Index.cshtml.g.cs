#pragma checksum "C:\Users\tarik\source\repos\Web-Proje\Web-Proje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7324e9b7510de01e7af6f9e008eb7837abcf778"
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
#line 1 "C:\Users\tarik\source\repos\Web-Proje\Web-Proje\Views\_ViewImports.cshtml"
using Web_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tarik\source\repos\Web-Proje\Web-Proje\Views\_ViewImports.cshtml"
using Web_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7324e9b7510de01e7af6f9e008eb7837abcf778", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90cb41c646612bfa2e66c7a7807bfaad0b2199e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("book-picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pictures/books.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-tg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tarik\source\repos\Web-Proje\Web-Proje\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"position-relative\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7324e9b7510de01e7af6f9e008eb7837abcf7785387", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""beyaz centered"">KİTAPLARIN DÜNYASI</div> 
</div>

<br />
<br />
<hr />
<div class=""container-fluid bg-3 text-center"">
    <h3>Son Eklenen Kitaplar</h3><br>
    <div class=""row"">
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
    </div>
</div>
<br>
");
            WriteLiteral(@"
<div class=""container-fluid bg-3 text-center"">
    <div class=""row"">
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7324e9b7510de01e7af6f9e008eb7837abcf7788527", async() => {
                WriteLiteral("Tümünü Görüntüle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br>
<br>
<hr />
<div class=""container-fluid bg-3 text-center"">
    <h3>En Beğenilen Kitaplar</h3><br>
    <div class=""row"">
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
    </div>
</div>
<br>

<div class=""container-fluid bg-3 text-center"">
    <div class=""row"">
");
            WriteLiteral(@"        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
        <div class=""col-sm-3"">
            <p>Some text..</p>
            <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
        </div>
    </div>
</div>
<br>
<br>

");
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
