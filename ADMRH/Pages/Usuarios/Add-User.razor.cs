using ADMRH.Models;
using ADMRH_API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ADMRH.Pages.Usuarios
{
    public partial class Add_User
    {
        Usuario usuario = new Usuario();
        private BasicResponse response;
        //EnviarCorreo correo = new EnviarCorreo();
        async Task PostUsers()
        {
            usuario.Contraseña = "12345678";
            usuario.IdCreacionUser = 13;
            string json = JsonConvert.SerializeObject(usuario);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await Http.PostAsync("https://localhost:44322/api/Usuarios", httpContent);
            response = await responses.Content.ReadFromJsonAsync<BasicResponse>();
            if (response.ok == true)
            {
                usuario = new Usuario();
                await Swal.FireAsync("¡Exito!", $"{response.mensaje}", "success");
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{response.mensaje}", "error");
            }
        }
    }
}
