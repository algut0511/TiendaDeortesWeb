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
        public ActionResult Add()
        {
            FabricantesDTO fabricantesDTO = new FabricantesDTO();
            List<dominios> lstPaises = null;

            using (tiendaEntities db = new tiendaEntities())
                {
                lstPaises = (from d in db.dominios
                            where d.tipo_dominio == "PAISES"
                            orderby d.valor_dominio
                            select new dominios
                            {
                                id_dominio = d.id_dominio,
                                valor_dominio = d.valor_dominio

                            }).ToList();
                fabricantesDTO.lstPaises = lstPaises;
            }
            return View(fabricantesDTO);
        }
    }
}