using ADMRH_API.Models;
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
        protected override async Task OnInitializedAsync()
        {

            usuarios = await http.GetFromJsonAsync<List<Usuario>>("https://localhost:44322/api/Usuarios");

        }
    }
}
