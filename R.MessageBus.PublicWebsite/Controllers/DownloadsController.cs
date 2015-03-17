using System.IO;
using System.Net.Mail;
using System.Web.Configuration;
using System.Web.Mvc;

namespace R.MessageBus.PublicWebsite.Controllers
{
    public class DownloadsController : Controller
    {
        public FileResult Release()
        {
            var mail = new MailMessage();
            var smtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("rmessagebus@gmail.com");

            var emails = WebConfigurationManager.AppSettings["Emails"].Split(',');
            foreach (var email in emails)
            {
                mail.To.Add(email);
            }
            mail.Subject = "Monitor Release Package Downloaded";
            mail.Body = "Monitor Release Package Downloaded";

            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential(WebConfigurationManager.AppSettings["EmailUsername"], WebConfigurationManager.AppSettings["EmailPassword"]);
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);

            return File("../Content/R.MessageBus.Monitor.zip", "application/zip", "R.MessageBus.Monitor.zip");
        }

        public FileResult Installer()
        {
            var mail = new MailMessage();
            var smtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("rmessagebus@gmail.com");

            var emails = WebConfigurationManager.AppSettings["Emails"].Split(',');
            foreach (var email in emails)
            {
                mail.To.Add(email);
            }
            mail.Subject = "Monitor Installer Downloaded";
            mail.Body = "Monitor Installer Downloaded";

            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential(WebConfigurationManager.AppSettings["EmailUsername"], WebConfigurationManager.AppSettings["EmailPassword"]);
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);

            return File("../Content/R.MessageBus.Monitor.Setup.msi", "application/octet-stream", "R.MessageBus.Monitor.Setup.msi");
        }
    }
}
