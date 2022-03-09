using ADMRH_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ADMRH.Pages.Vacantes
{
    public partial class Vacantes_table
    {
        HttpClient http = new HttpClient();
        //public Root files;
        List<Vacante> vacantes;
        protected override async Task OnInitializedAsync()
        {

            vacantes = new List<Vacante>()
            {
                new Vacante()
                {
                    Nombre = "Yunior",
                    Departamento = "prueba",
                    Descripcion = "prueba",
                    Cargo = "prueba",
                    Salario = "prueba"
                },
                 new Vacante()
                {
                    Nombre = "Yunior",
                    Departamento = "prueba",
                    Descripcion = "prueba",
                    Cargo = "prueba",
                    Salario = "prueba"
                },
                  new Vacante()
                {
                    Nombre = "Yunior",
                    Departamento = "prueba",
                    Descripcion = "prueba",
                    Cargo = "prueba",
                    Salario = "prueba"
                },
                   new Vacante()
                {
                    Nombre = "Yunior",
                    Departamento = "prueba",
                    Descripcion = "prueba",
                    Cargo = "prueba",
                    Salario = "prueba"
                },

            };


            //var archivo = new Archivo()
            //{
            //    FotoFrente = "unll",
            //    FotoPerfil = "dsd",
            //    Cv = "sda"
            //};

            //var json = JsonConvert.SerializeObject(archivo);

            //await http.PostAsJsonAsync<Archivo>("https://localhost:44322/api/Archivos", archivo);

            //try
            //{
            //    files = await http.GetFromJsonAsync<Root>("https://localhost:44322/api/Archivos");
            //    Console.WriteLine(files);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }
    }
}
