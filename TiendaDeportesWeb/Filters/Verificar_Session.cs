using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaDeportesWeb.Models;
using TiendaDeportesWeb.Controllers;
namespace TiendaDeportesWeb.Filters
{
    public class Verificar_Session : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // obtener de la seccion los datos de la persona logueada

            var oPersona = (personas)HttpContext.Current.Session["user"];
                // si la sesión no existe redireccionamos al login

            if(oPersona == null)
            {
                if (filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/home/Index");
                }
            }
            else
            {
                if (filterContext.Controller is LoginController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/home/Index");
                }
            }
;            base.OnActionExecuting(filterContext);
        }
    }
}