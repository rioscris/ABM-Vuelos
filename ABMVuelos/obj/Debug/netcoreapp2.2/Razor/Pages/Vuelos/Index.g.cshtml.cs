#pragma checksum "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0cabce0a2a0fa30302801e5609a4ab8308a66fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ABMVuelos.Pages.Vuelos.Pages_Vuelos_Index), @"mvc.1.0.razor-page", @"/Pages/Vuelos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Vuelos/Index.cshtml", typeof(ABMVuelos.Pages.Vuelos.Pages_Vuelos_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cabce0a2a0fa30302801e5609a4ab8308a66fc", @"/Pages/Vuelos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3449113415d5ee2913ba7e65992164075fbfe90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vuelos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
  
    ViewData["Title"] = "Visor de vuelos";

#line default
#line hidden
            BeginContext(102, 42, true);
            WriteLiteral("\r\n<h1>Vuelos programados</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(144, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cabce0a2a0fa30302801e5609a4ab8308a66fc5392", async() => {
                BeginContext(165, 24, true);
                WriteLiteral("Registrar un nuevo vuelo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(193, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(201, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cabce0a2a0fa30302801e5609a4ab8308a66fc6787", async() => {
                BeginContext(207, 26, true);
                WriteLiteral("\r\n    <p>\r\n        Código ");
                EndContext();
                BeginContext(233, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0cabce0a2a0fa30302801e5609a4ab8308a66fc7195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 15 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CodigoABuscar);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(278, 59, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Buscar\"/>\r\n    </p>\r\n");
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
            BeginContext(344, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(431, 52, false);
#line 23 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vuelo[0].llegada));

#line default
#line hidden
            EndContext();
            BeginContext(483, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(539, 50, false);
#line 26 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vuelo[0].Linea));

#line default
#line hidden
            EndContext();
            BeginContext(589, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(645, 51, false);
#line 29 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vuelo[0].Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(696, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(752, 53, false);
#line 32 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vuelo[0].Demorado));

#line default
#line hidden
            EndContext();
            BeginContext(805, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
 foreach (var item in Model.Vuelo) {

#line default
#line hidden
            BeginContext(929, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(978, 42, false);
#line 41 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.llegada));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1076, 40, false);
#line 44 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Linea));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1172, 41, false);
#line 47 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <!--");
            EndContext();
            BeginContext(1273, 43, false);
#line 50 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Demorado));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 6, true);
            WriteLiteral("--->\r\n");
            EndContext();
#line 51 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
                 if (item.Demorado)
                {
                    

#line default
#line hidden
            BeginContext(1399, 19, false);
#line 53 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
               Write(string.Format("Si"));

#line default
#line hidden
            EndContext();
#line 53 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
                                        ;
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1502, 19, false);
#line 57 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
               Write(string.Format("No"));

#line default
#line hidden
            EndContext();
#line 57 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
                                        ;
                }

#line default
#line hidden
            BeginContext(1543, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1596, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cabce0a2a0fa30302801e5609a4ab8308a66fc15631", async() => {
                BeginContext(1641, 9, true);
                WriteLiteral("Modificar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
                                       WriteLiteral(item.ID);

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
            BeginContext(1654, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1674, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cabce0a2a0fa30302801e5609a4ab8308a66fc18009", async() => {
                BeginContext(1722, 3, true);
                WriteLiteral("Ver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
                                          WriteLiteral(item.ID);

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
            BeginContext(1729, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1749, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cabce0a2a0fa30302801e5609a4ab8308a66fc20384", async() => {
                BeginContext(1796, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
                                         WriteLiteral(item.ID);

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
            BeginContext(1808, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\Cristian Rios\Desktop\Udemy\Programacion Web\ASP.NET\ABM-Vuelos\ABMVuelos\Pages\Vuelos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1847, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ABMVuelos.Pages.Vuelos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ABMVuelos.Pages.Vuelos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ABMVuelos.Pages.Vuelos.IndexModel>)PageContext?.ViewData;
        public ABMVuelos.Pages.Vuelos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
