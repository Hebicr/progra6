using progra6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace progra6.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string usuario, string password)
        {
            try
            {
                using (progra6Entities db = new progra6Entities())
                {
                    var lista = from u in db.users where u.usuario == usuario && u.pass == password && u.activo == "A" select u;

                    if (lista.Count() > 0)
                    {
                        user myUser = lista.First();
                        Session["Usuario"] = myUser;
                        return Content("ok");
                    }
                    else
                    {
                        return Content("Usuario Invalido");
                    }

                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error : " + ex.Message);
            }
        }
    }
}