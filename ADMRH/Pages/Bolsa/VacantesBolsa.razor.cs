using ADMRH.Models;
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
        public bool filterAlert { get; set; }
        public string Buscar { get; set; }
        protected override async Task OnInitializedAsync()
        {
            loading = true;
            response = await http.GetFromJsonAsync<ResponseV>("https://localhost:44322/api/Vacantes");
            if (response != null)
            {
                loading = false;
            }
            var user = await localStorageService.GetItemAsync<UserClaims>("user");
            if (user?.IdUsuario != default)
            {
                Navigate.NavigateTo("/home");
            }

        }

        void ApplyJob(int idVacante)
        {
            Navigate.NavigateTo($"vacantes-publicas/registro-candidato/{idVacante}");
        }

        public bool IsVisible(Vacante  _vacante)
        {
            if (string.IsNullOrEmpty(Buscar))
                return true;
            if (_vacante.Nombre.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
                return true;
            if (_vacante.Provincia.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
                return true;
            if (_vacante.Cargo.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
                return true;
            if (_vacante.EstadoPuesto.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
        public class ResponseV
        {
            public bool ok { get; set; }
            public List<Vacante> vacante { get; set; }
            public string? mensaje { get; set; }
        }
    }
}
