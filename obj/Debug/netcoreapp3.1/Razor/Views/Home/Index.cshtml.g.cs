#pragma checksum "C:\Users\MRCR\Desktop\Projeto-Casa-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0222235af58c9c4c4f815a9af72ab37bfadeda1"
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
#line 1 "C:\Users\MRCR\Desktop\Projeto-Casa-master\Views\_ViewImports.cshtml"
using CasaShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MRCR\Desktop\Projeto-Casa-master\Views\_ViewImports.cshtml"
using CasaShow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0222235af58c9c4c4f815a9af72ab37bfadeda1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb577ed319ac07ff0621d8e4915d7f8afa8793ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\MRCR\Desktop\Projeto-Casa-master\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div id=""Index"" class=""text-center"" >
    <div>
        <div style='background:url(Img/home.gif) repeat-x; width:1100px; height:200px; margin:auto; text-align:center;'>
        <br> 
        <br>

            <h1  class=""display-3""    >BEM VINDO(A) À CASA SHOW</h1>
        </div>
    </div>
    
    <p><h5>  Encontre aqui o seu evento </h5></p>
</div>
<div class=""row"">

        <div class=""col-md-4"">
           
             <p><center><img src=""/Img/sertanejo.png"" width=""300"" height=""200""</center></p>


            <div class=""card"">
             <div class=""card-body"">
    
            <center><h2>Show Esquenta Villa Mix</h2></center>
            <h6><center>Preço do Ingresso: R$300,00</center></h6>
            <h6><center>Data 20/04/2020</center></h6>
            <h6><center>Local: Villa Country</center></h6>
            <center><button class=""btn btn-danger""><center><a href=""/Home/Ingressos/"">Comprar</button></center></a>
  </div>
   </div>


        </div>

    <div class=""col-md-4"">

            <p><");
            WriteLiteral(@"center><img src=""/Img/pop.png"" width=""300"" height=""200""</center></p>

            <div class=""card"">
            <div class=""card-body"">
 

            <center><h2>Show da Anitta e Convidados</h2></center>
            <h6><center>Preço do Ingresso: R$100,00</center></h6>
            <h6><center>Data 29/04/2020</center></h6>
            <h6><center>Local: Sambódrono Anhembi</center></h6>
            <center><button class=""btn btn-danger""><a href=""/Home/Ingressos/"">Comprar</button></center></a>

        </div>
        </div>

        </div>

        <div class=""col-md-4"">

            <p><center><img src=""/Img/pagodeiros.png"" width=""300"" height=""200""</center></p>
            

            <div class=""card"">
  <div class=""card-body"">
  
            <center><h2>Show dos Reis do Pagode</h2></center>
            
            <h6><center>Preço do Ingresso: R$200,00</center></h6>
            <h6><center>Data 17/03/2020</center></h6>
            <h6><center>Local: Espaço das Americas </center></h6>
            <center");
            WriteLiteral("><button class=\"btn btn-danger\"><a href=\"/Home/Ingressos/\">Comprar</button></center></a>\n\n  </div>\n</div>\n\n        </div>\n\n    </div>");
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
