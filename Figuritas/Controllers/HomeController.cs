using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Figuritas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Principal()
        {
            ViewBag.Message = "Bienvenido MA...merto";
            return View();
        }

        public ActionResult Amigos()
        {
            return View();
        }

      
        public ActionResult Configuracion()
        {
            return View();
        }
    }
}