using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutenticacionPersonalizada.Utilidades;

namespace AutenticacionPersonalizada.Controllers
{[Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ////Para recuperar valores definidos en webconfig como keys
            //var clave = ConfigurationManager.AppSettings["ClaveCifrado"];

            ////Se pasan dos argumentos: la pwd que pone el usuario y 
            ////la key (que es fija y definida en webconfig, por ej)
            //var cifrado = SeguridadUtilidades.Cifrar("UsuarioPrueba", clave);

            //var datosCifrados = Convert.FromBase64String(cifrado);

            ////Se pasan dos argumentos: el contenido cifrado recuperado de la db y
            ////la key (que es fija y definida en webconfig, por ej)
            //var descifrado = SeguridadUtilidades.Descifrar(datosCifrados, clave);
            return View();
        }
    }
}