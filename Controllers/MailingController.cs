using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASSIGNMENT1.Models;

namespace ASSIGNMENT1.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing m1 = new Mailing();
            m1.firstName = "ghada";
            m1.lastName = "messaoudi";
            m1.email = "mg@gmail.com";

            Mailing m2 = new Mailing();
            m2.firstName = "haidi";
            m2.lastName = "steve";
            m2.email = "sh@gmail.com";

            Mailing m3 = new Mailing();
            m3.firstName = "steve";
            m3.lastName = "conger";
            m3.email = "cs@gmail.com";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            return View(mailings);
        }
    }
}