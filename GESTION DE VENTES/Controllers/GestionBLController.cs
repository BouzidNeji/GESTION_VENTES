using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class GestionBLController : Controller
    {
        public ActionResult BL_VENTE_LIST()
        {
            return View();
        }
        public ActionResult ADD_BL()
        {
            return View();
        }

        public ActionResult DETAILS_BL()
        {
            return View();
        }
    }
}