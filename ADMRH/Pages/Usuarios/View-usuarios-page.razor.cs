using ADMRH.Models;
using ADMRH_API.Models;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ADMRH.Pages.Usuarios
{
    public partial class View_usuarios_page
    {
        Usuario usuario = new Usuario();
        public bool OpenEdit { get; set; } = false;

        [Parameter]
        public string idUsuario { get; set; }
        HttpClient http = new HttpClient();
        CedulaUsuario cedula = new CedulaUsuario();
        private ResponseUser response;
        private ResponseMessageCountCantidaVC responseMessageCountCantidaVC;
        UserClaims userClaims;
        CambioContraseña cambio = new CambioContraseña();
        public bool boolvalue { get; set; }
        public bool loading { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                userClaims = await localStorageService.GetItemAsync<UserClaims>("user");
                if (!userClaims.Rol.Equals("Administrador"))
                {
                    navigate.NavigateTo("home");
                }
                loading = true;
                await ReloadUser();
                cedula = await http.GetFromJsonAsync<CedulaUsuario?>($"https://api.adamix.net/apec/cedula/{usuario.Cedula}");
                responseMessageCountCantidaVC = await http.GetFromJsonAsync<ResponseMessageCountCantidaVC>($"https://localhost:44322/api/Usuarios/cantidadVC/{idUsuario}");
                if (usuario != null)
                    loading = false;
                
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        async Task ReloadUser()
        {
            usuario = await http.GetFromJsonAsync<Usuario>($"https://localhost:44322/api/Usuarios/{idUsuario}");
        }


        async Task OnPutAsync()
        {
            string json = JsonConvert.SerializeObject(usuario);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://localhost:44322/api/Usuarios/{idUsuario}", httpContent);
            response = await responses.Content.ReadFromJsonAsync<ResponseUser>();
            if (response.ok == true)
            {
                await Swal.FireAsync("¡Exito!", $"{response.mensaje}", "success");
                loading = false;
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{response.mensaje}", "error");
                loading = false;
            }
        }
        async Task OnPutPassAsync()
        {
            loading = true;
            string json = JsonConvert.SerializeObject(cambio);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://localhost:44322/api/Usuarios/cambioContraseña/{idUsuario}", httpContent);
            response = await responses.Content.ReadFromJsonAsync<ResponseUser>();
            if (response.ok == true)
            {

                await Swal.FireAsync("¡Exito!", $"{response.mensaje}", "success");
                cambio = new CambioContraseña();
                loading = false;
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{response.mensaje}", "error");
                cambio = new CambioContraseña();
                loading = false;
            }
        }

        async Task OnPutLookUnLokUserAsync(int estado)
        {
            loading = true;
            string json = JsonConvert.SerializeObject(cambio);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://localhost:44322/api/Usuarios/LookUnLookUser/{idUsuario}/{estado}", httpContent);
            response = await responses.Content.ReadFromJsonAsync<ResponseUser>();
            if (response.ok == true)
            {

                await Swal.FireAsync("¡Exito!", $"{response.mensaje}", "success");
                await ReloadUser();
                loading = false;
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{response.mensaje}", "error");
                cambio = new CambioContraseña();
                loading = false;
            }
        }


        async Task ConfirmacionLookUnLookUsuario(int estado)
        {
            var tipo = estado == 1 ? "bloquear" : "desbloquear";
            var result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "Precaución",
                Text = $"¿Estas seguro de que quieres { tipo} el usuario?",
                Icon = SweetAlertIcon.Warning,
                ShowCancelButton = true,
                ConfirmButtonText = $"Si, {tipo}",
                CancelButtonText = "No"
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                await OnPutLookUnLokUserAsync(estado);
            }
        }


        void OnInitModal()
        {
            cambio.rnuevaContraseña = "nan";
            cambio.idUsuario = usuario.IdUsuario;
            cambio.viejaContraseña = usuario.Contraseña;

        }

        void toggle()
        {
            boolvalue = !boolvalue;
            if (boolvalue)
            {
                cambio.Estado = 1;
            }
            else
            {
                cambio.Estado = 0;
            }
        }


        public class ResponseUser
        {
            public bool ok { get; set; }
            public string mensaje { get; set; }
        }
    }
}
