#pragma checksum "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "484e3419fcfb249ef31ce815590837fa914cf382"
// <auto-generated/>
#pragma warning disable 1591
namespace ADMRH.Pages.Vacantes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH_API.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Pages.Loadings;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacantes")]
    public partial class Vacantes_home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-xl mt-5");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<div class=\"row\"><div class=\"col\"><h1>Vacantes</h1></div>\r\n            <div class=\"col\"><a style=\"text-decoration:none;\" href=\"vacantes/nueva-vacante\" class=\"btn btn-success float-right\">Nueva vancante</a></div></div>\r\n        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "row border-top");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col");
                __builder2.OpenComponent<ADMRH.Pages.Vacantes.Vacantes_table>(9);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
