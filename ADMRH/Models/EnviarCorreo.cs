using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using ADMRH_API.Models;

namespace ADMRH.Models
{
    public class EnviarCorreo
    {
        public bool enviarCorreo(Usuario usuario)
        {
            string boddys = @" <style>
        .container{
            width: 100%; 
            height: 700px; 
            background: #1c57b9; 
            padding: 0px; 
            margin: 0px; 
            color: aliceblue;
        }
       .container .content-body{
        width: 40%; 
        height: 600px; 
        margin: auto;
        background: #1c57b9; 
        border: solid 2px #45536b; 
        border-radius:5px; margin-top: 2.1%; 
       }
       .content-body .content-sub-body{
        height: 600px; 
        width: 100%; 
       }
       .content-sub-body .header{
        width: 100%; 
        height: 70px; 
        margin: auto; 
        background: #023877; 
        border-top-left-radius:5px; 
        border-top-right-radius:5px;
       }
       .content-sub-body .fhotter{
        height: 70px; 
        width: 100%; 
        background: #023877; 
        margin: auto;
        border-bottom-left-radius:5px; 
        border-bottom-right-radius:5px;
       }
      .container .content-sub-body .info{
        width:90%; 
        height:440px; 
        padding:10px;
        margin: auto;
        text-align: justify;
        word-wrap: break-word;
       }
       @media only screen and (max-width: 768px) {
        .container.content - body{
            width: 90%;
            word-wrap: break-word;
        }
       }
    </style>
";
   string sub= @$"<div class='container'>
        <br />
        <div class='content-body'>
            <div class='content-sub-body'>
                <div class='header'>
                    <h1 style='padding-top:14px; padding-left:10px; margin-top: 0px; color:aliceblue'>JustQuallity</h1>
                </div>
                <div class='info'>
                    <label style='padding-top:50px;'>Hola Sr/a. {usuario.Nombre} {usuario.Apellido},</label>
                    <p style='padding-top:30px;'>Su contraseña para poder ingresar al sistema de reclutamiento es:</p>
                    <h2 style='padding-top:30px; color:aliceblue'>{usuario.Contraseña}</h2>
                    <p style='padding-top:30px;'>
                        NOTA: Una vez haya iniciado session por primera vez, deberas cambiar tu clave de acceso para que tengas mayor seguridad
                        de los datos que manejas en la aplicacion de reclutamiento.
                    </p>
                    <p style='padding-top:30px;'>Saludos cordiales,</p>
                    <p>Exitos. Un abrazo.</p>
                </div>
    
                <div class='fhotter'>
                </div>
            </div>
        </div>
    </div>";
            
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("for.foot.fusion@gmail.com", "for foot", System.Text.Encoding.UTF8);
                correo.To.Add(usuario.Correo);
                correo.Subject = "C";
                correo.Body = $"{boddys+sub}";
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                smtp.Credentials = new System.Net.NetworkCredential("for.foot.fusion@gmail.com", "Forfoot9550");//Cuenta de correo
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.Send(correo);
                return true;
            
        }
    }
}
