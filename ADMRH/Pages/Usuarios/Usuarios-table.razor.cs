using ADMRH_API.Models;
using CurrieTechnologies.Razor.SweetAlert2;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ADMRH.Pages.Usuarios
{
    public partial class Usuarios_table
    {
        HttpClient http = new HttpClient();
        //public Root files;
        List<Usuario> usuarios;
        private ResponseUser response;
        RadzenDataGrid<Usuario> grid;
        public bool loading { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            loading = true;
            usuarios = await http.GetFromJsonAsync<List<Usuario>>("https://localhost:44322/api/Usuarios");
            if (usuarios != null)
            {
                loading = false;
            }

        }

        async Task ConfirmacionElimanarUsuario(Usuario usuario)
        {
            var result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Estas seguro?",
                Text = "¿Estas seguro de que quieres eliminar el usuario?",
                Icon = SweetAlertIcon.Warning,
                ShowCancelButton = true,
                ConfirmButtonText = "Si, Eliminar",
                CancelButtonText = "No"
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                await deleteVacante(usuario);
            }
        }
        async Task deleteVacante(Usuario usuario)
        {
            usuarios.Remove(usuario);
            var responses = await http.DeleteAsync($"https://localhost:44322/api/Usuarios/{usuario.IdUsuario}");
            response = await responses.Content.ReadFromJsonAsync<ResponseUser>();
            if (response.ok)
            {
                await Swal.FireAsync("¡Exito!", $"{response.mensaje}", "success");
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{response.mensaje}", "error");
            }
            await grid.Reload();
        }

    }
    public class ResponseUser
    {
        public bool ok { get; set; }
        public string mensaje { get; set; }
    }

}

