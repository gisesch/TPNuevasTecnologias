using Figuritas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Figuritas.Controllers
{
    public class HomeController : Controller
    {
        GeneralDBContext generalDBContext = new GeneralDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Principal()
        {
            Album album = new Album("1"); 
            album.Nombre = "Hola Figurita";
            List < Figurita > figuritas = new List<Figurita>();
            figuritas.Add(new Figurita("1"));
            album.Figuritas = figuritas;
            generalDBContext.Albumes.Add(album); 
            return View(album);
        }

        public ActionResult Amigos()
        {
            ViewBag.Message = "Amigo Generico";
            return View();
        }

      
        public ActionResult Configuracion()
        {
            return View();
        }

        public ActionResult AltaUsuario()
        {
            return View();
        }
    }
}