using Cooperchip.ITDeveloper.Mvc.ServiceApp.Settings;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace Cooperchip.ITDeveloper.Mvc.ServiceApp.Services
{
    public static class EmailService
    {
        public static void EnviarEmail(string fromAddress, string toAddress, string subjectText, string bodyText, [FromServices]EmailCredentialsSettings options)
        {
            var newMesange = new MailMessage();
            var senderAddress = new MailAddress(fromAddress);
            var recipientAddress= new MailAddress(toAddress);

            newMesange.To.Add(recipientAddress);
            newMesange.From=senderAddress;
            newMesange.Subject=subjectText;
            newMesange.Body=bodyText;
            newMesange.BodyEncoding=System.Text.Encoding.UTF8;
            newMesange.DeliveryNotificationOptions=DeliveryNotificationOptions.OnFailure;


            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl=true,
                Timeout=10000,
                DeliveryMethod=SmtpDeliveryMethod.Network,
                UseDefaultCredentials=false,
                Credentials=new NetworkCredential(options.EmailSender, options.EmailPassword)
            };
            client.Send(newMesange);
        }
    }
}
