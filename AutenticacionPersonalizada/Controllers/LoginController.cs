using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutenticacionPersonalizada.Models;
using AutenticacionPersonalizada.Utilidades;

namespace AutenticacionPersonalizada.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario modeloUsuario)
        {           
            if (Membership.ValidateUser(modeloUsuario.Login,modeloUsuario.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(modeloUsuario.Login,false);
                return null;
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}