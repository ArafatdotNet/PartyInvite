#pragma checksum "A:\.net core practice\PartyInvite\PartyInvite\Views\Home\ListResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1ce4fa01a7a05f3470a59468f3e26d7d572155a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListResponses), @"mvc.1.0.view", @"/Views/Home/ListResponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListResponses.cshtml", typeof(AspNetCore.Views_Home_ListResponses))]
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
#line 1 "A:\.net core practice\PartyInvite\PartyInvite\Views\_ViewImports.cshtml"
using PartyInvite;

#line default
#line hidden
#line 2 "A:\.net core practice\PartyInvite\PartyInvite\Views\_ViewImports.cshtml"
using PartyInvite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ce4fa01a7a05f3470a59468f3e26d7d572155a", @"/Views/Home/ListResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a5a3b61ca58780c9999b65626eebe80ed896a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartyInvite.Models.GuestResponse>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "A:\.net core practice\PartyInvite\PartyInvite\Views\Home\ListResponses.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(81, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(106, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "607b3c5a4bea421bbc9b0f89090fc70a", async() => {
                BeginContext(112, 167, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.css\" />\r\n    <title>Responses</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(286, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(288, 450, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da31b1809ca24d529e129e661551fb2c", async() => {
                BeginContext(294, 247, true);
                WriteLiteral("\r\n<div class=\"panel-body\">\r\n<h2>Here is the list of people attending the party</h2>\r\n<table class=\"table table-sm table-striped table-bordered\">\r\n<thead>\r\n<tr>\r\n    <th>Name</th>\r\n    <th>Email</th>\r\n    <th>Phone</th>\r\n</tr>\r\n</thead>\r\n<tbody> \r\n");
                EndContext();
#line 24 "A:\.net core practice\PartyInvite\PartyInvite\Views\Home\ListResponses.cshtml"
 foreach (PartyInvite.Models.GuestResponse r in Model) {

#line default
#line hidden
                BeginContext(599, 22, true);
                WriteLiteral("    <tr>\r\n        <td>");
                EndContext();
                BeginContext(622, 6, false);
#line 26 "A:\.net core practice\PartyInvite\PartyInvite\Views\Home\ListResponses.cshtml"
       Write(r.Name);

#line default
#line hidden
                EndContext();
                BeginContext(628, 19, true);
                WriteLiteral("</td>\r\n        <td>");
                EndContext();
                BeginContext(648, 7, false);
#line 27 "A:\.net core practice\PartyInvite\PartyInvite\Views\Home\ListResponses.cshtml"
       Write(r.Email);

#line default
#line hidden
                EndContext();
                BeginContext(655, 19, true);
                WriteLiteral("</td>\r\n        <td>");
                EndContext();
                BeginContext(675, 7, false);
#line 28 "A:\.net core practice\PartyInvite\PartyInvite\Views\Home\ListResponses.cshtml"
       Write(r.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(682, 18, true);
                WriteLiteral("</td>\r\n    </tr>\r\n");
                EndContext();
#line 30 "A:\.net core practice\PartyInvite\PartyInvite\Views\Home\ListResponses.cshtml"
}

#line default
#line hidden
                BeginContext(703, 28, true);
                WriteLiteral("</tbody>\r\n</table>\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(738, 10, true);
            WriteLiteral("\r\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartyInvite.Models.GuestResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
