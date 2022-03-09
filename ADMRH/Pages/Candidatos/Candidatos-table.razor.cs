using ADMRH_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADMRH.Pages.Candidatos
{
    public partial class Candidatos_table
    {
        List<Candidato> candidatos;
        protected override async Task OnInitializedAsync()
        {

            candidatos = new List<Candidato>()
            {
                new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                 new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                  new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                   new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                    new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                     new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                      new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                       new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
                },
                        new Candidato()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Cedula = "9876545678",
                    Direccion = "Bayaguana",
                    Telefono = "987654567",
                    Correo = "yunior@gmail.com"
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
