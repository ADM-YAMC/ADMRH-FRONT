#pragma checksum "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e63265e8605ca9c7e27eee4dde9a0c60eaaa3b64"
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
    public partial class Vacantes_table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
 if (vacantes != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
     if (vacantes.Count != 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Vacante>>(0);
            __builder.AddAttribute(1, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                   FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                                                                      5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "PagerHorizontalAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                                                                                                                  HorizontalAlign.Left

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ShowPagingSummary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                                                                                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Vacante>>(
#nullable restore
#line 9 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                               vacantes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ColumnWidth", "300px");
            __builder.AddAttribute(11, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 9 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                                                        LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Vacante>>(13);
                __builder2.AddAttribute(14, "Property", "Nombre");
                __builder2.AddAttribute(15, "Title", "Nombre");
                __builder2.AddAttribute(16, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Vacante>>(19);
                __builder2.AddAttribute(20, "Property", "Departamento");
                __builder2.AddAttribute(21, "Title", "Departamento");
                __builder2.AddAttribute(22, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Vacante>>(24);
                __builder2.AddAttribute(25, "Property", "Descripcion");
                __builder2.AddAttribute(26, "Title", "Descripcion");
                __builder2.AddAttribute(27, "Width", "200px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Vacante>>(29);
                __builder2.AddAttribute(30, "Property", "Cargo");
                __builder2.AddAttribute(31, "Title", "Cargo");
                __builder2.AddAttribute(32, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Vacante>>(34);
                __builder2.AddAttribute(35, "Property", "Salario");
                __builder2.AddAttribute(36, "Title", "Salario");
                __builder2.AddAttribute(37, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Vacante>>(39);
                __builder2.AddAttribute(40, "Title", "Photo");
                __builder2.AddAttribute(41, "Width", "100px");
                __builder2.AddAttribute(42, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Vacante>)((data) => (__builder3) => {
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "row m-auto");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col pr-1");
                    __builder3.OpenElement(48, "a");
                    __builder3.AddAttribute(49, "href", "vacantes/editar-vacante/" + (
#nullable restore
#line 20 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                  data.IdVacante

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "class", "btn btn-success w-100");
                    __builder3.AddMarkupContent(51, "<i class=\"fas fa-user-edit\"></i>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 22 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                             if (userClaims != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                 if (userClaims.Rol.Equals("Administrador"))
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col pl-1");
                    __builder3.OpenElement(54, "button");
                    __builder3.AddAttribute(55, "class", "btn btn-danger w-100");
                    __builder3.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                         ()=>ConfirmacionElimanarVacante(data)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(57, "<i class=\"fas fa-trash\"></i>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 29 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(58, (__value) => {
#nullable restore
#line 9 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
                                                                                   VacantesGrid = (Radzen.Blazor.RadzenDataGrid<Vacante>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "alert alert-danger mt-3");
            __builder.AddContent(61, 
#nullable restore
#line 42 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
              IdUsuario != null ? "El usuario no cuenta con vacantes creadas...": "No hay ninguna vacante registrada..."

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
     

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "<h5>Cargando las vacantes...</h5>");
#nullable restore
#line 50 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"
 if (loading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ADMRH.Pages.Loadings.Loading>(63);
            __builder.CloseComponent();
#nullable restore
#line 55 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Vacantes\Vacantes-table.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
    }
}
#pragma warning restore 1591
