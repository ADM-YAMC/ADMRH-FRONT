using ADMRH.Models;
using ADMRH_API.Models;
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
        protected override async Task OnInitializedAsync()
        {
            usuario = await http.GetFromJsonAsync<Usuario>($"https://localhost:44322/api/Usuarios/{idUsuario}");
            cedula = await http.GetFromJsonAsync<CedulaUsuario?>($"https://api.adamix.net/apec/cedula/{usuario.Cedula}");
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
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{response.mensaje}", "error");
            }
        }


        public class ResponseUser
        {
            public bool ok { get; set; }
            public string mensaje { get; set; }
        }
    }
}
