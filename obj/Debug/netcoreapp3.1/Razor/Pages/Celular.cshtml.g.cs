#pragma checksum "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Celular.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46fd1acaf4d609eb88b88679e9ce987bdf5a2122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Exercicio.Pages.Pages_Celular), @"mvc.1.0.razor-page", @"/Pages/Celular.cshtml")]
namespace Exercicio.Pages
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
#line 1 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\_ViewImports.cshtml"
using Exercicio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46fd1acaf4d609eb88b88679e9ce987bdf5a2122", @"/Pages/Celular.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a6ee1047010d11dbd6d1aff8d50ba2d139774b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Celular : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Celular.cshtml"
  
    ViewData["Title"] = "Celular";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Celular</h1>\r\n<p>Modelo:");
#nullable restore
#line 8 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Celular.cshtml"
     Write(Model.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Marca:");
#nullable restore
#line 9 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Celular.cshtml"
    Write(Model.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Tamanho:");
#nullable restore
#line 10 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Celular.cshtml"
      Write(Model.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Pelicula:");
#nullable restore
#line 11 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Celular.cshtml"
       Write(Model.Pelicula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicio.CelularModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicio.CelularModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicio.CelularModel>)PageContext?.ViewData;
        public Exercicio.CelularModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591