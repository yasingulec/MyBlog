using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Helpers
{
    public class MailSendHelper
    {
        public void SendMessage()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("GG", "yasin.gulec94@outlook.com"));
            message.To.Add(new MailboxAddress("Yasin Güleç", "m.yasingulec@gmail.com"));
            message.Subject = "How you doin'?";
            message.Body = new TextPart("plain")
            {
                Text = @"Hey Chandler,

I just wanted to let you know that Monica and I were going to go play some paintball, you in?

-- Joey"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                //client.AuthenticationMechanisms.Remove("XOAUTH2");
                // Note: only needed if the SMTP server requires authentication
                //client.Authenticate("****", "****");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
