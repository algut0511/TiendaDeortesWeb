﻿using System.Web;
using System.Web.Mvc;

namespace TiendaDeportesWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //habilitar el filtro de sesión

           // filters.Add(new Filters.Verificar_Session());
        }
    }
}
