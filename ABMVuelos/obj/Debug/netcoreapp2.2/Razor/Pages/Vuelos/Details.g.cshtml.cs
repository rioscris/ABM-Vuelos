#pragma checksum "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0158c8de3231424386412a03aea57f70b39e902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ABMVuelos.Pages.Vuelos.Pages_Vuelos_Details), @"mvc.1.0.razor-page", @"/Pages/Vuelos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Vuelos/Details.cshtml", typeof(ABMVuelos.Pages.Vuelos.Pages_Vuelos_Details), null)]
namespace ABMVuelos.Pages.Vuelos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\_ViewImports.cshtml"
using ABMVuelos;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0158c8de3231424386412a03aea57f70b39e902", @"/Pages/Vuelos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3449113415d5ee2913ba7e65992164075fbfe90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vuelos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 126, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Vuelo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(223, 49, false);
#line 15 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vuelo.llegada));

#line default
#line hidden
            EndContext();
            BeginContext(272, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(334, 45, false);
#line 18 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vuelo.llegada));

#line default
#line hidden
            EndContext();
            BeginContext(379, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 47, false);
#line 21 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vuelo.Linea));

#line default
#line hidden
            EndContext();
            BeginContext(487, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(549, 43, false);
#line 24 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vuelo.Linea));

#line default
#line hidden
            EndContext();
            BeginContext(592, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(653, 48, false);
#line 27 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vuelo.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(701, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(763, 44, false);
#line 30 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vuelo.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(807, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(868, 50, false);
#line 33 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vuelo.Demorado));

#line default
#line hidden
            EndContext();
            BeginContext(918, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(980, 46, false);
#line 36 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vuelo.Demorado));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1073, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0158c8de3231424386412a03aea57f70b39e9027828", async() => {
                BeginContext(1125, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Details.cshtml"
                           WriteLiteral(Model.Vuelo.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1133, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1141, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0158c8de3231424386412a03aea57f70b39e90210184", async() => {
                BeginContext(1163, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1179, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ABMVuelos.Pages.Vuelos.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ABMVuelos.Pages.Vuelos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ABMVuelos.Pages.Vuelos.DetailsModel>)PageContext?.ViewData;
        public ABMVuelos.Pages.Vuelos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
