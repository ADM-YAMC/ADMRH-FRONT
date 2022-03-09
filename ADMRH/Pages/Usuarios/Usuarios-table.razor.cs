using ADMRH_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ADMRH.Pages.Usuarios
{
    public partial class Usuarios_table
    {
        HttpClient http = new HttpClient();
        //public Root files;
        List<Usuario> usuarios;
        protected override async Task OnInitializedAsync()
        {

            usuarios = new List<Usuario>()
            {
                new Usuario()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Departamento = "RRHH",
                    Telefono = "98765434567",
                    Cedula = "7655678976",
                    Rol = "Admin",
                    Correo = "yunior@gmail.com"
                },
                new Usuario()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Departamento = "RRHH",
                    Telefono = "98765434567",
                    Cedula = "7655678976",
                    Rol = "Admin",
                    Correo = "yunior@gmail.com"
                },
                new Usuario()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Departamento = "RRHH",
                    Telefono = "98765434567",
                    Cedula = "7655678976",
                    Rol = "Admin",
                    Correo = "yunior@gmail.com"
                },
                 new Usuario()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Departamento = "RRHH",
                    Telefono = "98765434567",
                    Cedula = "7655678976",
                    Rol = "Admin",
                    Correo = "yunior@gmail.com"
                }, new Usuario()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Departamento = "RRHH",
                    Telefono = "98765434567",
                    Cedula = "7655678976",
                    Rol = "Admin",
                    Correo = "yunior@gmail.com"
                }, new Usuario()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Departamento = "RRHH",
                    Telefono = "98765434567",
                    Cedula = "7655678976",
                    Rol = "Admin",
                    Correo = "yunior@gmail.com"
                }, new Usuario()
                {
                    Nombre = "Yunior",
                    Apellido = "Moreta",
                    Departamento = "RRHH",
                    Telefono = "98765434567",
                    Cedula = "7655678976",
                    Rol = "Admin",
                    Correo = "yunior@gmail.com"
                }
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
