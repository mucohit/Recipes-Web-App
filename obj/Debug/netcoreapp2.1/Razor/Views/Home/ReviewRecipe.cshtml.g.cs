#pragma checksum "C:\Users\aricm\Downloads\COMP229_G10\Recipes\Recipes\Views\Home\ReviewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "887d04d72867ed51519ac890067340bf65725066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReviewRecipe), @"mvc.1.0.view", @"/Views/Home/ReviewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ReviewRecipe.cshtml", typeof(AspNetCore.Views_Home_ReviewRecipe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887d04d72867ed51519ac890067340bf65725066", @"/Views/Home/ReviewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReviewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\aricm\Downloads\COMP229_G10\Recipes\Recipes\Views\Home\ReviewRecipe.cshtml"
  
    ViewBag.Title = "Review Recipe";

#line default
#line hidden
            BeginContext(47, 308, true);
            WriteLiteral(@"<br />

<blockquote class="" blockquote text-right"">
    <h4 class="" display-4"" id=""header"">A Review is A New View</h4>
    <footer class=""blockquote-footer alight-right"">Famous Someone</footer>
</blockquote>
<div class=""row"">
    <div class=""col-4"">

    </div>

    <div class=""col-6 "">
        ");
            EndContext();
            BeginContext(355, 2560, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af94c4bb52cf4c81b1b9a7efe13013d0", async() => {
                BeginContext(361, 2547, true);
                WriteLiteral(@"
            <h5>Taste</h5>
            <div class=""form-check-inline"">
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""taste"" />1</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""taste"" />2</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""taste"" />3</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""taste"" />4</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""taste"" />5</label>
            </div>
            <h5>Convenience</h5>
            <div class=""form-check-inline"">
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""convenience"" />1</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-in");
                WriteLiteral(@"put"" name=""convenience"" />2</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""convenience"" />3</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""convenience"" />4</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""convenience"" />5</label>
            </div>
            <h5>Uniqueness</h5>
            <div class=""form-check-inline"">
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""uniqueness"" />1</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""uniqueness"" />2</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""uniqueness"" />3</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""u");
                WriteLiteral(@"niqueness"" />4</label>
                <label class=""form-check-label mr-2""> <input type=""radio"" class=""form-check-input"" name=""uniqueness"" />5</label>
            </div>
            <h5>Additional Review</h5>
            <textarea placeholder=""Enter your perspective..."" class=""form-control float-right mb-2"" id=""ingredients""></textarea>
            <button class=""btn btn-primary"" type=""submit"">Send</button>
            <button class=""btn btn-danger"" type=""reset"">Reset</button>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2915, 76, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
