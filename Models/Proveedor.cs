using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class Proveedor
    {
        [Key]
        public int CodigoProveedor { get; set; }
        [Display(Name = "Nombre del Proveedor")]
        public string NombreProveedor { get; set; }
        [Display(Name = "Direccion")]
        public string DireccionProveedor { get; set; }
        [Display(Name = "Telefono")]
        public string TelefonoProveedor { get; set; }

        public bool Status { get; set; }
    }
}
