#pragma checksum "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993fa7629d70e6a04cac756c5b92e3f76557b09d"
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
#nullable restore
#line 4 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(PublicLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacantes-publicas/registro-candidato/{IdVacante:int}")]
    public partial class RegistroCandidato : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "<div class=\"col-md-1\"></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-10");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(5);
            __builder.AddAttribute(6, "class", "m-3");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
                __builder2.AddAttribute(9, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                              candidate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                        GuardarCandidato

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenFieldset>(14);
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "<h1 class=\"d-inline pt-2\">Registro de Candidato</h1>\r\n                    ");
                        __builder4.OpenElement(17, "div");
                        __builder4.AddAttribute(18, "class", "row");
                        __builder4.OpenElement(19, "div");
                        __builder4.AddAttribute(20, "class", "col-md-6");
                        __builder4.OpenElement(21, "div");
                        __builder4.AddAttribute(22, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(23, "<h4>Nombre</h4>\r\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                        __builder4.AddAttribute(25, "Class", "w-100");
                        __builder4.AddAttribute(26, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                            candidate.Nombre

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => candidate.Nombre = __value, candidate.Nombre))));
                        __builder4.AddAttribute(28, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => candidate.Nombre));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n                                ");
                        __Blazor.ADMRH.Pages.Candidatos.RegistroCandidato.TypeInference.CreateValidationMessage_0(__builder4, 30, 31, 
#nullable restore
#line 22 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                          ()=> candidate.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(32, "\r\n                            ");
                        __builder4.OpenElement(33, "div");
                        __builder4.AddAttribute(34, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(35, "<h4>Apellido</h4>\r\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(36);
                        __builder4.AddAttribute(37, "Class", "w-100");
                        __builder4.AddAttribute(38, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                            candidate.Apellido

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => candidate.Apellido = __value, candidate.Apellido))));
                        __builder4.AddAttribute(40, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => candidate.Apellido));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                                ");
                        __Blazor.ADMRH.Pages.Candidatos.RegistroCandidato.TypeInference.CreateValidationMessage_1(__builder4, 42, 43, 
#nullable restore
#line 27 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                          ()=> candidate.Apellido

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(44, "\r\n                            ");
                        __builder4.OpenElement(45, "div");
                        __builder4.AddAttribute(46, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(47, "<h4>Correo electrónico</h4>\r\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(48);
                        __builder4.AddAttribute(49, "Class", "w-100");
                        __builder4.AddAttribute(50, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                            candidate.Correo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => candidate.Correo = __value, candidate.Correo))));
                        __builder4.AddAttribute(52, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => candidate.Correo));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\r\n                                ");
                        __Blazor.ADMRH.Pages.Candidatos.RegistroCandidato.TypeInference.CreateValidationMessage_2(__builder4, 54, 55, 
#nullable restore
#line 32 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                          ()=> candidate.Correo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(56, "\r\n                            ");
                        __builder4.OpenElement(57, "div");
                        __builder4.AddAttribute(58, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(59, "<h4>Cédula</h4>\r\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMask>(60);
                        __builder4.AddAttribute(61, "Mask", "***-*******-*");
                        __builder4.AddAttribute(62, "CharacterPattern", "[0-9]");
                        __builder4.AddAttribute(63, "Placeholder", "Cedula");
                        __builder4.AddAttribute(64, "Name", "CitizenId");
                        __builder4.AddAttribute(65, "Style", "width: 100%;");
                        __builder4.AddAttribute(66, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                                          candidate.Cedula

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => candidate.Cedula = __value, candidate.Cedula))));
                        __builder4.AddAttribute(68, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => candidate.Cedula));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "\r\n                                ");
                        __Blazor.ADMRH.Pages.Candidatos.RegistroCandidato.TypeInference.CreateValidationMessage_3(__builder4, 70, 71, 
#nullable restore
#line 41 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                          ()=> candidate.Cedula

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(72, "\r\n                        ");
                        __builder4.OpenElement(73, "div");
                        __builder4.AddAttribute(74, "class", "col-md-6");
                        __builder4.OpenElement(75, "div");
                        __builder4.AddAttribute(76, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(77, "<h4>Número de teléfono</h4>\r\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMask>(78);
                        __builder4.AddAttribute(79, "Mask", "(***) ***-****");
                        __builder4.AddAttribute(80, "CharacterPattern", "[0-9]");
                        __builder4.AddAttribute(81, "Placeholder", "(000) 000-0000");
                        __builder4.AddAttribute(82, "Name", "Phone");
                        __builder4.AddAttribute(83, "Style", "width: 100%;");
                        __builder4.AddAttribute(84, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                                      candidate.Telefono

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => candidate.Telefono = __value, candidate.Telefono))));
                        __builder4.AddAttribute(86, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => candidate.Telefono));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(87, "\r\n                                ");
                        __Blazor.ADMRH.Pages.Candidatos.RegistroCandidato.TypeInference.CreateValidationMessage_4(__builder4, 88, 89, 
#nullable restore
#line 52 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                          ()=> candidate.Telefono

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(90, "\r\n                            ");
                        __builder4.OpenElement(91, "div");
                        __builder4.AddAttribute(92, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(93, "<h4>Dirección</h4>\r\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(94);
                        __builder4.AddAttribute(95, "Class", "w-100");
                        __builder4.AddAttribute(96, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                            candidate.Direccion

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(97, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => candidate.Direccion = __value, candidate.Direccion))));
                        __builder4.AddAttribute(98, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => candidate.Direccion));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(99, "\r\n                                ");
                        __Blazor.ADMRH.Pages.Candidatos.RegistroCandidato.TypeInference.CreateValidationMessage_5(__builder4, 100, 101, 
#nullable restore
#line 57 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                          ()=> candidate.Direccion

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(102, "\r\n                            ");
                        __builder4.OpenElement(103, "div");
                        __builder4.AddAttribute(104, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(105, "<h4 class=\"my-2\">Curriculum Vitae</h4>\r\n                                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(106);
                        __builder4.AddAttribute(107, "id", "file");
                        __builder4.AddAttribute(108, "type", "file");
                        __builder4.AddAttribute(109, "class", "d-block");
                        __builder4.AddAttribute(110, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                                                            OnFileInputChangeCV

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
#nullable restore
#line 62 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                 if (estado)
                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(111, "span");
                        __builder4.AddAttribute(112, "class", "text-success");
#nullable restore
#line 64 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
__builder4.AddContent(113, mensaje);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 65 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(114, "\r\n                            ");
                        __builder4.OpenElement(115, "div");
                        __builder4.AddAttribute(116, "class", "m-1 mb-3");
                        __builder4.AddMarkupContent(117, "<h4 class=\"my-2\">Foto 2 x 2</h4>\r\n                                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(118);
                        __builder4.AddAttribute(119, "id", "file");
                        __builder4.AddAttribute(120, "type", "file");
                        __builder4.AddAttribute(121, "class", "d-block");
                        __builder4.AddAttribute(122, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                                                            OnFileInputChangeFoto

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
#nullable restore
#line 70 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                 if (estado)
                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(123, "span");
                        __builder4.AddAttribute(124, "class", "text-success");
#nullable restore
#line 72 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
__builder4.AddContent(125, mensaje);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 73 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(126, "\r\n                        ");
                        __builder4.OpenElement(127, "div");
                        __builder4.AddAttribute(128, "class", "row");
                        __builder4.OpenElement(129, "div");
                        __builder4.AddAttribute(130, "class", "col");
                        __builder4.OpenElement(131, "div");
                        __builder4.AddAttribute(132, "class", "float-left");
                        __builder4.OpenElement(133, "input");
                        __builder4.AddAttribute(134, "type", "submit");
                        __builder4.AddAttribute(135, "class", "btn btn-warning ml-2");
                        __builder4.AddAttribute(136, "value", "Volver");
                        __builder4.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                                                                                 () => Navigate.NavigateTo("/")

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(138, "\r\n                            ");
                        __builder4.OpenElement(139, "div");
                        __builder4.AddAttribute(140, "class", "col");
                        __builder4.OpenElement(141, "div");
                        __builder4.AddAttribute(142, "class", "float-end");
                        __builder4.OpenElement(143, "input");
                        __builder4.AddAttribute(144, "type", "submit");
                        __builder4.AddAttribute(145, "disabled", 
#nullable restore
#line 85 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
                                                                     archivoTemp == null

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(146, "class", "btn btn-primary");
                        __builder4.AddAttribute(147, "value", "Guardar todo");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\yunior.moreta.G4S\source\repos\ADMRH-FRONT\ADMRH\Pages\Candidatos\RegistroCandidato.razor"
       
    Candidato candidate = new Candidato();
    Archivo archivo = new Archivo();
    ArchivoTemp archivoTemp;
    ResponseC responseC;
    string cv, mensaje;
    bool estado = false;

    [Parameter]
    public int IdVacante { get; set; }


    async Task OnFileInputChangeFoto(InputFileChangeEventArgs e)
    {
        IBrowserFile imgFile = e.File;
        var buffers = new byte[imgFile.Size];
        await imgFile.OpenReadStream().ReadAsync(buffers);
        string imageType = imgFile.ContentType;
        archivo.Cv = $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
        if (archivoTemp == null)
        {
            if (archivo.Cv != null && archivo.FotoFrente != null)
            {
                await GuardarArchivo();
            }
        }
        else
        {
            await SobreEscribirArchivo();
        }
    }

    async Task OnFileInputChangeCV(InputFileChangeEventArgs e)
    {
        IBrowserFile imgFile = e.File;
        var buffers = new byte[imgFile.Size];
        await imgFile.OpenReadStream().ReadAsync(buffers);
        string imageType = imgFile.ContentType;
        archivo.FotoFrente = $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
        if (archivoTemp == null)
        {
            if (archivo.Cv != null && archivo.FotoFrente != null)
            {
                await GuardarArchivo();
            }
        }
        else
        {
            await ConfirmacionSobrescribir();
        }
    }

    async Task GuardarArchivo()
    {
        estado = true;
        mensaje = "Guardando...";
        StateHasChanged();
        string json = JsonConvert.SerializeObject(archivo);
        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var responses = await http.PostAsync("https://localhost:44322/api/Archivos", httpContent);
        archivoTemp = await responses.Content.ReadFromJsonAsync<ArchivoTemp>();
        StateHasChanged();
        if (archivoTemp != null)
        {
            mensaje = "Guardado";
        }
    }


    async Task SobreEscribirArchivo()
    {
        var id = archivoTemp.IdArchivos;
        estado = true;
        archivoTemp = null;
        mensaje = "Actualizando...";
        StateHasChanged();
        string json = JsonConvert.SerializeObject(archivo);
        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var responses = await http.PutAsync($"https://localhost:44322/api/Archivos/{id}", httpContent);
        archivoTemp = await responses.Content.ReadFromJsonAsync<ArchivoTemp>();
        StateHasChanged();
        if (archivoTemp != null)
        {
            mensaje = "Guardado";
        }
    }

    async Task ConfirmacionSobrescribir()
    {
        var result = await Swal.FireAsync(new SweetAlertOptions
        {
            Title = "¿Estas seguro?",
            Text = "¿Estas seguro de que quieres sobrescribir el archivo?",
            Icon = SweetAlertIcon.Warning,
            ShowCancelButton = true,
            ConfirmButtonText = "Si, sobrescribir",
            CancelButtonText = "No"
        });

        if (!string.IsNullOrEmpty(result.Value))
        {
            await SobreEscribirArchivo();
        }
    }

    async Task GuardarCandidato()
    {
        candidate.IdArchivos = archivoTemp.IdArchivos;
        candidate.IdUsuarioCreacion = 0;
        candidate.IdVacante = IdVacante;
        candidate.FechaCreacion = DateTime.Now.ToString("dd/MM/yyyy");
        string json = JsonConvert.SerializeObject(candidate);
        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var responses = await http.PostAsync("https://localhost:44322/api/Candidatos", httpContent);
        responseC = await responses.Content.ReadFromJsonAsync<ResponseC>();
        if (responseC.ok == true)
        {
            candidate = new Candidato();
            archivoTemp = null;
            archivo = new Archivo();
            estado = false;
            Navigate.NavigateTo("vacantes-publicas");
            await Swal.FireAsync("¡Exito!", $"{responseC.message}", "success");
        }
        else
        {
            await Swal.FireAsync("Oops...", $"{responseC.message}", "error");
        }
    }
    public class ResponseC
    {
        public bool ok { get; set; }
        public string message { get; set; }
    }
    void OnCreationDateChange(DateTime value)
    {
        //
    }

    void OnError()
    {
        // pop up an error notification
    }

    void Submit()
    {
        // submit action
    }

    void Cancel()
    {
        // cancel action
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.ADMRH.Pages.Candidatos.RegistroCandidato
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591