#pragma checksum "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c814bf207d26d5da5775b4f7c3d0e07068e3d3"
// <auto-generated/>
#pragma warning disable 1591
namespace ADMRH.Pages.Usuarios
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
#nullable restore
#line 5 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
using ADMRH.Pages.Loadings;

#line default
#line hidden
#nullable disable
    public partial class Usuarios_table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "<div class=\"col\"><h2>Usuarios</h2></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col mb-3");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-success float-right");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                              ExportarCSV

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "Exportar <i class=\"fas fa-file-excel\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
 if (usuarios != null)
{
    if (usuarios.Count != 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Usuario>>(9);
            __builder.AddAttribute(10, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                   FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                                                                      5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "PagerHorizontalAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                                                                                                                  HorizontalAlign.Left

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ShowPagingSummary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                                                                                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Usuario>>(
#nullable restore
#line 19 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                               usuarios

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ColumnWidth", "300px");
            __builder.AddAttribute(20, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 19 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                                                LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(22);
                __builder2.AddAttribute(23, "Property", "Cedula");
                __builder2.AddAttribute(24, "Title", "Cedula");
                __builder2.AddAttribute(25, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(28);
                __builder2.AddAttribute(29, "Property", "Nombre");
                __builder2.AddAttribute(30, "Title", "Nombre");
                __builder2.AddAttribute(31, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(33);
                __builder2.AddAttribute(34, "Property", "Apellido");
                __builder2.AddAttribute(35, "Title", "Apellido");
                __builder2.AddAttribute(36, "Width", "200px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(38);
                __builder2.AddAttribute(39, "Property", "Telefono");
                __builder2.AddAttribute(40, "Title", "Telefono");
                __builder2.AddAttribute(41, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(43);
                __builder2.AddAttribute(44, "Property", "Correo");
                __builder2.AddAttribute(45, "Title", "Correo");
                __builder2.AddAttribute(46, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(48);
                __builder2.AddAttribute(49, "Property", "Rol");
                __builder2.AddAttribute(50, "Title", "Rol");
                __builder2.AddAttribute(51, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(53);
                __builder2.AddAttribute(54, "Title", "Photo");
                __builder2.AddAttribute(55, "Width", "100px");
                __builder2.AddAttribute(56, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Usuario>)((data) => (__builder3) => {
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "row");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col pr-1");
                    __builder3.OpenElement(62, "a");
                    __builder3.AddAttribute(63, "style", "text-decoration:none;");
                    __builder3.AddAttribute(64, "href", "usuarios/view-user/" + (
#nullable restore
#line 31 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                           data.IdUsuario

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "class", "btn btn-success w-100");
                    __builder3.AddMarkupContent(66, "<i class=\"fas fa-user-edit\"></i>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                            ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "col pl-1");
                    __builder3.OpenElement(70, "button");
                    __builder3.AddAttribute(71, "class", "btn btn-danger w-100");
                    __builder3.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                                                                 () => ConfirmacionElimanarUsuario(data)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(73, "<i class=\"fas fa-trash\"></i>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(74, (__value) => {
#nullable restore
#line 19 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
                                               grid = (Radzen.Blazor.RadzenDataGrid<Usuario>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<div class=\"alert alert-danger\">\r\n            No se encontraron datos...\r\n        </div>");
#nullable restore
#line 47 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
    }
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
 if (loading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ADMRH.Pages.Loadings.Loading>(76);
            __builder.CloseComponent();
#nullable restore
#line 54 "C:\Users\Alex-carreras\source\repos\ADMRH-FRONT\ADMRH\Pages\Usuarios\Usuarios-table.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
