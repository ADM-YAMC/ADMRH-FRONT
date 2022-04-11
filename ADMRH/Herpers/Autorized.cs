using ADMRH.Models;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADMRH.Herpers
{
    public class Autorized
    {
        [Inject]
        protected ILocalStorageService localStorageService { get; set; }

        UserClaims userClaims;
        public async Task<bool> IsAutorized()
        {
            try
            {
                userClaims = await localStorageService.GetItemAsync<UserClaims>("user");
                Console.WriteLine(userClaims.Rol);
                if (userClaims?.Rol == "Administrador")
                {
                    Console.WriteLine(userClaims.Rol);
                    return true;
                }
                else
                {
                    Console.WriteLine(userClaims.Nombre);
                    Console.WriteLine(userClaims.Rol);
                    return false;
                }
                
                
            }
            catch (Exception)
            {
                return true;
            }
            
        }
    }
}
