#pragma checksum "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Chuveiro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bade56353aaba4db29cd78a9b02ab88be7b89fb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Exercicio.Pages.Pages_Chuveiro), @"mvc.1.0.razor-page", @"/Pages/Chuveiro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bade56353aaba4db29cd78a9b02ab88be7b89fb1", @"/Pages/Chuveiro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a6ee1047010d11dbd6d1aff8d50ba2d139774b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Chuveiro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Chuveiro.cshtml"
  
    ViewData["Title"] = "Chuveiro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Chuveiro</h1>\r\n<p>Potencia:");
#nullable restore
#line 8 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Chuveiro.cshtml"
       Write(Model.Potencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Marca:");
#nullable restore
#line 9 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Chuveiro.cshtml"
    Write(Model.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Tensao:");
#nullable restore
#line 10 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Chuveiro.cshtml"
     Write(Model.Tensao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Modelo:");
#nullable restore
#line 11 "F:\3EM\Pw2\Exercicio\Exercicio\Pages\Chuveiro.cshtml"
     Write(Model.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicio.ChuveiroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicio.ChuveiroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicio.ChuveiroModel>)PageContext?.ViewData;
        public Exercicio.ChuveiroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
