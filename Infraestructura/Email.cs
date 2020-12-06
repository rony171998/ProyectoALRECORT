using System;
using System.Net.Mail;
using Entity;


namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }
        
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("rony171998@gmail.com","rony17abril1998");
        }
        private void ConfigurarEmail(Cliente cliente)
        {
            email = new MailMessage();
            email.To.Add(cliente.PrimerNombre); //hay debe ir el email
            email.From = new MailAddress("rony171998@gmail.com");
            email.Subject = "Registro de Usuario "
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {cliente.PrimerNombre }</b> <br " +
                $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmail(Cliente cliente)
        {

            try
            {
                ConfigurarSmt();
                ConfigurarEmail(cliente);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

    }


}
