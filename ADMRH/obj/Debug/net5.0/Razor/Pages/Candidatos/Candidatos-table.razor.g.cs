#pragma checksum "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d99757cf35d2d650215f85079d6e15869c225da"
// <auto-generated/>
#pragma warning disable 1591
namespace ADMRH.Pages.Candidatos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using ADMRH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using ADMRH.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using ADMRH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using ADMRH_API.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class Candidatos_table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Candidato>>(0);
            __builder.AddAttribute(1, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                           FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                                                              5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "PagerHorizontalAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                                                                                                          HorizontalAlign.Left

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ShowPagingSummary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                                                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Candidato>>(
#nullable restore
#line 3 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                       candidatos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ColumnWidth", "300px");
            __builder.AddAttribute(11, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 3 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                                LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Candidato>>(13);
                __builder2.AddAttribute(14, "Property", "Nombre");
                __builder2.AddAttribute(15, "Title", "Nombre");
                __builder2.AddAttribute(16, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Candidato>>(19);
                __builder2.AddAttribute(20, "Property", "Apellido");
                __builder2.AddAttribute(21, "Title", "Apellido");
                __builder2.AddAttribute(22, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Candidato>>(24);
                __builder2.AddAttribute(25, "Property", "Cedula");
                __builder2.AddAttribute(26, "Title", "Cedula");
                __builder2.AddAttribute(27, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Candidato>>(29);
                __builder2.AddAttribute(30, "Property", "Direccion");
                __builder2.AddAttribute(31, "Title", "Direccion");
                __builder2.AddAttribute(32, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Candidato>>(34);
                __builder2.AddAttribute(35, "Property", "Telefono");
                __builder2.AddAttribute(36, "Title", "Telefono");
                __builder2.AddAttribute(37, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Candidato>>(39);
                __builder2.AddAttribute(40, "Property", "Correo");
                __builder2.AddAttribute(41, "Title", "Correo");
                __builder2.AddAttribute(42, "Width", "140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Candidato>>(44);
                __builder2.AddAttribute(45, "Title", "Opciones");
                __builder2.AddAttribute(46, "Width", "100px");
                __builder2.AddAttribute(47, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Alex-carreras\Desktop\ADMRH\ADMRH\Pages\Candidatos\Candidatos-table.razor"
                                                                                           false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Candidato>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(49, @"<div class=""row m-auto""><div class=""col pr-1""><a href=""candidatos/view"" class=""btn btn-success w-100""><i class=""fas fa-user-edit""></i></a></div>
                    <div class=""col pl-1""><button class=""btn btn-danger w-100""><i class=""fas fa-trash""></i></button></div></div>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
