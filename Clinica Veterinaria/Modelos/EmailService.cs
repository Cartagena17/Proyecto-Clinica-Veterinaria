using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class EmailService
    {
        // CONFIGURACIÓN DE EMAIL
        private string smtpServer = "smtp.gmail.com";
        private int port = 587;
        private string emailFrom = "pet.saluditr@gmail.com  "; // CAMBIAR
        private string password = "rpea yigp hrfq xini"; // CAMBIAR

        public async Task<bool> EnviarEmailRecuperacion(string emailDestino, string token)
        {
            try
            {
                using (var smtpClient = new SmtpClient(smtpServer, port))
                {
                    smtpClient.Credentials = new NetworkCredential(emailFrom, password);
                    smtpClient.EnableSsl = true;
                    smtpClient.Timeout = 30000;

                    var mensaje = new MailMessage
                    {
                        From = new MailAddress(emailFrom),
                        Subject = "Código de Recuperación - Clínica Veterinaria",
                        Body = $"Tu código de recuperación es: {token}\n\nEste código expira en 2 horas.\n\nSi no solicitaste este cambio, ignora este mensaje.",
                        IsBodyHtml = false // Texto plano
                    };

                    mensaje.To.Add(emailDestino);
                    await smtpClient.SendMailAsync(mensaje);
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log del error - sin MessageBox
                System.Diagnostics.Debug.WriteLine($"Error enviando email: {ex.Message}");
                return false;
            }
        } 
    }
}

