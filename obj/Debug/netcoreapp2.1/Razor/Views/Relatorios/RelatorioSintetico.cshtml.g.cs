#pragma checksum "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0315eb263bc0c4c56a716cabad55844ecacab877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorios_RelatorioSintetico), @"mvc.1.0.view", @"/Views/Relatorios/RelatorioSintetico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Relatorios/RelatorioSintetico.cshtml", typeof(AspNetCore.Views_Relatorios_RelatorioSintetico))]
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
#line 1 "C:\Devedores\Views\_ViewImports.cshtml"
using Devedores;

#line default
#line hidden
#line 2 "C:\Devedores\Views\_ViewImports.cshtml"
using Devedores.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0315eb263bc0c4c56a716cabad55844ecacab877", @"/Views/Relatorios/RelatorioSintetico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe71356a4e576007639e36f3fbf03c28e9d0c5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorios_RelatorioSintetico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Devedores.Models.Devedor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
  
    ViewData["Title"] = "Relatório Sintético";

#line default
#line hidden
            BeginContext(103, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(110, 17, false);
#line 7 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 393, true);
            WriteLiteral(@"</h2>

<div class=""panel panel-primary"">
    <!--<div class=""panel-heading"">
        <h3 class=""panel-title"">Total vendas = Model.Sum(obj => obj.Quantidade).ToString(""F2"")</h3>
    </div>-->
    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr class=""success"">
                    <th>
                        ");
            EndContext();
            BeginContext(521, 47, false);
#line 18 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                   Write(Html.DisplayNameFor(model => model.Pessoa.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(568, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(648, 41, false);
#line 21 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(689, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(769, 40, false);
#line 24 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                   Write(Html.DisplayNameFor(model => model.Pago));

#line default
#line hidden
            EndContext();
            BeginContext(809, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 29 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(969, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1054, 46, false);
#line 33 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Pessoa.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1192, 40, false);
#line 36 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1324, 39, false);
#line 39 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Pago));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 42 "C:\Devedores\Views\Relatorios\RelatorioSintetico.cshtml"
                }

#line default
#line hidden
            BeginContext(1442, 66, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Devedores.Models.Devedor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
