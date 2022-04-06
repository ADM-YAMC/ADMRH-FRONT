using ADMRH_API.Models;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ADMRH.Pages.Vacantes
{
    public partial class Vacantes_table
    {
        HttpClient http = new HttpClient();
        //public Root files;
        List<Vacante> vacantes;
        RadzenDataGrid<Vacante> VacantesGrid;
        private Response response;

        [Parameter]
        public string IdUsuario { get; set; }

        public bool loading { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            loading = true;
            if (IdUsuario != null)
            {
                response = await http.GetFromJsonAsync<Response>($"https://localhost:44322/api/Vacantes/user/{IdUsuario}");
                vacantes = response.vacante;
                loading = false;

            }
            else {
                response = await http.GetFromJsonAsync<Response>($"https://localhost:44322/api/Vacantes");
                vacantes = response.vacante;
                loading = false;
            }
        }

        async Task ConfirmacionElimanarVacante(Vacante vacante)
        {
            var result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Estas seguro?",
                Text = "¿Estas seguro de que quieres eliminar la vacante?",
                Icon = SweetAlertIcon.Warning,
                ShowCancelButton = true,
                ConfirmButtonText = "Si, Eliminar",
                CancelButtonText = "No"
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                loading = true;
                await deleteVacante(vacante);
            }
        }
        async Task deleteVacante(Vacante vacante)
        {
            vacantes.Remove(vacante);
            var responses = await http.DeleteAsync($"https://localhost:44322/api/Vacantes/{vacante.IdVacante}");
            response = await responses.Content.ReadFromJsonAsync<Response>();
            if (response.ok)
            {
                await Swal.FireAsync("¡Exito!", $"{response.mensaje}", "success");
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{response.mensaje}", "error");
            }
            await VacantesGrid.Reload();
            if (response != null)
                loading = false;
        }

    }

    public class Response
    {
        public bool ok { get; set; }
        public List<Vacante> vacante { get; set; }
        public string? mensaje { get; set; }
    }
}
