using ADMRH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using ADMRH_API.Models;

namespace ADMRH.Pages
{
    public partial class Index
    {
        HttpClient http = new HttpClient();
        public Root files;
        List<Usuario> usuarios;
        private ResponsecantidadTotal_UCV total_UCV;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                total_UCV = await http.GetFromJsonAsync<ResponsecantidadTotal_UCV>("https://localhost:44322/api/Usuarios/cantidadTotal_UCV");
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
