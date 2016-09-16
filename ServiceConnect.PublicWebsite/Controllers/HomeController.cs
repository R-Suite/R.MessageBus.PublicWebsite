using System.Net.Mail;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ServiceConnect.PublicWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guides()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("rmessagebus@gmail.com");

                var emails = WebConfigurationManager.AppSettings["Emails"].Split(',');
                foreach (var email in emails)
                {
                    mail.To.Add(email);
                }
                mail.Subject = model.Subject;
                mail.Body = model.Message;

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential(WebConfigurationManager.AppSettings["EmailUsername"], WebConfigurationManager.AppSettings["EmailPassword"]);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult GettingStarted()
        {
            return View();
        }

        public ActionResult Configuring()
        {
            return View();
        }

        public ActionResult Commands()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult PolymorphicMessages()
        {
            return View();
        }

        public ActionResult RequestReply()
        {
            return View();
        }

        public ActionResult ProcessManagers()
        {
            return View();
        }

        public ActionResult RoutingSlip()
        {
            return View();
        }

        public ActionResult RecipientList()
        {
            return View();
        }

        public ActionResult Aggregator()
        {
            return View();
        }

        public ActionResult ScatterGather()
        {
            return View();
        }

        public ActionResult Streaming()
        {
            return View();
        }

        public ActionResult ContentbasedRouting()
        {
            return View();
        }

        public ActionResult Auditing()
        {
            return View();
        }

        public ActionResult Monitor()
        {
            return View();
        }

        public ActionResult Api()
        {
            return View();
        }
    }
}

