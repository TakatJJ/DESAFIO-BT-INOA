using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace MarketGuide
{
    internal class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message, string ativo)
        {

            List<string> configs = new List<string>();
            Reader reader = new Reader();
            configs = reader.GetContent("D:/DESAFIOS INOA/DESAFIO BT INOA/MarketGuide/MarketGuide/SMTPConfig.txt");
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(configs[0], configs[1]);

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(configs[0]);
                mailMessage.To.Add(email);
                mailMessage.Body= $"Espero que esteja bem. Sugiro a {message} do ativo {ativo} devido a mudanças no mercado. Podemos discutir mais detalhes em uma reunião.\r\n\r\nEstou à disposição.";
                mailMessage.Subject = subject;
                mailMessage.Priority = MailPriority.High;
            
                 // Send the email
                 smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            return Task.CompletedTask;
            
        }
    }
}
