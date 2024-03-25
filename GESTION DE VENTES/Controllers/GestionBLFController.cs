using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class GestionBLFController : Controller
    {
        // GET: BonLivraison/BL_ACHAT_LIST
        public ActionResult BL_ACHAT_LIST()
        {
            return View();
        }

        public ActionResult ADD_BLF()
        {
            return View();
        }
        public ActionResult DETAILS_BLF()
        {
            return View();
        }
        public ActionResult BL_RATTAHCE()
        {
            return View();
        }
        
    }
}