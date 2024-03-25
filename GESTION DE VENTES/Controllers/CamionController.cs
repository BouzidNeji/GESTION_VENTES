using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class CamionController : Controller
    {
        // GET: Camion/CAMION_LIST
        public ActionResult CAMION_LIST()
        {
            return View();
        }

        public ActionResult DETAILS()
        {
            return View();
        }
    }
}