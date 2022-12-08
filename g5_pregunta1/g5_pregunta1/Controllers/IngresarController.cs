using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g5_pregunta1.Clases;
using g5_pregunta1.Models;
using System.Web.Security;

namespace g5_pregunta1.Controllers
{
    public class IngresarController : Controller
    {
        // GET: Ingresar
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario usuario, string url)
        {
            if (IsValid(usuario))
            {
                /* Si el usuario es valido se genera un Cookie  con FALSE para que no persista */
                FormsAuthentication.SetAuthCookie(usuario.EMAIL, false);
                if (url != null)
                {
                    /* Si el usuario es valido y si la URL es diferente de nulo */
                    return Redirect(url);
                }
                /* Si no se va al home de la aplicación */
                return RedirectToAction("Index", "Home");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas.";
            return View(usuario);

        }

        public bool IsValid(Usuario usuario)
        {
            return usuario.Autenticar();
        }

        public ActionResult LogOut(Usuario usuario, string url)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}