using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class Producto
    {
        [Key]
        public int CodigoProducto { get; set; }

        [Display(Name = "Nombre Producto")]
        public string NombreProducto { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Precio por Mayor")]
        public double PrecioXMayor { get; set; }

        [Display(Name = "Precio por Menor")]
        public double PrecioXMenor { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha vencimiento")]
        public DateTime? FechaVencimiento { get; set; }

        public bool Status { get; set; }

        [Required]
        public int ProveedorId { get; set; }

        public Proveedor CodigoProveedor { get; set; }
    }
}
