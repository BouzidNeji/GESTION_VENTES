using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class GestionPaieController : Controller
    {
        public ActionResult PRET()
        {
            return View();
        }

        public ActionResult AVANCE_SALAIRE()
        {
            return View();
        }
        public ActionResult SOLDE_COLLABORATEUR()
        {
            return View();
        }
    }
}