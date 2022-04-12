using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ADMRH.Models;
using ADMRH.Pages.Vacantes;
using ADMRH_API.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using static ADMRH.Pages.Candidatos.RegistroCandidato;

namespace ADMRH.Pages.Candidatos
{
    public partial class View_candidatos_page
    {
        List<Vacante> vacantes;
        Archivo archivo;
        HttpClient http = new HttpClient();
        Response response, responseAll;
        Candidato candidate = new Candidato();
        ResponseC responseC;
        UserClaims userClaims;
        
        int IdVacante;
        [Parameter]
        public int idCandidato { get; set; }

        public bool mostrar { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                userClaims = await localStorageService.GetItemAsync<UserClaims>("user");
                responseC = await http.GetFromJsonAsync<ResponseC>($"https://localhost:44322/api/Candidatos/{idCandidato}");
               
                IdVacante = candidate.IdVacante;
                responseAll = await http.GetFromJsonAsync<Response>($"https://localhost:44322/api/Vacantes");
                StateHasChanged();
                if (responseC != null)
                {
                if (!responseC.ok)
                {
                    await Swal.FireAsync("Oops...", $"{responseC.message}", "error");
                    navigate.NavigateTo("candidatos");
                }
                else
                {
                    candidate = responseC.candidatos;
                    archivo = await http.GetFromJsonAsync<Archivo>($"https://localhost:44322/api/Archivos/{responseC.candidatos.IdArchivos}");
                    await GetVacanteOfCandidate();
                    StateHasChanged();
                    }
                }
               
            }
            catch (Exception)
            {

                Console.WriteLine();
            }

        }

        async Task EditCandidate()
        {
            candidate.IdUsuarioCreacion = userClaims.IdUsuario;
            string json = JsonConvert.SerializeObject(candidate);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://localhost:44322/api/Candidatos/{candidate.IdCandidato}", httpContent);
            responseC = await responses.Content.ReadFromJsonAsync<ResponseC>();
            if (responseC.ok == true)
            {
                await GetVacanteOfCandidate();
                await Swal.FireAsync("¡Exito!", $"{responseC.message}", "success");
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{responseC.message}", "error");
            }
        }

        async Task GetVacanteOfCandidate()
        {
            response = await http.GetFromJsonAsync<Response>($"https://localhost:44322/api/Vacantes/{candidate.IdVacante}");
            vacantes = response.vacante;
        }
    }
}
