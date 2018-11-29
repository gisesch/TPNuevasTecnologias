using Figuritas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
            TempData.Remove("Usuario");
            return View();
        }

       
        public ActionResult Principal(Usuario usuarioLogueado)
        {
            if (usuarioLogueado == null)
            {
                if (!TempData.Keys.Contains("Usuario"))
                {
                    return HttpNotFound("Hubo un error con el usuario. Intente mas tarde");
                }
                else
                {
                    usuarioLogueado = (Usuario)TempData["Usuario"];
                    TempData.Remove("Usuario");
                }
            }
            else if (string.IsNullOrWhiteSpace(usuarioLogueado.Email))
            {
                if (!TempData.Keys.Contains("Usuario"))
                {
                    return HttpNotFound("El usuario es invalido");
                }
                else
                {
                    usuarioLogueado = (Usuario)TempData["Usuario"];
                    TempData.Remove("Usuario");
                }
            }
            Usuario usuarioValido = generalDBContext.Usuarios.Find(usuarioLogueado.Email);

            if (usuarioValido == null)
            {
                return HttpNotFound("El usuario no se encuentra registrado");
            }
            TempData.Add("Usuario", usuarioValido);

            Album album = GetAlbumById(usuarioValido.IdAlbum);
                            
            if(album == null)
            {
                return HttpNotFound("El usuario no posee un album");
            }

            ViewBag.Title = album.Nombre;
            return View(album.Figuritas);
       
        }

        public ActionResult Actualizar(List<Figurita> figuritas)
        {
            Album album = GetAlbumById(figuritas.First().IdAlbum);

            if (album == null)
            {
                return HttpNotFound("El album no se encontro");
            }

            figuritas.ForEach(f => generalDBContext.Figuritas.AddOrUpdate(x => new { x.Numero, x.IdAlbum }, f));
            generalDBContext.SaveChanges();

            return View("Principal", figuritas);



        }

        public ActionResult Amigos()
        {
            Usuario usuarioLogueado = null;

            if (TempData.Keys.Contains("Usuario"))
            {
                usuarioLogueado = (Usuario)TempData.Peek("Usuario");
            }
            

            if (usuarioLogueado == null)
            {
                return HttpNotFound("Hubo un error con el usuario. Intente mas tarde");
            }
            else if (string.IsNullOrWhiteSpace(usuarioLogueado.Email))
            {
                return HttpNotFound("El usuario es invalido");
            }

            Usuario amigoValido = generalDBContext.Usuarios.Find(usuarioLogueado.CodAmigo);

            if (amigoValido == null)
            {
                return HttpNotFound("El usuario no se encuentra registrado");
            }

            Album album = GetAlbumById(amigoValido.IdAlbum);

            if (album == null)
            {
                return HttpNotFound("El usuario no posee un album");
            }

            return View(album);

        }

      
        public ActionResult Configuracion()
        {
            return View();
        }

        public ActionResult AltaUsuario()
        {
            return View();
        }




        #region metodos privados

        private Album GetAlbumById(String idAlbum)
        {
            Album albumResultado = generalDBContext.Albumes.Find(idAlbum);

            if (albumResultado != null)
            {
                albumResultado.Figuritas = (from listaFiguritas in generalDBContext.Figuritas
                                            where listaFiguritas.IdAlbum == idAlbum
                                            select listaFiguritas).ToList();
            }

            return albumResultado;
        }

        #endregion
    }


}







