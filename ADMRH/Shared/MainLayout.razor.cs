using ADMRH.Models;
using System;
using System.Threading.Tasks;

namespace ADMRH.Shared
{
    public partial class MainLayout
    {
        UserClaims userClaims;

        protected override async Task OnInitializedAsync()
        {
            userClaims = await localStorageService.GetItemAsync<UserClaims>("user");

            if (userClaims?.IdUsuario == default)
            {
                await localStorageService.RemoveItemAsync("user");
                Navigate.NavigateTo("/login");
                return;
            }
            Console.WriteLine(userClaims?.Apellido);
        }
    }
}
