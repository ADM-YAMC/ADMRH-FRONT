#pragma checksum "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d41201fa07ced3652abe8f4643dfcb9e016136"
// <auto-generated/>
#pragma warning disable 1591
namespace ADMRH.Pages.Bolsa
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH_API.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Pages.Loadings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(PublicLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/oferta-empleos")]
    public partial class VacantesBolsa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .content-card {
        display: grid;
        gap: 1rem;
        grid-auto-rows: 27rem;
        grid-template-columns: repeat(auto-fill, minmax(18rem, 1fr));
    }
    .div-description{
        height:100px;
    }
    .div-basic-info{
        height: 50px;
    }
    .div-basic-infov {
        height: 70px;
    }
    .card-content{
        border-radius:5px;
        height:424px;
    }
</style>
");
            __builder.AddMarkupContent(1, "<h1 class=\"mt-2 ml-4\">Bolsa de Empleos</h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content-card px-3");
#nullable restore
#line 31 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
         if (response != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
             foreach (var item in response.vacante)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-content border text-center");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col div-basic-info text-center text-white");
            __builder.AddAttribute(10, "style", "background: #023877; border-top-left-radius:5px; border-top-right-radius:5px;");
            __builder.OpenElement(11, "h4");
            __builder.AddAttribute(12, "class", "pt-2");
            __builder.AddAttribute(13, "style", "color:aliceblue;");
#nullable restore
#line 37 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(14, item.Nombre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col div-basic-info border-top text-center");
            __builder.OpenElement(18, "h2");
            __builder.AddAttribute(19, "class", "pt-2");
#nullable restore
#line 40 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(20, item.Provincia);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                     ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col div-description border-top");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "pt-1");
#nullable restore
#line 43 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(26, item.Descripcion);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                     ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col div-basic-info border-top");
            __builder.AddMarkupContent(30, "<label style=\"text-align:center\" class=\"pt-1\">Tipo de contrato</label>\r\n                         ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "pt-1");
            __builder.OpenElement(33, "b");
#nullable restore
#line 47 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(34, item.EstadoPuesto);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                     ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col div-basic-infov border-top");
            __builder.AddMarkupContent(38, "<label style=\"text-align:center\" class=\"pt-1 text-center\">Horario</label>\r\n                         ");
            __builder.OpenElement(39, "p");
            __builder.AddAttribute(40, "class", "pt-1");
            __builder.OpenElement(41, "b");
            __builder.AddContent(42, "De ");
#nullable restore
#line 51 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(43, item.DiaSemanaInicio);

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, " a ");
#nullable restore
#line 51 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(45, item.DiaSemanaFin);

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, " de ");
#nullable restore
#line 51 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(47, item.HoraInicio);

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, " a ");
#nullable restore
#line 51 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(49, item.HoraFin);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                     ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col div-basic-info border-top");
            __builder.AddMarkupContent(53, "<label style=\"text-align:center\" class=\"pt-1 text-center\">Fecha de publicacion</label>\r\n                         ");
            __builder.OpenElement(54, "p");
            __builder.AddAttribute(55, "class", "pt-1");
            __builder.OpenElement(56, "b");
#nullable restore
#line 55 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
__builder.AddContent(57, Convert.ToDateTime(item.FechaCreacion).ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                     ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col div-basic-info border-top");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(61);
            __builder.AddAttribute(62, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
                                               args => ApplyJob(item.IdVacante)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(63, "Text", "Aplicar");
            __builder.AddAttribute(64, "Icon", "add_circle_outline");
            __builder.AddAttribute(65, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 61 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
                                                    ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "Style", "width:100%; margin-top:7px;");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ADMRH.Pages.Loadings.Loading>(67);
            __builder.CloseComponent();
#nullable restore
#line 70 "C:\Users\Jacsel Guridi Diaz\Desktop\Projects\ADMRH-FRONT\ADMRH\Pages\Bolsa\VacantesBolsa.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
    }
}
#pragma warning restore 1591
