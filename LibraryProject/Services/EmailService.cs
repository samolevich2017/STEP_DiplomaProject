using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Services {
    public class EmailService {

        public async Task SendEmailAsync(string emailClient, string nameClient, string telClient, string messageClient) {
            
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(nameClient, emailClient));
            emailMessage.To.Add(new MailboxAddress("Администрации", "librarysamol@gmail.com"));
            emailMessage.Subject = $"Запрос от {nameClient}";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) {
                Text = $"<b>Имя отправителя:</b> {nameClient}<br><b>E-mail: </b>{emailClient}<br><b>Номер тел.: </b><tel>{telClient}</tel><br><hr><br>" + messageClient
            };

            using (var client = new SmtpClient()) {
                await client.ConnectAsync("smtp.gmail.com", 587, false); // без использования SSL
                await client.AuthenticateAsync("librarysamol@gmail.com", "libr2bookI");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        } // SendEmailAsync
    }
}
