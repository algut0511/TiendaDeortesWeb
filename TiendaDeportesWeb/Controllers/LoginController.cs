using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaDeportesWeb.Models;

namespace TiendaDeportesWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Enter (String user, string pwd)
        {
            try
            {
                using (tiendaEntities db = new tiendaEntities())
                {
                    var usuarios = from p in db.personas
                                   where p.id_persona == int.Parse(user) && p.contrasena == pwd && p.tipo_persona == "emp"
                                   select p;
                    if (usuarios.Count()> 0)
                    {
                        personas oPersonas = usuarios.First();
                        Session["user"] = oPersonas;
                        return Content("1");
                    }

                }
            }
            catch (Exception e)
            {
                return Content("error :" + e.Message);
            }
        }
    }
}