using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESTION_DE_VENTES.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article/ARTICLE_LIST
        public ActionResult ARTICLE_LIST()
        {
            return View();
        }

        public ActionResult DETAILS()
        {
            return View();
        }
    }
}