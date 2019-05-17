using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaDeportesWeb.Models;
using TiendaDeportesWeb.Models.DTOs;

namespace TiendaDeportesWeb.Controllers
{
    public class FabricantesController : Controller
    {
        // GET: Fabricantes
        public ActionResult Index()
        {
            List<FabricantesDTO> lstFabricantes = null;
            using (tiendaEntities db = new tiendaEntities())
            {
                lstFabricantes = (from f in db.fabricantes
                                  orderby f.nombre_fabricante
                                  select new FabricantesDTO
                                  {
                                      idFabrbricante = f.id_fabricante,
                                      nomFabrbricante = f.nombre_fabricante,
                                      paisFabrbricante = f.pais_fabricantes
                                  }).ToList();
            }
                return View(lstFabricantes);
        }
    }
}