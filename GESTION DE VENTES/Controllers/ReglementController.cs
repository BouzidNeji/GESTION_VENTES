using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class ReglementController : Controller
    {
        public ActionResult ENCAISSEMENT()
        {
            return View();
        }

        public ActionResult DECAISSEMENT()
        {
            return View();
        }

        public ActionResult CHQ_TRAITE()
        {
            return View();
        }
    }
}