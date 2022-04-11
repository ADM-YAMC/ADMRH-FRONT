using ADMRH_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using CurrieTechnologies.Razor.SweetAlert2;
using Radzen.Blazor;
using static ADMRH.Pages.Candidatos.RegistroCandidato;
using ADMRH.Herpers;
using ADMRH.Models;

namespace ADMRH.Pages.Candidatos
{
    public partial class Candidatos_table
    {
        List<Candidato> candidatos;
        RadzenDataGrid<Candidato> radzenDataGrid;
        public bool loading { get; set; }
        ResponseC responseC;
        UserClaims userClaims;
        protected override async Task OnInitializedAsync()
        {
            candidatos = await http.GetFromJsonAsync<List<Candidato>>("https://localhost:44322/api/Candidatos");
            userClaims = await localStorageService.GetItemAsync<UserClaims>("user");
        }

        async Task ConfirmacionElimanarCandidato(Candidato candidato)
        {
            var result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Estas seguro?",
                Text = "¿Estas seguro de que quieres eliminar el candidato?",
                Icon = SweetAlertIcon.Warning,
                ShowCancelButton = true,
                ConfirmButtonText = "Si, Eliminar",
                CancelButtonText = "No"
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                loading = true;
                await deleteCandidato(candidato);
            }
        }
        async Task deleteCandidato(Candidato candidato)
        {
            candidatos.Remove(candidato);
            var responses = await http.DeleteAsync($"https://localhost:44322/api/Candidatos/{candidato.IdCandidato}");
            responseC = await responses.Content.ReadFromJsonAsync<ResponseC>();
            if (responseC.ok)
            {
                await Swal.FireAsync("¡Exito!", $"{responseC.message}", "success");
            }
            else
            {
                await Swal.FireAsync("Oops...", $"{responseC.message}", "error");
            }
            await radzenDataGrid.Reload();
            if (responseC != null)
                loading = false;
        }

      
        //public async Task<bool> IsAutorized()
        //{
        //    try
        //    {
        //        userClaims = await localStorageService.GetItemAsync<UserClaims>("user");
        //        Console.WriteLine(userClaims.Rol);
        //        if (userClaims?.Rol == "Administrador")
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return true;
        //    }

        //}
    }
}
