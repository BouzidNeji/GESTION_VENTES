using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class FournisseurController : Controller
    {
        // GET: Fournisseur
        public ActionResult FOURNISSEUR_LIST()
        {
            return View();
        }

        public ActionResult DETAILS()
        {
            return View();
        }
        
    }
}