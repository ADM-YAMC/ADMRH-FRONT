using ADMRH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using ADMRH_API.Models;
using ADMRH.Herpers;
using ADMRH.Pages.Candidatos;
namespace ADMRH.Pages
{
    public partial class Index
    {
        HttpClient http = new HttpClient();
        public Root files;
        List<Usuario> usuarios;
        private ResponsecantidadTotal_UCV total_UCV;
        UserClaims userClaims;
        protected override async Task OnInitializedAsync()
        {
            try
            {
<<<<<<< HEAD
                var user = await localStorageService.GetItemAsync<UserClaims>("user");

                if (user?.IdUsuario == default)
=======
                userClaims = await localStorageService.GetItemAsync<UserClaims>("user");

                if (userClaims?.IdUsuario == default)
>>>>>>> a5001a07adaa5f33667098832c471a1decf94ef3
                {
                    await localStorageService.RemoveItemAsync("user");
                    Navigate.NavigateTo("/login");
                    return;
                }
<<<<<<< HEAD

=======
                Console.WriteLine(userClaims?.Apellido);
>>>>>>> a5001a07adaa5f33667098832c471a1decf94ef3
                total_UCV = await http.GetFromJsonAsync<ResponsecantidadTotal_UCV>("https://localhost:44322/api/Usuarios/cantidadTotal_UCV");
                StateHasChanged();
            }
            catch (Exception)
            {


            }
        }
        

        async Task get()
        {
            await http.GetFromJsonAsync<Archivo>("");
        }

        public class ResponsecantidadTotal_UCV
        {
            public bool ok { get; set; }
            public int cantidadTVacantes { get; set; }
            public int CantidadTCandidatos { get; set; }
            public int CantidadTUsuarios { get; set; }
        }
    }
}
