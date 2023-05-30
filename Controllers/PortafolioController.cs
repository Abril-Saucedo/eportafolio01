using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eportafolio.Controllers
{
    public class PortafolioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}