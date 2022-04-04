using ADMRH_API.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ADMRH.Pages.Usuarios
{
    public partial class View_usuarios_page
    {
        Usuario usuario = new Usuario();


        [Parameter]
        public string idUsuario { get; set; }
        HttpClient http = new HttpClient();

        protected override async Task OnInitializedAsync()
        {
            usuario = await http.GetFromJsonAsync<Usuario>($"https://localhost:44322/api/Usuarios/{idUsuario}");
        }
    }
}
