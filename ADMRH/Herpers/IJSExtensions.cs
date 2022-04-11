using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADMRH.Herpers
{
    public static class IJSExtensions
    {
        public static async Task GuardarComo(this IJSRuntime js, string nombreArchivo, byte[] archivo)
        {
            await js.InvokeAsync<object>("saveAsFile", nombreArchivo, Convert.ToBase64String(archivo));
        }
    }
}
