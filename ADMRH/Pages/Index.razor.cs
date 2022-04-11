using ADMRH.Models;
using ADMRH_API.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
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
                userClaims = await localStorageService.GetItemAsync<UserClaims>("user");

                Console.WriteLine(userClaims?.Apellido);
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
