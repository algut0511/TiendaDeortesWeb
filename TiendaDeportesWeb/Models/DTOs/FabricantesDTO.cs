using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TiendaDeportesWeb.Models.DTOs
{
    public class FabricantesDTO
    {
        public decimal idFabrbricante {get; set;}
        [Required]
        [Display(Name ="Nombre Fabricante")]
        public string nomFabrbricante { get; set; }

        [Required]
        [Display(Name = "Pais Fabricante")]
        public string paisFabrbricante { get; set; }

        public List<dominios> lstPaises { get; set; }
    }
}