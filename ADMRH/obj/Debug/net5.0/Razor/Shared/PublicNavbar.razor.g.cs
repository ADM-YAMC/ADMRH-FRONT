#pragma checksum "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Shared\PublicNavbar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a681a38f64902df0e321bacb365549019c58527"
// <auto-generated/>
#pragma warning disable 1591
namespace ADMRH.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH_API.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Pages.Loadings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\_Imports.razor"
using ADMRH.Herpers;

#line default
#line hidden
#nullable disable
    public partial class PublicNavbar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "id", "myTopNavbar");
            __builder.AddAttribute(2, "class", "top-navbar navbar navbar-expand-lg");
            __builder.AddAttribute(3, "style", "background: #023877;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "brand-container");
            __builder.OpenComponent<Radzen.Blazor.RadzenImage>(8);
            __builder.AddAttribute(9, "Path", @"https://scontent.fhex5-2.fna.fbcdn.net/v/t1.6435-9/49656237_941670379357742_8440506915926048768_n.png?_nc_cat=109&ccb=1-5&_nc_sid=174925&_nc_ohc=zkg8tIqNk7AAX-lbDzG&_nc_ht=scontent.fhex5-2.fna&oh=00_AT_NwEb1as807UsatEUq1utQLwGVqVTFHmOGGPVs3hZ4vQ&oe=62520EE2");
            __builder.AddAttribute(10, "Style", "width: 50px; height:50px; margin-right: 10px; border-radius: 10px;");
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n          ");
            __builder.AddMarkupContent(12, "<a class=\"navbar-brand text-white\">Just Quality HR</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
    }
}
#pragma warning restore 1591
