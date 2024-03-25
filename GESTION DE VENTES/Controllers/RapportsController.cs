using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class RapportsController : Controller
    {
        // GET: Rapports
        public ActionResult BLF_NON_LIVRE()
        {
            return View();
        }

        public ActionResult RAPPORT_JOURNALIER()
        {
            return View();
        }
        public ActionResult DEPENSE_DIVERSE()
        {
            return View();
        }
    }
}