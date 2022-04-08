using ADMRH_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
namespace ADMRH.Pages.Bolsa
{
    public partial class VacantesBolsa
    {
        ResponseV response;
        public bool loading { get; set; }
        protected override async Task OnInitializedAsync()
        {
            loading = true;
            response = await http.GetFromJsonAsync<ResponseV>("https://localhost:44322/api/Vacantes");
            if (response != null)
            {
                loading = false;
            }

        }

        void ApplyJob(int idVacante)
        {
            Navigate.NavigateTo($"vacantes-publicas/registro-candidato/{idVacante}");
        }

        public class ResponseV
        {
            public bool ok { get; set; }
            public List<Vacante> vacante { get; set; }
            public string? mensaje { get; set; }
        }
    }
}
