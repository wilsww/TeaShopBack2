#pragma checksum "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64c40d4b0049b9edebcce6af0e6a1a6dd47d51849731e9cb4124e2c74acbfc3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_DownloadPersonalData), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"64c40d4b0049b9edebcce6af0e6a1a6dd47d51849731e9cb4124e2c74acbfc3c", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"451bfcc06ae17b2ad9759a804c86308917991413be0ea93f1b4cf092b1844571", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d2a21e0cc152e7046486d3aa124c87773eb4f2d5e4192a8a7558c0c6f2580973", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d52e37ed016abd77f3be2a6569563d545b135ccd5d3044dc6bc5ca5b1f077d83", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_Manage_DownloadPersonalData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml"
  
    ViewData["Title"] = "Download Your Data";
    ViewData["ActivePage"] = ManageNavPages.PersonalData;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4>");
#nullable restore
#line 8 "/Users/wayne/Documents/My__Files/Jobs/Projects/OnlineShopCMS-Demo-main/OnlineShopCMS/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64c40d4b0049b9edebcce6af0e6a1a6dd47d51849731e9cb4124e2c74acbfc3c6018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DownloadPersonalDataModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel>)PageContext?.ViewData;
        public DownloadPersonalDataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
